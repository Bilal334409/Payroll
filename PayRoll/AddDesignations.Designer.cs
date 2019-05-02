namespace PayRoll
{
    partial class AddDesignations
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
            this.designationtextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.DepartmentcomboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // designationtextBox
            // 
            this.designationtextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.designationtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.designationtextBox.Location = new System.Drawing.Point(182, 75);
            this.designationtextBox.MaxLength = 50;
            this.designationtextBox.Name = "designationtextBox";
            this.designationtextBox.Size = new System.Drawing.Size(218, 26);
            this.designationtextBox.TabIndex = 2;
            this.designationtextBox.TextChanged += new System.EventHandler(this.designationtextBox_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(34, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 21);
            this.label13.TabIndex = 127;
            this.label13.Text = "Designation:";
            // 
            // DepartmentcomboBox
            // 
            this.DepartmentcomboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.DepartmentcomboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.DepartmentcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartmentcomboBox.FormattingEnabled = true;
            this.DepartmentcomboBox.Location = new System.Drawing.Point(182, 24);
            this.DepartmentcomboBox.Name = "DepartmentcomboBox";
            this.DepartmentcomboBox.Size = new System.Drawing.Size(218, 28);
            this.DepartmentcomboBox.TabIndex = 0;
            this.DepartmentcomboBox.Text = "Select";
            this.DepartmentcomboBox.SelectedIndexChanged += new System.EventHandler(this.DepartmentcomboBox_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(34, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 21);
            this.label12.TabIndex = 129;
            this.label12.Text = "Department:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(120, 130);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 47);
            this.button3.TabIndex = 3;
            this.button3.Text = "Add Designation";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AddDesignations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PayRoll.Properties.Resources.admin_background_images_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(434, 201);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.DepartmentcomboBox);
            this.Controls.Add(this.designationtextBox);
            this.Controls.Add(this.label13);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddDesignations";
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Designations";
            this.Load += new System.EventHandler(this.AddDesignations_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox designationtextBox;
        internal System.Windows.Forms.Label label13;
        public System.Windows.Forms.ComboBox DepartmentcomboBox;
        internal System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button3;
    }
}