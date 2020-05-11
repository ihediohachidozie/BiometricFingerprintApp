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
    public partial class userForm : Form
    {
        projdbEntities proj = new projdbEntities();
        bool activate;
        public userForm()
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
        private int exStaff(int x)
        {
            return proj.users.Count(i => i.staffid == x);
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtStaffid.Text != "" && txtFname.Text != "" && txtLname.Text != "")
                {
                    if (exStaff(int.Parse(txtStaffid.Text.Trim())) == 0)
                    {
                        user ur = new user()
                        {
                            staffid = int.Parse(txtStaffid.Text.Trim()),
                            firstname = txtFname.Text.Trim(),
                            lastname = txtLname.Text.Trim(),
                            password = GetMd5Sum("password"),
                            active = activate,
                            status = false,
                            createdby = 1,
                            createdon = System.DateTime.Now
                        };
                        proj.users.Add(ur);
                        proj.SaveChanges();
                        MessageBox.Show("User Created Successfully!", "Success:");
                        clear();
                        loadUsers();
                    }
                    else
                        MessageBox.Show("Staff ID already exist!", "Error:");
                }
                else
                    MessageBox.Show("No field must be empty!", "Error:");
            }
            catch (Exception)
            {
                MessageBox.Show("Database Connection Failed!", "Error:");
            }
        }

        private void chkActive_CheckedChanged(object sender, EventArgs e)
        {
            if (chkActive.Checked)
                activate = true;
            else
                activate = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (txtStaffid.Text != "" && txtFname.Text != "" && txtLname.Text != "")
                {
                    int staffid = int.Parse(txtStaffid.Text.Trim());
                    if (exStaff(int.Parse(txtStaffid.Text.Trim())) == 1)
                    {
                        user ur = proj.users.FirstOrDefault(u => u.staffid == staffid );
                        ur.lastname = txtLname.Text.Trim();
                        ur.firstname = txtFname.Text.Trim();
                        ur.active = activate;

                        proj.SaveChanges();
                        MessageBox.Show("User Updated Successfully!", "Success:");
                        loadUsers();
                        clear();
                        btnCreate.Enabled = true;
                        btnUpdate.Enabled = false;
                        btnDelete.Enabled = false;
                    }
                    else
                        MessageBox.Show("Staff ID does not exist!", "Error:");
                }
                else
                    MessageBox.Show("No field must be empty!", "Error:");
            }
            catch (Exception)
            {
                MessageBox.Show("Database Connection Failed!", "Error:");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int staffid = int.Parse(txtStaffid.Text.Trim());
                user ur = proj.users.FirstOrDefault(u => u.staffid == staffid);

                proj.users.Remove(ur);
                proj.SaveChanges();
                MessageBox.Show("User Deleted Successfully!", "Success:");
                clear();
                btnCreate.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                loadUsers();
            }
            catch (Exception)
            {
                MessageBox.Show("Databaase Connection Failed!", "Error:");
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            clear();
            this.Close();
        }
        private void clear()
        {
            txtFname.Clear();
            txtLname.Clear();
            txtStaffid.Clear();
            chkActive.Checked = false;
        }
        private void loadUsers()
        {
            lstUsers.Items.Clear();
            try
            {
                var query = from p in proj.users
                            where p.staffid != 1
                            select p;

                if (query.Count() > 0)
                {
                    List<user> post = query.ToList();

                    foreach (var x in post)
                    {
                        lstUsers.Items.Add(x.staffid + " : "+ x.firstname);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Database Connection Failed!", "Error!");
            }
        }

        private void userForm_Load(object sender, EventArgs e)
        {
            loadUsers();
            clear();
        }

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                string staffid = lstUsers.SelectedItem.ToString();
                int end = staffid.IndexOf(":");
                int id = int.Parse(staffid.Substring(0, end));

                user ur = proj.users.FirstOrDefault(u => u.staffid == id);
                txtStaffid.Text = ur.staffid.ToString();
                txtFname.Text = ur.firstname;
                txtLname.Text = ur.lastname;
                chkActive.Checked = ur.active;

                txtStaffid.ReadOnly = true;

                btnCreate.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;

            }
            catch (Exception)
            {
                MessageBox.Show("Database Connection Failed!", "Error!");
            }



        }
    }
}
