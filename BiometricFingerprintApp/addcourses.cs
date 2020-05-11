using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BiometricFingerprintApp
{
    public partial class addcourses : Form
    {
        projdbEntities proj = new projdbEntities();
        public addcourses()
        {
            InitializeComponent();
        }

        // human error of multiple entry of same course has not been handled yet...
        private void getCourses()
        {
            try
            {
                lstCourses.Items.Clear();

                var query = from c in proj.courses
                            select c;
                if (query.Count() > 0)
                {
                    List<cours> course = query.ToList();
                    course.ForEach(x => lstCourses.Items.Add(x.code + " : " + x.title.ToUpper()));
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Database error has occurred!", "Error:"); 

            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                dgCourses.Rows.Clear();
                btnUpdate.Enabled = false;
                btnAdd.Enabled = true;
                dgCourses.AllowUserToAddRows = true;

            }
            catch(Exception)
            {
                MessageBox.Show("This action is not required now", "Error");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (dgCourses.Rows.Count > 1)
                {
                    foreach (DataGridViewRow x in dgCourses.Rows)
                    {
                        DataGridViewComboBoxCell cboDept = (x.Cells["Col1"] as DataGridViewComboBoxCell);
                        DataGridViewComboBoxCell cboYear = (x.Cells["Col4"] as DataGridViewComboBoxCell);
                        DataGridViewComboBoxCell cboSemester = (x.Cells["Col5"] as DataGridViewComboBoxCell);

                        // add each course to courses table
                        int n = x.Index;
                        if (n != dgCourses.Rows.Count - 1)
                        {
                            cours item = new cours()
                            {
                                department = cboDept.Items.IndexOf(dgCourses.Rows[n].Cells["Col1"].Value), // department
                                code = dgCourses.Rows[n].Cells["Col2"].Value.ToString().ToUpper(), // course code
                                title = dgCourses.Rows[n].Cells["Col3"].Value.ToString(), // course title
                                year = cboYear.Items.IndexOf(dgCourses.Rows[n].Cells["Col4"].Value), // level
                                semester = cboSemester.Items.IndexOf(dgCourses.Rows[n].Cells["Col5"].Value) // semester
                            };

                            proj.courses.Add(item);
                        }

                    }
                    proj.SaveChanges();

                    MessageBox.Show("Courses added successfully!", "Success:");

                    dgCourses.Rows.Clear();
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Database error has occurred!", "Error:");
            }
            getCourses();
        }

        private void addcourses_Load(object sender, EventArgs e)
        {
            getCourses();
        }

        private void lstCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgCourses.AllowUserToAddRows = false;
            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;

            if(lstCourses.SelectedIndex != -1)
            {
                int id = lstCourses.SelectedIndex + 1;

                cours cus = proj.courses.FirstOrDefault(c => c.id == id);

                dgCourses.Rows.Add();

                int rowCount = dgCourses.Rows.Count - 1;

                DataGridViewRow R = dgCourses.Rows[rowCount];

                DataGridViewComboBoxCell cboDept = (R.Cells["Col1"] as DataGridViewComboBoxCell);
                DataGridViewComboBoxCell cboYear = (R.Cells["Col4"] as DataGridViewComboBoxCell);
                DataGridViewComboBoxCell cboSemester = (R.Cells["Col5"] as DataGridViewComboBoxCell);

                R.Cells["Col1"].Value = cboDept.Items[cus.department];
                R.Cells["Col2"].Value = cus.code;
                R.Cells["Col3"].Value = cus.title;
                R.Cells["Col4"].Value = cboYear.Items[cus.year];
                R.Cells["Col5"].Value = cboSemester.Items[cus.semester];
                R.Cells["Col6"].Value = cus.id;

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgCourses.Rows.Count > 1)
                {
                    foreach (DataGridViewRow x in dgCourses.Rows)
                    {
                        DataGridViewComboBoxCell cboDept = (x.Cells["Col1"] as DataGridViewComboBoxCell);
                        DataGridViewComboBoxCell cboYear = (x.Cells["Col4"] as DataGridViewComboBoxCell);
                        DataGridViewComboBoxCell cboSemester = (x.Cells["Col5"] as DataGridViewComboBoxCell);

                        // update each course to courses table
                        int n = x.Index;
                        
                        int id = int.Parse(dgCourses.Rows[n].Cells["Col6"].Value.ToString());

                        cours cus = proj.courses.FirstOrDefault(c => c.id == id);

                        cus.department = cboDept.Items.IndexOf(dgCourses.Rows[n].Cells["Col1"].Value); // department
                        cus.code = dgCourses.Rows[n].Cells["Col2"].Value.ToString(); // course code
                        cus.title = dgCourses.Rows[n].Cells["Col3"].Value.ToString(); // course title
                        cus.year = cboYear.Items.IndexOf(dgCourses.Rows[n].Cells["Col4"].Value); // level
                        cus.semester = cboSemester.Items.IndexOf(dgCourses.Rows[n].Cells["Col5"].Value); // semester

                    }
                    proj.SaveChanges();

                    MessageBox.Show("Courses updated successfully!", "Success:");

                    dgCourses.Rows.Clear();
                    getCourses();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error has occurred!", "Error:");
            }
        }
    }
}
