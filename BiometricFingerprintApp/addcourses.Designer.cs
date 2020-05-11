namespace BiometricFingerprintApp
{
    partial class addcourses
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgCourses = new System.Windows.Forms.DataGridView();
            this.Col1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Col5 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Col6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstCourses = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCourses)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.dgCourses);
            this.groupBox1.Location = new System.Drawing.Point(289, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(925, 403);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editor";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(776, 337);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 50);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(525, 337);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(133, 50);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(260, 334);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(133, 50);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 334);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 50);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgCourses
            // 
            this.dgCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col1,
            this.Col2,
            this.Col3,
            this.Col4,
            this.Col5,
            this.Col6});
            this.dgCourses.Location = new System.Drawing.Point(16, 31);
            this.dgCourses.Name = "dgCourses";
            this.dgCourses.Size = new System.Drawing.Size(893, 291);
            this.dgCourses.TabIndex = 0;
            // 
            // Col1
            // 
            this.Col1.HeaderText = "Department";
            this.Col1.Items.AddRange(new object[] {
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
            this.Col1.Name = "Col1";
            this.Col1.Width = 360;
            // 
            // Col2
            // 
            this.Col2.HeaderText = "Code";
            this.Col2.Name = "Col2";
            this.Col2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Col3
            // 
            this.Col3.HeaderText = "Title";
            this.Col3.Name = "Col3";
            this.Col3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Col3.Width = 190;
            // 
            // Col4
            // 
            this.Col4.HeaderText = "Level";
            this.Col4.Items.AddRange(new object[] {
            "100",
            "200",
            "300",
            "400",
            "500",
            "600",
            "700",
            "800"});
            this.Col4.Name = "Col4";
            this.Col4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Col5
            // 
            this.Col5.HeaderText = "Semester";
            this.Col5.Items.AddRange(new object[] {
            "First",
            "Second"});
            this.Col5.Name = "Col5";
            this.Col5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Col6
            // 
            this.Col6.HeaderText = "id";
            this.Col6.Name = "Col6";
            this.Col6.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstCourses);
            this.groupBox2.Location = new System.Drawing.Point(12, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 403);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List";
            // 
            // lstCourses
            // 
            this.lstCourses.FormattingEnabled = true;
            this.lstCourses.ItemHeight = 16;
            this.lstCourses.Location = new System.Drawing.Point(17, 31);
            this.lstCourses.Name = "lstCourses";
            this.lstCourses.Size = new System.Drawing.Size(231, 356);
            this.lstCourses.TabIndex = 0;
            this.lstCourses.SelectedIndexChanged += new System.EventHandler(this.lstCourses_SelectedIndexChanged);
            // 
            // addcourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 425);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "addcourses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Courses";
            this.Load += new System.EventHandler(this.addcourses_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCourses)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgCourses;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstCourses;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewComboBoxColumn Col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col3;
        private System.Windows.Forms.DataGridViewComboBoxColumn Col4;
        private System.Windows.Forms.DataGridViewComboBoxColumn Col5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col6;
    }
}