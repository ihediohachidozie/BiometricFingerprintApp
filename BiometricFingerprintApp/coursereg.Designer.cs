namespace BiometricFingerprintApp
{
    partial class coursereg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstCourses = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdSecond = new System.Windows.Forms.RadioButton();
            this.rdFirst = new System.Windows.Forms.RadioButton();
            this.txtMatric = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgCourses = new System.Windows.Forms.DataGridView();
            this.Col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cboDept = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lstCourses);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtMatric);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 398);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Available Courses";
            // 
            // lstCourses
            // 
            this.lstCourses.FormattingEnabled = true;
            this.lstCourses.ItemHeight = 16;
            this.lstCourses.Location = new System.Drawing.Point(9, 163);
            this.lstCourses.Name = "lstCourses";
            this.lstCourses.Size = new System.Drawing.Size(213, 212);
            this.lstCourses.TabIndex = 3;
            this.lstCourses.SelectedIndexChanged += new System.EventHandler(this.lstCourses_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdSecond);
            this.groupBox2.Controls.Add(this.rdFirst);
            this.groupBox2.Location = new System.Drawing.Point(9, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 62);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Semester";
            // 
            // rdSecond
            // 
            this.rdSecond.AutoSize = true;
            this.rdSecond.Location = new System.Drawing.Point(103, 25);
            this.rdSecond.Name = "rdSecond";
            this.rdSecond.Size = new System.Drawing.Size(73, 20);
            this.rdSecond.TabIndex = 1;
            this.rdSecond.TabStop = true;
            this.rdSecond.Text = "Second";
            this.rdSecond.UseVisualStyleBackColor = true;
            this.rdSecond.CheckedChanged += new System.EventHandler(this.rdSecond_CheckedChanged);
            // 
            // rdFirst
            // 
            this.rdFirst.AutoSize = true;
            this.rdFirst.Location = new System.Drawing.Point(20, 25);
            this.rdFirst.Name = "rdFirst";
            this.rdFirst.Size = new System.Drawing.Size(51, 20);
            this.rdFirst.TabIndex = 0;
            this.rdFirst.TabStop = true;
            this.rdFirst.Text = "First";
            this.rdFirst.UseVisualStyleBackColor = true;
            this.rdFirst.CheckedChanged += new System.EventHandler(this.rdFirst_CheckedChanged);
            // 
            // txtMatric
            // 
            this.txtMatric.Location = new System.Drawing.Point(9, 37);
            this.txtMatric.Name = "txtMatric";
            this.txtMatric.Size = new System.Drawing.Size(214, 22);
            this.txtMatric.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matric Number:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnClear);
            this.groupBox3.Controls.Add(this.btnClose);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.dgCourses);
            this.groupBox3.Controls.Add(this.txtName);
            this.groupBox3.Controls.Add(this.cboDept);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(251, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(472, 397);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(164, 325);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(133, 50);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(314, 325);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 50);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(14, 325);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 50);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgCourses
            // 
            this.dgCourses.AllowUserToAddRows = false;
            this.dgCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col1,
            this.Col2,
            this.Col3});
            this.dgCourses.Location = new System.Drawing.Point(14, 94);
            this.dgCourses.Name = "dgCourses";
            this.dgCourses.ReadOnly = true;
            this.dgCourses.Size = new System.Drawing.Size(433, 219);
            this.dgCourses.TabIndex = 12;
            // 
            // Col1
            // 
            this.Col1.HeaderText = "id";
            this.Col1.Name = "Col1";
            this.Col1.ReadOnly = true;
            this.Col1.Visible = false;
            // 
            // Col2
            // 
            this.Col2.HeaderText = "Code";
            this.Col2.Name = "Col2";
            this.Col2.ReadOnly = true;
            this.Col2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Col2.Width = 130;
            // 
            // Col3
            // 
            this.Col3.HeaderText = "Title";
            this.Col3.Name = "Col3";
            this.Col3.ReadOnly = true;
            this.Col3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Col3.Width = 260;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(108, 15);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(340, 22);
            this.txtName.TabIndex = 11;
            // 
            // cboDept
            // 
            this.cboDept.Enabled = false;
            this.cboDept.FormattingEnabled = true;
            this.cboDept.Items.AddRange(new object[] {
            "Accounting",
            "Adult Education",
            "Agricultural Economics and Extension",
            "Agricultural Science and Education",
            "Animal Science",
            "Applied Chemistry",
            "Applied Geophysics",
            "Biochemistry",
            "Botany",
            "Business Administration",
            "Business Education",
            "Business Management / Management Science",
            "Chemistry",
            "Computer Science",
            "Dentistry And Dental Surgery",
            "Dentistry and Dental Technology",
            "Economics",
            "Education and Biology",
            "Education and Chemistry",
            "Education and Economics",
            "Education and English Language",
            "Education and French",
            "Education and Geography",
            "Education and Geography / Physics",
            "Education and History",
            "Education and Mathematics",
            "Education and Physics",
            "Education and Political Science",
            "Education and Religious Studies",
            "Education and Social Science",
            "Education and Social Studies",
            "Education Arts",
            "Educational Administration and Planning",
            "Educational Foundation",
            "Electronics and Computer Technology",
            "Elementary Education",
            "English and Literary Studies",
            "Environmental Education",
            "Environmental Protection And Resources Management",
            "Fisheries",
            "Fisheries and Aquaculture",
            "Food Science and Technology",
            "Food Science and Technology",
            "Forestry And Wildlife Management",
            "French",
            "Genetics and Bio-Technology",
            "Geography and Environmental Management",
            "Geography and Environmental Science",
            "Geology",
            "Guidance and Counseling",
            "History and International Studies",
            "Home Economics and Education",
            "Human Anatomy",
            "Human Kinetics and Health Education",
            "Human Nutrition and Dietetics",
            "Human Physiology",
            "Law",
            "Library and Information Science",
            "Marketing",
            "Mathematics",
            "Mathematics / Statistics",
            "Medical Laboratory Technology / Science",
            "Medicine and Surgery",
            "Nursing / Nursing Science",
            "Philosophy",
            "Physical and Health Education",
            "Physics",
            "Policy and Administrative Studies",
            "Public Administration",
            "Public Health Technology",
            "Radiography",
            "Religious Studies",
            "Social Works",
            "Sociology",
            "Soil Science",
            "Special Education",
            "Statistics",
            "Technology and Vocational Education",
            "Theatre Arts",
            "Zoology",
            "Christian Religious Studies (CRS)",
            "Linguistics and Communication Studies",
            "Educational Technology"});
            this.cboDept.Location = new System.Drawing.Point(108, 50);
            this.cboDept.Margin = new System.Windows.Forms.Padding(4);
            this.cboDept.Name = "cboDept";
            this.cboDept.Size = new System.Drawing.Size(340, 24);
            this.cboDept.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Department:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Student Name:";
            // 
            // coursereg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 415);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "coursereg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Course Registration";
            this.Load += new System.EventHandler(this.coursereg_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCourses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstCourses;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdSecond;
        private System.Windows.Forms.RadioButton rdFirst;
        private System.Windows.Forms.TextBox txtMatric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboDept;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgCourses;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col3;
    }
}