using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BiometricFingerprintApp
{
    //delegate void Function();	// a simple delegate for marshalling calls from event handlers to the GUI thread
    
    public partial class Enrollment : Form
    {
        string location, fingerPrint, filename;
        projdbEntities proj = new projdbEntities();
        bool result = false;
        public Enrollment()
        {
            InitializeComponent();
        }

        private void btnCapture_Click(object sender, EventArgs e)
        {
            Enroll Enroller = new Enroll();
            Enroller.OnTemplate += this.OnTemplate;
            Enroller.ShowDialog();
        }
        private void OnTemplate(DPFP.Template template)
        {
            this.Invoke(new Function(delegate ()
            {
                Template = template;
                btnSave.Enabled = (Template != null);
                if (Template != null)
                {
                    result = btnSave.Enabled = true;

                    MessageBox.Show("The fingerprint template is ready to be saved.", "Fingerprint Enrollment");
                }
                else
                    MessageBox.Show("The fingerprint template is not valid. Repeat fingerprint enrollment.", "Fingerprint Enrollment");
            }));
        }

        private DPFP.Template Template;

        private int exStudent(string x)
        {
          //  int stud = proj.students.Count(i => i.matricno == x);
            return proj.students.Count(i => i.matricno == x);
        }

        private bool countEnrollment()
        {
            return proj.students.Count() <= 100 ? true : false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
           try
            {
                if (countEnrollment())
                {
                    if (result)
                    {
                        // check if the student exists...
                        if (exStudent(txtMat.Text.Trim()) == 0)
                        {
                            // check if any field is empty...
                            if ((txtFname.Text != "") && (txtLname.Text != "") && (txtMat.Text != "") && cboDept.SelectedIndex != -1 && cboLevel.SelectedIndex != -1 && cboState.SelectedIndex != -1 && picPassport.Image != null)
                            {
                                fingerPrint = txtMat.Text.Trim();
                                string[] wordArray = fingerPrint.Split('/');
                                fingerPrint = String.Join("_", wordArray);

                                location = "C:\\fingerprints\\" + fingerPrint + ".fpt";

                                FileStream fs = File.Open(location, FileMode.Create, FileAccess.Write);

                                Template.Serialize(fs);
                                fs.Close();
                                student std = new student()
                                {
                                    firstname = txtFname.Text.Trim(),
                                    lastname = txtLname.Text.Trim(),
                                    matricno = txtMat.Text.Trim(),
                                    dept = cboDept.SelectedIndex,
                                    state = cboState.SelectedIndex,
                                    stlevel = cboLevel.SelectedIndex,
                                    passport = ConvertImageToBinary(picPassport.Image),
                                    created_at = System.DateTime.Now,
                                    created_by = Form1.userId

                                };
                                proj.students.Add(std);
                                proj.SaveChanges();

                                clearFields();

                                MessageBox.Show("Student enrolled successfully", "Enrollment Completed");
                            }
                            else
                            {
                                MessageBox.Show("No field must be empty!", "Error!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Record already exist!", "Error!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Finger prints capture has not been completed!", "Error:");
                    }
                }
                else
                {
                    MessageBox.Show("End of Trial period!", "Payment Time:");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error has occurred!", "Error:");
            }
            //save data to database ...
        }
        byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    filename = ofd.FileName;
                   // lblFileName.Text = filename;
                    picPassport.Image = Image.FromFile(filename);
                }
            }
        }

        private void Enrollment_Load(object sender, EventArgs e)
        {
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void clearFields()
        {
            txtMat.Clear();
            txtLname.Clear();
            txtFname.Clear();
            cboDept.SelectedIndex = -1;
            cboLevel.SelectedIndex = -1;
            cboState.SelectedIndex = -1;
            picPassport.Image = null;
            //Template = null;
            btnSave.Enabled = false;

        }
    }
}
