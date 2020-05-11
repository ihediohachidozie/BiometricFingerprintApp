namespace BiometricFingerprintApp
{
    partial class viewcourses
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
            this.lstNew = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstResit = new System.Windows.Forms.ListBox();
            this.dgvCourses = new System.Windows.Forms.DataGridView();
            this.Col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCourses);
            this.groupBox1.Controls.Add(this.lstNew);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 402);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New";
            // 
            // lstNew
            // 
            this.lstNew.FormattingEnabled = true;
            this.lstNew.ItemHeight = 16;
            this.lstNew.Location = new System.Drawing.Point(14, 46);
            this.lstNew.Name = "lstNew";
            this.lstNew.Size = new System.Drawing.Size(295, 36);
            this.lstNew.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstResit);
            this.groupBox2.Location = new System.Drawing.Point(356, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(342, 401);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resit";
            // 
            // lstResit
            // 
            this.lstResit.FormattingEnabled = true;
            this.lstResit.ItemHeight = 16;
            this.lstResit.Location = new System.Drawing.Point(26, 46);
            this.lstResit.Name = "lstResit";
            this.lstResit.Size = new System.Drawing.Size(295, 324);
            this.lstResit.TabIndex = 1;
            // 
            // dgvCourses
            // 
            this.dgvCourses.AllowUserToAddRows = false;
            this.dgvCourses.AllowUserToDeleteRows = false;
            this.dgvCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col1,
            this.Col2});
            this.dgvCourses.Location = new System.Drawing.Point(14, 134);
            this.dgvCourses.Name = "dgvCourses";
            this.dgvCourses.ReadOnly = true;
            this.dgvCourses.RowHeadersVisible = false;
            this.dgvCourses.Size = new System.Drawing.Size(294, 211);
            this.dgvCourses.TabIndex = 1;
            // 
            // Col1
            // 
            this.Col1.HeaderText = "Code";
            this.Col1.Name = "Col1";
            this.Col1.ReadOnly = true;
            this.Col1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Col1.Width = 85;
            // 
            // Col2
            // 
            this.Col2.HeaderText = "Title";
            this.Col2.Name = "Col2";
            this.Col2.ReadOnly = true;
            this.Col2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Col2.Width = 205;
            // 
            // viewcourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 415);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "viewcourses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Courses";
            this.Load += new System.EventHandler(this.viewcourses_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCourses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstNew;
        private System.Windows.Forms.ListBox lstResit;
        private System.Windows.Forms.DataGridView dgvCourses;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col2;
    }
}