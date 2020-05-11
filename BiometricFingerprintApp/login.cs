using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiometricFingerprintApp
{
    public partial class login : Form
    {
        bool result = false;
        
        projdbEntities proj = new projdbEntities();
        public login()
        {
            InitializeComponent();
        }
        static public string GetMd5Sum(string str)
        {

            // First we need to convert the string into bytes, which
            // means using a text encoder.
            Encoder enc = System.Text.Encoding.Unicode.GetEncoder();

            // Create a buffer large enough to hold the string
            byte[] unicodeText = new byte[str.Length * 2];
            enc.GetBytes(str.ToCharArray(), 0, str.Length, unicodeText, 0, true);

            // Now that we have a byte array we can ask the CSP to hash it
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] result = md5.ComputeHash(unicodeText);

            // Build the final string by converting each byte
            // into hex and appending it to a StringBuilder
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                sb.Append(result[i].ToString("X2"));
            }

            // And return it
            return sb.ToString();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUser.Text != "" && txtPw.Text != "")
                {
                    if (authUser(int.Parse(txtUser.Text), txtPw.Text))
                    {
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Login failed!", "Error");
                    }
                }
                else
                    MessageBox.Show("No field must be empty!", "Error");
            }
            catch(Exception)
            {
                MessageBox.Show("An error has occurred!", "Error");
            }

        }

        private bool authUser(int usr, string pw)
        {
            pw = GetMd5Sum(pw);
            try
            {
                var query = from u in proj.users
                            where u.staffid == usr && u.password == pw
                            select u;

                if (query.Count() == 1)
                {
                    List<user> post = query.ToList();

                    foreach (var x in post)
                    {
                        Form1.userId = x.id;
                        Form1.fullname.Text = x.firstname + " " + x.lastname;
                        Form1.status = x.status;
                        Form1.active = x.active;
                    }
                    result = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Database error occurred!", "Error"); 
             }
            return result;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
