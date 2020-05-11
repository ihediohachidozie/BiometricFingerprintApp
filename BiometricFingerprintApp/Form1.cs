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
    //delegate void Function();	// a simple delegate for marshalling calls from event handlers to the GUI thread
    public partial class Form1 : Form
    {
        projdbEntities proj = new projdbEntities();
        public static int userId = new int();
        public static TextBox fullname = new TextBox();
        public static bool status = new bool();
        public static bool active = new bool();

        login lg = new login();
        changePw pwCh = new changePw();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Enrollment Enroller = new Enrollment();
            //Enroller.OnTemplate += this.OnTemplate;
            Enroller.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Verification verf = new Verification();
            verf.ShowDialog();
        }

        private void enrollmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Enrollment Enroller = new Enrollment();
            //Enroller.OnTemplate += this.OnTemplate;
            Enroller.ShowDialog();
        }

        private void verificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Verification verf = new Verification();
            verf.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userForm usr = new userForm();
            usr.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lg.ShowDialog();
            // check if login user staff id is 1.
            if (status != true)
            {
                MessageBox.Show("Kindly change your password!", "Security Warning");
                pwCh.ShowDialog();
            }

            if (userId == 1)
            {
                usersToolStripMenuItem.Enabled = true;
                coursesToolStripMenuItem1.Enabled = true;
            }

            if (active)
            {
                enrollmentToolStripMenuItem.Enabled = true;
                verificationToolStripMenuItem.Enabled = true;
                addCoursesToolStripMenuItem.Enabled = true;
                resitCourseToolStripMenuItem.Enabled = true;
            }

            string machineName = System.Environment.MachineName;
            toolStripStatusLabel1.Text = "Computer Name:  " + machineName + "  |  ";
            toolStripStatusLabel2.Text = "Developer:  ";
            toolStripStatusLabel3.Text = "De Royce Solutions  | +234 (0) 806 770 9490 |";
            toolStripStatusLabel4.Text = "Logged in User:  " + fullname.Text.ToUpper() + "  |  " + DateTime.Now + "  |  ";


        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changePWD pw = new changePWD();
            pw.ShowDialog();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            coursereg cusr = new coursereg();
            cusr.ShowDialog();
        }

        private void coursesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            addcourses adc = new addcourses();
            adc.ShowDialog();
        }

        private void resitCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resitcourses rescur = new resitcourses();
            rescur.ShowDialog();
        }
    }
}
