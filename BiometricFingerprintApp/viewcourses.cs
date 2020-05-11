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
    public partial class viewcourses : Form
    {
        projdbEntities proj = new projdbEntities();
        
        public viewcourses()
        {
            InitializeComponent();
        }
        private void getNew()
        {
            try
            {
                var query = from nc in proj.studcourses
                            where nc.student_id == Verification.studentId && nc.level == Verification.studentLevel
                            select nc;
                if (query.Count() > 0)
                {
                    List<studcourse> course = query.ToList();

                   
                    foreach(var x in course)
                    {
                        dgvCourses.Rows.Add();

                        int rowCount = dgvCourses.Rows.Count - 1;

                        DataGridViewRow R = dgvCourses.Rows[rowCount];

                        R.Cells["Col1"].Value = getCode(x.course_id);
                        R.Cells["Col2"].Value = getTitle(x.course_id);
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
                            where nc.student_id == Verification.studentId && nc.stlevel == Verification.studentLevel
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
        private void viewcourses_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'courseregdataset.studcourse' table. You can move, or remove it, as needed.
           
            lstNew.Items.Clear();

            lstResit.Items.Clear();

            getNew();

            getResit();
        }
    }
}
