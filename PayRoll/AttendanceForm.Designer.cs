namespace PayRoll
{
    partial class AttendanceForm
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
            this.IDTB = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Absencelabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Latelabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Presentlabel = new System.Windows.Forms.Label();
            this.ViewdataGridView = new System.Windows.Forms.DataGridView();
            this.StartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.halfDaylabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NoDaylabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.MonthYear = new System.Windows.Forms.DateTimePicker();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewdataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.IDTB);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(12, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 55);
            this.groupBox2.TabIndex = 216;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Employee ID";
            // 
            // IDTB
            // 
            this.IDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDTB.Location = new System.Drawing.Point(20, 17);
            this.IDTB.Name = "IDTB";
            this.IDTB.Size = new System.Drawing.Size(248, 30);
            this.IDTB.TabIndex = 0;
            this.IDTB.TextChanged += new System.EventHandler(this.IDTB_TextChanged);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(822, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 21);
            this.label1.TabIndex = 215;
            this.label1.Text = "Absence:";
            // 
            // Absencelabel
            // 
            this.Absencelabel.AutoSize = true;
            this.Absencelabel.BackColor = System.Drawing.Color.Transparent;
            this.Absencelabel.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Absencelabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Absencelabel.Location = new System.Drawing.Point(951, 4);
            this.Absencelabel.Name = "Absencelabel";
            this.Absencelabel.Size = new System.Drawing.Size(20, 21);
            this.Absencelabel.TabIndex = 215;
            this.Absencelabel.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(822, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 21);
            this.label3.TabIndex = 215;
            this.label3.Text = "Late:";
            // 
            // Latelabel
            // 
            this.Latelabel.AutoSize = true;
            this.Latelabel.BackColor = System.Drawing.Color.Transparent;
            this.Latelabel.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Latelabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Latelabel.Location = new System.Drawing.Point(951, 31);
            this.Latelabel.Name = "Latelabel";
            this.Latelabel.Size = new System.Drawing.Size(20, 21);
            this.Latelabel.TabIndex = 215;
            this.Latelabel.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(822, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 21);
            this.label7.TabIndex = 215;
            this.label7.Text = "Present:";
            // 
            // Presentlabel
            // 
            this.Presentlabel.AutoSize = true;
            this.Presentlabel.BackColor = System.Drawing.Color.Transparent;
            this.Presentlabel.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Presentlabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Presentlabel.Location = new System.Drawing.Point(951, 58);
            this.Presentlabel.Name = "Presentlabel";
            this.Presentlabel.Size = new System.Drawing.Size(20, 21);
            this.Presentlabel.TabIndex = 215;
            this.Presentlabel.Text = "0";
            // 
            // ViewdataGridView
            // 
            this.ViewdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ViewdataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewdataGridView.Location = new System.Drawing.Point(0, 138);
            this.ViewdataGridView.Name = "ViewdataGridView";
            this.ViewdataGridView.Size = new System.Drawing.Size(1035, 424);
            this.ViewdataGridView.TabIndex = 225;
            // 
            // StartTimePicker
            // 
            this.StartTimePicker.CustomFormat = "dd/MMM/yyyy";
            this.StartTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartTimePicker.Location = new System.Drawing.Point(26, 20);
            this.StartTimePicker.Name = "StartTimePicker";
            this.StartTimePicker.Size = new System.Drawing.Size(118, 23);
            this.StartTimePicker.TabIndex = 241;
            this.StartTimePicker.Value = new System.DateTime(2018, 6, 14, 0, 0, 0, 0);
            this.StartTimePicker.ValueChanged += new System.EventHandler(this.StartTimePicker_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(822, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 215;
            this.label2.Text = "Half Day:";
            // 
            // halfDaylabel
            // 
            this.halfDaylabel.AutoSize = true;
            this.halfDaylabel.BackColor = System.Drawing.Color.Transparent;
            this.halfDaylabel.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.halfDaylabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.halfDaylabel.Location = new System.Drawing.Point(951, 85);
            this.halfDaylabel.Name = "halfDaylabel";
            this.halfDaylabel.Size = new System.Drawing.Size(20, 21);
            this.halfDaylabel.TabIndex = 215;
            this.halfDaylabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(822, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 21);
            this.label4.TabIndex = 242;
            this.label4.Text = "No Day:";
            // 
            // NoDaylabel
            // 
            this.NoDaylabel.AutoSize = true;
            this.NoDaylabel.BackColor = System.Drawing.Color.Transparent;
            this.NoDaylabel.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoDaylabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NoDaylabel.Location = new System.Drawing.Point(951, 112);
            this.NoDaylabel.Name = "NoDaylabel";
            this.NoDaylabel.Size = new System.Drawing.Size(20, 21);
            this.NoDaylabel.TabIndex = 243;
            this.NoDaylabel.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(322, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 21);
            this.label6.TabIndex = 244;
            this.label6.Text = "Month:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EndTimePicker);
            this.groupBox1.Controls.Add(this.StartTimePicker);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(580, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 124);
            this.groupBox1.TabIndex = 248;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Record By Duration";
            // 
            // EndTimePicker
            // 
            this.EndTimePicker.CustomFormat = "dd/MMM/yyyy";
            this.EndTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndTimePicker.Location = new System.Drawing.Point(26, 81);
            this.EndTimePicker.Name = "EndTimePicker";
            this.EndTimePicker.Size = new System.Drawing.Size(118, 23);
            this.EndTimePicker.TabIndex = 241;
            this.EndTimePicker.Value = new System.DateTime(2018, 6, 14, 0, 0, 0, 0);
            this.EndTimePicker.ValueChanged += new System.EventHandler(this.MonthYear_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(66, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 20);
            this.label8.TabIndex = 245;
            this.label8.Text = "To:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 20F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(21, 81);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 44);
            this.button3.TabIndex = 260;
            this.button3.Text = "Report";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MonthYear
            // 
            this.MonthYear.CustomFormat = "MMM/yyyy";
            this.MonthYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.MonthYear.Location = new System.Drawing.Point(395, 56);
            this.MonthYear.Name = "MonthYear";
            this.MonthYear.Size = new System.Drawing.Size(141, 26);
            this.MonthYear.TabIndex = 261;
            this.MonthYear.Value = new System.DateTime(2018, 6, 14, 0, 0, 0, 0);
            this.MonthYear.ValueChanged += new System.EventHandler(this.MonthYear_ValueChanged_1);
            // 
            // AttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1034, 561);
            this.Controls.Add(this.MonthYear);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NoDaylabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ViewdataGridView);
            this.Controls.Add(this.halfDaylabel);
            this.Controls.Add(this.Presentlabel);
            this.Controls.Add(this.Latelabel);
            this.Controls.Add(this.Absencelabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AttendanceForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance Form";
            this.Load += new System.EventHandler(this.AttendanceForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewdataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox IDTB;
        private System.Windows.Forms.Label label16;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label Absencelabel;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label Latelabel;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label Presentlabel;
        private System.Windows.Forms.DataGridView ViewdataGridView;
        private System.Windows.Forms.DateTimePicker StartTimePicker;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label halfDaylabel;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label NoDaylabel;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker EndTimePicker;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker MonthYear;
    }
}