namespace PayRoll
{
    partial class AuditTrailForm
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
            this.TitleCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Emp_ID = new System.Windows.Forms.TextBox();
            this.ViewdataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewdataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.MasterSearchTB);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(208, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 55);
            this.groupBox2.TabIndex = 256;
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
            // TitleCB
            // 
            this.TitleCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TitleCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.TitleCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleCB.FormattingEnabled = true;
            this.TitleCB.Items.AddRange(new object[] {
            "Employee Details",
            "Company Details"});
            this.TitleCB.Location = new System.Drawing.Point(371, 116);
            this.TitleCB.Name = "TitleCB";
            this.TitleCB.Size = new System.Drawing.Size(179, 28);
            this.TitleCB.TabIndex = 255;
            this.TitleCB.SelectedIndexChanged += new System.EventHandler(this.TitleCB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(298, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 21);
            this.label1.TabIndex = 254;
            this.label1.Text = "Title:";
            // 
            // Emp_ID
            // 
            this.Emp_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emp_ID.Location = new System.Drawing.Point(84, 114);
            this.Emp_ID.Name = "Emp_ID";
            this.Emp_ID.Size = new System.Drawing.Size(85, 30);
            this.Emp_ID.TabIndex = 253;
            this.Emp_ID.TextChanged += new System.EventHandler(this.Emp_ID_TextChanged);
            this.Emp_ID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Emp_ID_KeyUp);
            // 
            // ViewdataGridView
            // 
            this.ViewdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ViewdataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewdataGridView.Location = new System.Drawing.Point(-8, 167);
            this.ViewdataGridView.Name = "ViewdataGridView";
            this.ViewdataGridView.Size = new System.Drawing.Size(1050, 395);
            this.ViewdataGridView.TabIndex = 250;
            this.ViewdataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ViewdataGridView_CellMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.EndTimePicker);
            this.groupBox1.Controls.Add(this.StartTimePicker);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(686, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 124);
            this.groupBox1.TabIndex = 260;
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
            this.EndTimePicker.ValueChanged += new System.EventHandler(this.EndTimePicker_ValueChanged);
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 20F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(21, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 44);
            this.button1.TabIndex = 258;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 20F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(873, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 44);
            this.button3.TabIndex = 259;
            this.button3.Text = "Report";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(36, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 21);
            this.label2.TabIndex = 257;
            this.label2.Text = "ID:";
            // 
            // AuditTrailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PayRoll.Properties.Resources.admin_background_images_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1034, 561);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.TitleCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Emp_ID);
            this.Controls.Add(this.ViewdataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AuditTrailForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Audit Trail";
            this.Load += new System.EventHandler(this.AuditTrailForm_Load);
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
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox MasterSearchTB;
        private System.Windows.Forms.ComboBox TitleCB;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Emp_ID;
        private System.Windows.Forms.DataGridView ViewdataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker EndTimePicker;
        private System.Windows.Forms.DateTimePicker StartTimePicker;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        internal System.Windows.Forms.Label label2;

    }
}