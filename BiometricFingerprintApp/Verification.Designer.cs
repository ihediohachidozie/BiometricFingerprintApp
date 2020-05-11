namespace BiometricFingerprintApp
{
    partial class Verification
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
            this.label5 = new System.Windows.Forms.Label();
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.chkEdit = new System.Windows.Forms.CheckBox();
            this.cboLevel = new System.Windows.Forms.ComboBox();
            this.cboDept = new System.Windows.Forms.ComboBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtMatricN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.chkButton = new System.Windows.Forms.CheckBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.txtMatric = new System.Windows.Forms.TextBox();
            this.btnVerify = new System.Windows.Forms.Button();
            this.picPassport = new System.Windows.Forms.PictureBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.Col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPassport)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dgvCourses);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.chkEdit);
            this.groupBox1.Controls.Add(this.cboLevel);
            this.groupBox1.Controls.Add(this.cboDept);
            this.groupBox1.Controls.Add(this.txtLname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.picPassport);
            this.groupBox1.Controls.Add(this.txtFname);
            this.groupBox1.Controls.Add(this.txtMatricN);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(279, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(692, 485);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Registered Courses";
            // 
            // dgvCourses
            // 
            this.dgvCourses.AllowUserToAddRows = false;
            this.dgvCourses.AllowUserToDeleteRows = false;
            this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col1,
            this.Col2,
            this.Col3});
            this.dgvCourses.Location = new System.Drawing.Point(119, 219);
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.ReadOnly = true;
            this.dgvCourses.RowHeadersVisible = false;
            this.dgvCourses.Size = new System.Drawing.Size(566, 250);
            this.dgvCourses.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(522, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Click on passport to replace";
            // 
            // chkEdit
            // 
            this.chkEdit.AutoSize = true;
            this.chkEdit.Enabled = false;
            this.chkEdit.Location = new System.Drawing.Point(119, 167);
            this.chkEdit.Name = "chkEdit";
            this.chkEdit.Size = new System.Drawing.Size(98, 20);
            this.chkEdit.TabIndex = 23;
            this.chkEdit.Text = "Edit Record";
            this.chkEdit.UseVisualStyleBackColor = true;
            this.chkEdit.CheckedChanged += new System.EventHandler(this.chkEdit_CheckedChanged);
            // 
            // cboLevel
            // 
            this.cboLevel.Enabled = false;
            this.cboLevel.FormattingEnabled = true;
            this.cboLevel.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800"});
            this.cboLevel.Location = new System.Drawing.Point(119, 133);
            this.cboLevel.Margin = new System.Windows.Forms.Padding(4);
            this.cboLevel.Name = "cboLevel";
            this.cboLevel.Size = new System.Drawing.Size(184, 24);
            this.cboLevel.TabIndex = 21;
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
            this.cboDept.Location = new System.Drawing.Point(119, 108);
            this.cboDept.Margin = new System.Windows.Forms.Padding(4);
            this.cboDept.Name = "cboDept";
            this.cboDept.Size = new System.Drawing.Size(354, 24);
            this.cboDept.TabIndex = 20;
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(119, 85);
            this.txtLname.Name = "txtLname";
            this.txtLname.ReadOnly = true;
            this.txtLname.Size = new System.Drawing.Size(184, 22);
            this.txtLname.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Last Name:";
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(119, 62);
            this.txtFname.Name = "txtFname";
            this.txtFname.ReadOnly = true;
            this.txtFname.Size = new System.Drawing.Size(184, 22);
            this.txtFname.TabIndex = 13;
            // 
            // txtMatricN
            // 
            this.txtMatricN.Location = new System.Drawing.Point(119, 39);
            this.txtMatricN.Name = "txtMatricN";
            this.txtMatricN.ReadOnly = true;
            this.txtMatricN.Size = new System.Drawing.Size(184, 22);
            this.txtMatricN.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 139);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Level:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 114);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Department:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matric Number:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPrint);
            this.groupBox2.Controls.Add(this.btnClose);
            this.groupBox2.Controls.Add(this.btnModify);
            this.groupBox2.Controls.Add(this.chkButton);
            this.groupBox2.Controls.Add(this.btnDisplay);
            this.groupBox2.Controls.Add(this.txtMatric);
            this.groupBox2.Controls.Add(this.btnVerify);
            this.groupBox2.Location = new System.Drawing.Point(11, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(253, 485);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Matric Number";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(25, 374);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(205, 44);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnModify
            // 
            this.btnModify.Enabled = false;
            this.btnModify.Location = new System.Drawing.Point(25, 254);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(205, 44);
            this.btnModify.TabIndex = 5;
            this.btnModify.Text = "Modify Data";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // chkButton
            // 
            this.chkButton.AutoSize = true;
            this.chkButton.Location = new System.Drawing.Point(20, 89);
            this.chkButton.Name = "chkButton";
            this.chkButton.Size = new System.Drawing.Size(179, 20);
            this.chkButton.TabIndex = 1;
            this.chkButton.Text = "Enable Verification Button";
            this.chkButton.UseVisualStyleBackColor = true;
            this.chkButton.CheckedChanged += new System.EventHandler(this.chkButton_CheckedChanged);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Enabled = false;
            this.btnDisplay.Location = new System.Drawing.Point(25, 194);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(205, 44);
            this.btnDisplay.TabIndex = 3;
            this.btnDisplay.Text = "Display Data";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // txtMatric
            // 
            this.txtMatric.Location = new System.Drawing.Point(20, 44);
            this.txtMatric.Name = "txtMatric";
            this.txtMatric.Size = new System.Drawing.Size(210, 22);
            this.txtMatric.TabIndex = 0;
            // 
            // btnVerify
            // 
            this.btnVerify.Enabled = false;
            this.btnVerify.Location = new System.Drawing.Point(25, 134);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(205, 44);
            this.btnVerify.TabIndex = 2;
            this.btnVerify.Text = "Verify Fingerprint";
            this.btnVerify.UseVisualStyleBackColor = true;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // picPassport
            // 
            this.picPassport.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picPassport.Enabled = false;
            this.picPassport.Location = new System.Drawing.Point(513, 28);
            this.picPassport.Name = "picPassport";
            this.picPassport.Size = new System.Drawing.Size(151, 133);
            this.picPassport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPassport.TabIndex = 17;
            this.picPassport.TabStop = false;
            this.picPassport.Click += new System.EventHandler(this.picPassport_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(25, 314);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(205, 44);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "Preview Card";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // Col1
            // 
            this.Col1.HeaderText = "Code";
            this.Col1.Name = "Col1";
            this.Col1.ReadOnly = true;
            this.Col1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Col2
            // 
            this.Col2.HeaderText = "Title";
            this.Col2.Name = "Col2";
            this.Col2.ReadOnly = true;
            this.Col2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Col2.Width = 320;
            // 
            // Col3
            // 
            this.Col3.HeaderText = "Remark";
            this.Col3.Name = "Col3";
            this.Col3.ReadOnly = true;
            this.Col3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Col3.Width = 140;
            // 
            // Verification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 502);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Verification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Verification Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPassport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMatric;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtMatricN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox chkButton;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picPassport;
        private System.Windows.Forms.ComboBox cboLevel;
        private System.Windows.Forms.ComboBox cboDept;
        private System.Windows.Forms.CheckBox chkEdit;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvCourses;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col3;
    }
}