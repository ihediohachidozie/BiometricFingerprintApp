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
    public partial class resitcourses : Form
    {
        projdbEntities proj = new projdbEntities();
        int studid, semester, dept, level;
        bool result = false;


        public resitcourses()
        {
            InitializeComponent();
        }
        private void rdSecond_CheckedChanged(object sender, EventArgs e)
        {
            dgCourses.Rows.Clear();

            if (rdSecond.Checked)
            {
                if (txtMatric.Text != "")
                {
                    if (checkStudent())
                    {
                        semester = 1;
                        getCourses();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Matric Number!", "Error:");
                        lstCourses.Items.Clear();
                        rdSecond.Checked = false;
                    }
                }
                else
                {
                    MessageBox.Show("Enter the matric number!", "Error:");
                    lstCourses.Items.Clear();
                    rdSecond.Checked = false;
                }
            }
        }

        private void rdFirst_CheckedChanged(object sender, EventArgs e)
        {
            dgCourses.Rows.Clear();

            if (rdFirst.Checked)
            {
                if (txtMatric.Text != "")
                {
                    if (checkStudent())
                    {
                        semester = 0;
                        getCourses();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Matric Number!", "Error:");
                        lstCourses.Items.Clear();
                        rdFirst.Checked = false;
                    }
                }
                else
                {
                    MessageBox.Show("Enter the matric number!", "Error:");
                    lstCourses.Items.Clear();
                    rdFirst.Checked = false;
                }
            }
        }


        private void getCourses()
        {
            try
            {
                student stud = proj.students.FirstOrDefault(s => s.matricno == txtMatric.Text.Trim());

                studid = stud.id;
                level = stud.stlevel;
                dept = stud.dept;
                txtName.Text = (stud.firstname + " " + stud.lastname).ToUpper();
                cboDept.SelectedIndex = stud.dept;


                lstCourses.Items.Clear();

                var query = from c in proj.courses
                            where c.semester == semester && c.year < level && c.department == dept
                            select c;
                if (query.Count() > 0)
                {
                    List<cours> course = query.ToList();
                    course.ForEach(x => lstCourses.Items.Add(x.code + " : " + x.title.ToUpper()));
                }
                else
                    lstCourses.Items.Add("No course available..");
            }
            catch (Exception)
            {
                MessageBox.Show("Database error has occurred!", "Error:");

            }
        }

        private bool checkStudent()
        {
            try
            {
                if ((from s in proj.students where s.matricno == txtMatric.Text.Trim() select s).Count() == 1) result = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Database error has occurred!", "Error:");

            }

            return result;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addCourses();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resitcourses_Load(object sender, EventArgs e)
        {
            clear();
        }

        private void lstCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCourses.SelectedIndex != -1)
            {
                int id = lstCourses.SelectedItem.ToString().IndexOf(":");
                string cus_code = lstCourses.SelectedItem.ToString().Substring(0, id).Trim();

                cours cus = proj.courses.FirstOrDefault(c => c.code == cus_code);

                if (!checkAddCourses(cus.id))
                {
                    dgCourses.Rows.Add();

                    int rowCount = dgCourses.Rows.Count - 1;

                    DataGridViewRow R = dgCourses.Rows[rowCount];

                    R.Cells["Col1"].Value = cus.id;
                    R.Cells["Col2"].Value = cus.code;
                    R.Cells["Col3"].Value = cus.title.ToUpper();
                }
                else
                {
                    MessageBox.Show("Course selected already!", "Warning:");

                }


            }
        }

        private void clear()
        {
            lstCourses.Items.Clear();
            txtMatric.Clear();
            txtName.Clear();
            cboDept.SelectedIndex = -1;
            dgCourses.Rows.Clear();
            rdFirst.Checked = false;
            rdSecond.Checked = false;
        }

        private void addCourses()
        {
            try
            {

                if (dgCourses.Rows.Count > 0)
                {
                    foreach (DataGridViewRow x in dgCourses.Rows)
                    {
                        // add each course to courses table
                        int n = x.Index;

                        resit item = new resit()
                        {
                            student_id = studid,
                            course_id = int.Parse(dgCourses.Rows[n].Cells["Col1"].Value.ToString()),
                            stlevel = level,
                            user_id = Form1.userId,
                            created_at = System.DateTime.Now
                        };

                        proj.resits.Add(item);

                    }

                    proj.SaveChanges();

                    MessageBox.Show("Courses added successfully!", "Success:");

                    clear();
                }
                else
                    MessageBox.Show("No course to add!", "Warning:");

            }
            catch (Exception)
            {
                MessageBox.Show("Database error has occurred!", "Error:");
            }
        }

        private bool checkAddCourses(int c)
        {
            result = false;

            if (dgCourses.Rows.Count > 1)
            {
                foreach (DataGridViewRow x in dgCourses.Rows)
                {
                    int n = x.Index;
                    if (c == (int.Parse(dgCourses.Rows[n].Cells["Col1"].Value.ToString()))) result = true;

                }
            }
            return result;
        }

    }
}
