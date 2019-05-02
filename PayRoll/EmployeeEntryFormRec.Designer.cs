namespace PayRoll
{
    partial class EmployeeEntryFormRec
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.MasterSearchTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Emp_ID = new System.Windows.Forms.TextBox();
            this.ViewdataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MonthYear = new System.Windows.Forms.DateTimePicker();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.MasterSearchTB);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(231, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 55);
            this.groupBox2.TabIndex = 230;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(-47, 5);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 195;
            this.label16.Text = "label16";
            this.label16.Visible = false;
            // 
            // MasterSearchTB
            // 
            this.MasterSearchTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MasterSearchTB.Location = new System.Drawing.Point(12, 17);
            this.MasterSearchTB.Name = "MasterSearchTB";
            this.MasterSearchTB.Size = new System.Drawing.Size(422, 30);
            this.MasterSearchTB.TabIndex = 0;
            this.MasterSearchTB.TextChanged += new System.EventHandler(this.MasterSearchTB_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(10, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 21);
            this.label5.TabIndex = 231;
            this.label5.Text = "ID:";
            // 
            // Emp_ID
            // 
            this.Emp_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emp_ID.Location = new System.Drawing.Point(45, 41);
            this.Emp_ID.Name = "Emp_ID";
            this.Emp_ID.Size = new System.Drawing.Size(105, 30);
            this.Emp_ID.TabIndex = 228;
            this.Emp_ID.TextChanged += new System.EventHandler(this.Emp_ID_TextChanged);
            // 
            // ViewdataGridView
            // 
            this.ViewdataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.ViewdataGridView.Location = new System.Drawing.Point(1, 130);
            this.ViewdataGridView.Name = "ViewdataGridView";
            this.ViewdataGridView.Size = new System.Drawing.Size(1032, 430);
            this.ViewdataGridView.TabIndex = 232;
            this.ViewdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewdataGridView_CellClick);
            this.ViewdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewdataGridView_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Status";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Checked";
            this.Column2.Name = "Column2";
            // 
            // MonthYear
            // 
            this.MonthYear.CustomFormat = "dd/MMM/yyyy";
            this.MonthYear.Enabled = false;
            this.MonthYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.MonthYear.Location = new System.Drawing.Point(786, 43);
            this.MonthYear.Name = "MonthYear";
            this.MonthYear.Size = new System.Drawing.Size(197, 26);
            this.MonthYear.TabIndex = 240;
            this.MonthYear.Value = new System.DateTime(2018, 6, 14, 0, 0, 0, 0);
            // 
            // EmployeeEntryFormRec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 561);
            this.Controls.Add(this.MonthYear);
            this.Controls.Add(this.ViewdataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Emp_ID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmployeeEntryFormRec";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Entry";
            this.Load += new System.EventHandler(this.EmployeeEntryFormRec_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox MasterSearchTB;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Emp_ID;
        private System.Windows.Forms.DataGridView ViewdataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column2;
        private System.Windows.Forms.DateTimePicker MonthYear;
    }
}