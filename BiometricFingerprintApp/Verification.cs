using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiometricFingerprintApp
{
    delegate void Function();	// a simple delegate for marshalling calls from event handlers to the GUI thread
    public partial class Verification : Form
    {
        string location, fingerPrint, filename;
        projdbEntities proj = new projdbEntities();
        public static int userId = new int();
        public static int studentId = new int();
        public static int studentLevel = new int();
        public static bool confirm = new bool();
        public Verification()
        {
            InitializeComponent();
        }
        private void OnTemplate(DPFP.Template template)
        {
            this.Invoke(new Function(delegate ()
            {
                Template = template;

                if (Template != null)
                {
                    btnVerify.Enabled = true;
                    MessageBox.Show("The fingerprint template is ready for Verification.", "Fingerprint Enrollment");
                }
                else
                    MessageBox.Show("The fingerprint template is not valid. Repeat fingerprint enrollment.", "Fingerprint Enrollment");
            }));
        }

        private DPFP.Template Template;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkButton_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtMatric.Text != "")
                {
                    fingerPrint = txtMatric.Text.Trim();
                    string[] wordArray = fingerPrint.Split('/');
                    fingerPrint = String.Join("_", wordArray);

                    location = "C:\\fingerprints\\" + fingerPrint + ".fpt";

                    if (File.Exists(location) == true)
                    {
                        FileStream fs = File.OpenRead(location);

                        DPFP.Template template = new DPFP.Template(fs);
                        OnTemplate(template);
                    }
                    else
                    {
                        MessageBox.Show("Matriculation Number does not exist!");
                        chkButton.Checked = false;
                    }
                }
                else
                {
                    MessageBox.Show("Matric Number is empty!", "Error");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error has occurred!", "Error");
            }
            
        }
        Image ConvertBinaryToImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }
        }
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            try
            {
               // confirm = true;
                if (confirm)
                {
                    student stud = proj.students.FirstOrDefault(s => s.matricno == txtMatric.Text);
                    //Product product = ctx.Products.FirstOrDefault(p => p.ModelNo == modelno);
                    txtLname.Text = stud.lastname;
                    cboLevel.SelectedIndex = stud.stlevel;
                    txtFname.Text = stud.firstname;
                    txtMatricN.Text = stud.matricno;
                    picPassport.Image = ConvertBinaryToImage(stud.passport);
                    cboDept.SelectedIndex = stud.dept;


                    studentId = stud.id;
                    studentLevel = stud.stlevel;

                    chkEdit.Enabled = true;

                    getNew();
                    getResit();
                    btnPrint.Enabled = true;
                }
                else
                {
                    MessageBox.Show("The fingerprint NOT VERIFIED.", "Warning:");
                    btnDisplay.Enabled = false;

                }

            }
            catch(Exception)
            {
                MessageBox.Show("An Error has occurred!", "Error");
            }


        }

        private void chkEdit_CheckedChanged(object sender, EventArgs e)
        {
            if(chkEdit.Checked)
            {
                txtFname.ReadOnly = false;
                txtLname.ReadOnly = false;
                txtMatricN.ReadOnly = false;

            
                picPassport.Enabled = true;
                cboLevel.Enabled = true;
                cboDept.Enabled = true;
               
                btnModify.Enabled = true;
 
            }
            else
            {
                txtFname.ReadOnly = true;
                txtLname.ReadOnly = true;
                txtMatricN.ReadOnly = true; 
               
                picPassport.Enabled = false;
             
                cboLevel.Enabled = false;
                cboDept.Enabled = false;
                btnModify.Enabled = false;
            }

        }

        private void picPassport_Click(object sender, EventArgs e)
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
        byte[] ConvertImageToBinary(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        private int exStudent(string x)
        {
            int stud = proj.students.Count(i => i.matricno == x);
            return stud;
        }
        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                if (exStudent(txtMatric.Text.Trim()) == 1)
                {
                    if ((txtFname.Text != "") && (txtLname.Text != "") && (txtMatricN.Text != "") && cboDept.SelectedIndex != -1 && cboLevel.SelectedIndex != -1 && picPassport.Image != null)
                    {
                        student stud = proj.students.FirstOrDefault(s => s.matricno == txtMatric.Text);
                        stud.lastname = txtLname.Text.Trim();
                        stud.stlevel = cboLevel.SelectedIndex;
                        stud.firstname = txtFname.Text.Trim();
                        stud.matricno = txtMatricN.Text.Trim();
                        if (filename != null)
                        {
                            stud.passport = ConvertImageToBinary(picPassport.Image);
                        }

                        stud.dept = cboDept.SelectedIndex;
                        
                        stud.modified_at = System.DateTime.Now;
                        stud.modified_by = Form1.userId;

                        proj.SaveChanges();

                        MessageBox.Show("Student modified successfully", "Enrollment Completed");
                        saveFingerprint();

                        clearFields();
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
            catch(Exception)
            {
                MessageBox.Show("An Error has occurred!", "Error:");
            }
 

        }
        private void clearFields()
        {
            txtMatricN.Clear();
            txtMatric.Clear();
            txtLname.Clear();
            txtFname.Clear();
            cboDept.SelectedIndex = -1;
            cboLevel.SelectedIndex = -1;
          
            picPassport.Image = null;
            //Template = null;
            btnDisplay.Enabled = false;
            btnModify.Enabled = false;
            chkEdit.Enabled = false;

        }

        private void saveFingerprint()
        {
            try
            {
                if (txtMatric.Text != txtMatricN.Text)
                {
                    fingerPrint = txtMatricN.Text.Trim();
                    string[] wordArray = fingerPrint.Split('/');
                    fingerPrint = String.Join("_", wordArray);

                    location = "C:\\fingerprints\\" + fingerPrint + ".fpt";

                    FileStream fs = File.Open(location, FileMode.Create, FileAccess.Write);
                    //File.Delete(location);

                    Template.Serialize(fs);
                    fs.Close();
                    deleteFingerprint();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error has occurred!", "Error:");
            }

        }

        private void deleteFingerprint()
        {
            try
            {

                fingerPrint = txtMatric.Text.Trim();
                string[] wordArray = fingerPrint.Split('/');
                fingerPrint = String.Join("_", wordArray);

                location = "C:\\fingerprints\\" + fingerPrint + ".fpt";

                File.Delete(location);
            }
            catch (Exception)
            {
                MessageBox.Show("An Error has occurred!", "Error");
            }
        }
        private void btnVerify_Click(object sender, EventArgs e)
        {
            FingerVerify Verifier = new FingerVerify(Template);

            Verifier.ShowDialog();
            btnDisplay.Enabled = true;
            
        }

        private void getNew()
        {
            try
            {
                var query = from nc in proj.studcourses
                            where nc.student_id == studentId && nc.level == studentLevel
                            select nc;
                if (query.Count() > 0)
                {
                    List<studcourse> course = query.ToList();


                    foreach (var x in course)
                    {
                        dgvCourses.Rows.Add();

                        int rowCount = dgvCourses.Rows.Count - 1;

                        DataGridViewRow R = dgvCourses.Rows[rowCount];

                        R.Cells["Col1"].Value = getCode(x.course_id);
                        R.Cells["Col2"].Value = getTitle(x.course_id);
                        R.Cells["Col3"].Value = "New";
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error has occurred!", "Error:");
            }
        }

        private void getResit()
        {
            try
            {
                var query = from nc in proj.resits
                            where nc.student_id == studentId && nc.stlevel == studentLevel
                            select nc;
                if (query.Count() > 0)
                {
                    List<resit> course = query.ToList();

                    foreach (var x in course)
                    {
                        dgvCourses.Rows.Add();

                        int rowCount = dgvCourses.Rows.Count - 1;

                        DataGridViewRow R = dgvCourses.Rows[rowCount];

                        R.Cells["Col1"].Value = getCode(x.course_id);
                        R.Cells["Col2"].Value = getTitle(x.course_id);
                        R.Cells["Col3"].Value = "Resit";
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("An Error has occurred!", "Error:");
            }
        }

        private string getCode(int x)
        {
            return proj.courses.FirstOrDefault(c => c.id == x).code;
        }
        private string getTitle(int x)
        {
            return proj.courses.FirstOrDefault(c => c.id == x).title;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printCard();
        }

        private void printCard()
        {
            PrintDialog printDialog = new PrintDialog();

            PrintDocument printDocument = new PrintDocument();

            printDialog.Document = printDocument; //add the document to the dialog box...        

            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage); //add an event handler that will do the printing

            //on a till you will not want to ask the user where to print but this is fine for the test envoironment.

            //Open the print preview dialog
            PrintPreviewDialog objPPdialog = new PrintPreviewDialog();
            objPPdialog.Document = printDocument;
            objPPdialog.ShowDialog();
        }
        void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            string terms = "I have understood all the regulations and its amendments in regard to examinations.@I found myself Eligible to appear in Examination. In case University declare me ineligible @due to any wrong information submitted in examination form by me, I shall be responsible @for the consequences at any stage.";
            terms = terms.Replace("@", "\n");
            try
            {
                //this prints the reciept
                
                //Font text = new Font("Courier New", 22, FontStyle.Bold);

                Graphics graphic = e.Graphics;
                Graphics surface = this.CreateGraphics();

                SolidBrush black = new SolidBrush(Color.Black);

                Font font = new Font("Arial", 12); //must use a mono spaced font as the spaces need to line up
                Font fontBold = new Font("Arial", 12, FontStyle.Bold);
                Font tnc = new Font("Arial", 12, FontStyle.Italic);
                Font title = new Font("Arial", 30, FontStyle.Bold);
                Font subtitle = new Font("Arial", 16);
                
                Pen pen = new Pen(Color.Black, 2.0f);
            
                

                // logo to print
                Point loc = new Point(600, 120);
                graphic.DrawImage(picPassport.Image, 600, 120, 151, 133);


                float fontHeight = font.GetHeight();

                int offset = 40;
                int x = 1;
                int y = 300;
           


                graphic.DrawString("UNVERSITY OF CALABAR", title, black, 150, 20);
                //graphic.DrawLine(new Pen(Color.Black, 2.0f), 140, 70, 700, 70); // horizontal line
                graphic.DrawString("STUDENT'S EXAMINATION CARD", subtitle , black, 250, 40 + offset);

                // table for exam card header...
                graphic.DrawLine(pen, 100, 120, 750, 120); // horizontal line
                graphic.DrawLine(pen, 100, 120, 100, 200); // vertical line start
                graphic.DrawLine(pen, 750, 120, 750, 250); // vertical line end
                graphic.DrawLine(pen, 600, 250, 750, 250); // horizontal line
                graphic.DrawLine(pen, 250, 120, 250, 200); // vertical inner line start
                graphic.DrawLine(pen, 600, 120, 600, 250); // vertical inner line end

                graphic.DrawString("Reg Number", font, black, 105, 80 + offset);
                graphic.DrawString(txtMatric.Text, font, black, 255, 80 + offset);
                graphic.DrawLine(pen, 100, 140, 600, 140); // horizontal line

                graphic.DrawString("Full Name", font, black, 105, 100 + offset);
                graphic.DrawString(txtFname.Text + " " + txtLname.Text, font, black, 255, 100 + offset);
                graphic.DrawLine(pen, 100, 160, 600, 160); // horizontal line  

                graphic.DrawString("Department", font, black, 105, 120 + offset);
                graphic.DrawString(cboDept.Text, font, black, 255, 120 + offset);
                graphic.DrawLine(pen, 100, 180, 600, 180); // horizontal line

                graphic.DrawString("Year", font, black, 105, 140 + offset);
                graphic.DrawString(cboLevel.Text, font, black, 255, 140 + offset);
                graphic.DrawLine(pen, 100, 200, 600, 200); // horizontal line 

                // graphic.DrawImage(picPassport.Image, loc);

                // table for registered courses...
                graphic.DrawString("REGISTERED COURSES", font, black, 300, 220 + offset);
                graphic.DrawLine(pen, 100, 280, 750, 280); // horizontal line 
                graphic.DrawString("S/N", fontBold, black, 105, 240 + offset);
                graphic.DrawString("CODE", fontBold, black, 195, 240 + offset);
                graphic.DrawString("TITLE", fontBold, black, 350, 240 + offset);
                graphic.DrawString("REMARK", fontBold, black, 650, 240 + offset);
                graphic.DrawLine(pen, 100, 300, 750, 300); // horizontal line 
                                                                                  // graphic.DrawLine(new Pen(Color.Black, 2.0f), 150, 280, 150, 500); // vertical line start


                if(dgvCourses.RowCount > 0)
                {
                    foreach (DataGridViewRow item in dgvCourses.Rows)
                    {
                        int n = item.Index;
                        string val1 = dgvCourses.Rows[n].Cells["Col1"].Value.ToString().ToUpper();
                        string val2 = dgvCourses.Rows[n].Cells["Col2"].Value.ToString().ToUpper();
                        string val3 = dgvCourses.Rows[n].Cells["Col3"].Value.ToString().ToUpper();

                        graphic.DrawString((x + n).ToString(), new Font("Arial", 12), black, 107, y);
                        graphic.DrawString(val1, font, black, 185, y);
                        graphic.DrawString(val2, font, black, 300, y);
                        graphic.DrawString(val3, font, black, 670, y);

                        offset = offset + (int)fontHeight + 5; //make the spacing consistent
                        y = y + (int)fontHeight + 5;
                    }
                }



                graphic.DrawLine(pen, 100, y, 750, y); // horizontal line 

                graphic.DrawString(terms, tnc, black, 100, y + 10);

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error");
            }

        }
    }
}
