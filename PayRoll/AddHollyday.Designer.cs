namespace PayRoll
{
    partial class AddHollyday
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
            this.button3 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.HollydaysTb = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.DaystextBox = new System.Windows.Forms.TextBox();
            this.MonthYear = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(120, 176);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 47);
            this.button3.TabIndex = 3;
            this.button3.Text = "Add Hollyday";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(34, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 21);
            this.label12.TabIndex = 134;
            this.label12.Text = "Days:";
            // 
            // HollydaysTb
            // 
            this.HollydaysTb.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HollydaysTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HollydaysTb.Location = new System.Drawing.Point(182, 75);
            this.HollydaysTb.MaxLength = 50;
            this.HollydaysTb.Name = "HollydaysTb";
            this.HollydaysTb.Size = new System.Drawing.Size(218, 26);
            this.HollydaysTb.TabIndex = 1;
            this.HollydaysTb.TextChanged += new System.EventHandler(this.designationtextBox_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(34, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 21);
            this.label13.TabIndex = 133;
            this.label13.Text = "Hollyday:";
            // 
            // DaystextBox
            // 
            this.DaystextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DaystextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DaystextBox.Location = new System.Drawing.Point(182, 24);
            this.DaystextBox.MaxLength = 2;
            this.DaystextBox.Name = "DaystextBox";
            this.DaystextBox.Size = new System.Drawing.Size(218, 26);
            this.DaystextBox.TabIndex = 0;
            this.DaystextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.DaystextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // MonthYear
            // 
            this.MonthYear.CustomFormat = "MMM/yyyy";
            this.MonthYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.MonthYear.Location = new System.Drawing.Point(182, 125);
            this.MonthYear.Name = "MonthYear";
            this.MonthYear.Size = new System.Drawing.Size(218, 26);
            this.MonthYear.TabIndex = 2;
            this.MonthYear.Value = new System.DateTime(2018, 6, 14, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(34, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 133;
            this.label1.Text = "Month:";
            // 
            // AddHollyday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PayRoll.Properties.Resources.admin_background_images_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(434, 240);
            this.Controls.Add(this.MonthYear);
            this.Controls.Add(this.DaystextBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.HollydaysTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddHollyday";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Hollyday";
            this.Load += new System.EventHandler(this.AddHollyday_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        internal System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox HollydaysTb;
        internal System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox DaystextBox;
        private System.Windows.Forms.DateTimePicker MonthYear;
        internal System.Windows.Forms.Label label1;
    }
}