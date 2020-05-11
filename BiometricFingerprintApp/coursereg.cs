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
    public partial class coursereg : Form
    {
        projdbEntities proj = new projdbEntities();
        int studid, semester, dept, level, counter;
        bool result = false;
        string[] rejectedCourses;
        string msg;
        public coursereg()
        {
            InitializeComponent();
        }

        private void rdFirst_CheckedChanged(object sender, EventArgs e)
        {
            dgCourses.Rows.Clear();

            if (rdFirst.Checked)
            {
                if(txtMatric.Text != "")
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

        private void coursereg_Load(object sender, EventArgs e)
        {
            clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
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
                            where c.semester == semester && c.year == level && c.department == dept
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
                counter = 0;

                rejectedCourses = new string[dgCourses.Rows.Count];

                if (dgCourses.Rows.Count > 0)
                {
                    foreach (DataGridViewRow x in dgCourses.Rows)
                    {
                        // add each course to courses table
                        int n = x.Index;

                        if (checkCourse(int.Parse(dgCourses.Rows[n].Cells["Col1"].Value.ToString())))
                        {
                            studcourse item = new studcourse()
                            {
                                student_id = studid,
                                course_id = int.Parse(dgCourses.Rows[n].Cells["Col1"].Value.ToString()),
                                level = level,
                                user_id = Form1.userId,
                                created_at = System.DateTime.Now
                            };

                            proj.studcourses.Add(item);

                        }
                        else
                        {
                            rejectedCourses[counter] = dgCourses.Rows[n].Cells["Col2"].Value.ToString().Trim();
                            counter++;
                        }
                    }

                    proj.SaveChanges();

                    if(counter == 0)
                    {
                        MessageBox.Show("Courses added successfully!", "Success:");
                    }
                    else
                    {
                        for (int i = 0; i < rejectedCourses.Length; i++) msg = msg + rejectedCourses[i] +", ";
                   
                        MessageBox.Show("The following course already exits " + msg + ". Use carry over form to register them if required!");
                    }

                    clear();
                }

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
        private bool checkCourse(int cid)
        {
            result = false;
            if((from c in proj.studcourses where c.course_id == cid && c.student_id == studid select c).Count() == 0) result = true;
            return result;
        }
    }
}
