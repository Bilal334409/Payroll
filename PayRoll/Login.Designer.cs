namespace PayRoll
{
    partial class Login
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
            this.AccountTypecomboBox = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Button();
            this.PassTB = new System.Windows.Forms.TextBox();
            this.UserNameTB = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AccountTypecomboBox
            // 
            this.AccountTypecomboBox.Font = new System.Drawing.Font("Microsoft YaHei Light", 15F, System.Drawing.FontStyle.Bold);
            this.AccountTypecomboBox.ForeColor = System.Drawing.Color.Black;
            this.AccountTypecomboBox.FormattingEnabled = true;
            this.AccountTypecomboBox.Items.AddRange(new object[] {
            "Admin",
            "Accountant",
            "Receptionist",
            "General Employee"});
            this.AccountTypecomboBox.Location = new System.Drawing.Point(-1, 182);
            this.AccountTypecomboBox.Name = "AccountTypecomboBox";
            this.AccountTypecomboBox.Size = new System.Drawing.Size(220, 35);
            this.AccountTypecomboBox.TabIndex = 3;
            this.AccountTypecomboBox.Text = "Account Type ";
            this.AccountTypecomboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel5.Location = new System.Drawing.Point(275, 113);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(435, 364);
            this.panel5.TabIndex = 112;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.panel3.Font = new System.Drawing.Font("Georgia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.panel3.Location = new System.Drawing.Point(540, 399);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(137, 47);
            this.panel3.TabIndex = 2;
            this.panel3.Text = "Sign In";
            this.panel3.UseVisualStyleBackColor = false;
            this.panel3.Click += new System.EventHandler(this.panel3_Click);
            // 
            // PassTB
            // 
            this.PassTB.BackColor = System.Drawing.Color.White;
            this.PassTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassTB.Location = new System.Drawing.Point(376, 337);
            this.PassTB.Name = "PassTB";
            this.PassTB.PasswordChar = '*';
            this.PassTB.Size = new System.Drawing.Size(246, 38);
            this.PassTB.TabIndex = 1;
            this.PassTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PassTB.TextChanged += new System.EventHandler(this.PassTB_TextChanged);
            // 
            // UserNameTB
            // 
            this.UserNameTB.BackColor = System.Drawing.Color.White;
            this.UserNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameTB.Location = new System.Drawing.Point(376, 276);
            this.UserNameTB.Name = "UserNameTB";
            this.UserNameTB.Size = new System.Drawing.Size(246, 38);
            this.UserNameTB.TabIndex = 0;
            this.UserNameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UserNameTB.TextChanged += new System.EventHandler(this.UserNameTB_TextChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox3.Image = global::PayRoll.Properties.Resources.Pass;
            this.pictureBox3.Location = new System.Drawing.Point(315, 337);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 38);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 119;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.Image = global::PayRoll.Properties.Resources.User;
            this.pictureBox2.Location = new System.Drawing.Point(315, 276);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(39, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 120;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei Light", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(316, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 27);
            this.label5.TabIndex = 117;
            this.label5.Text = "PayRoll Login Panel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Bell MT", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(307, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 37);
            this.label4.TabIndex = 118;
            this.label4.Text = "Login Here";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(987, 23);
            this.panel1.TabIndex = 158;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(967, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 160;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft YaHei Light", 15F, System.Drawing.FontStyle.Bold);
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "PayRoll",
            "Inventory"});
            this.comboBox1.Location = new System.Drawing.Point(-1, 113);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(220, 35);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "PayRoll";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::PayRoll.Properties.Resources.unnamed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 591);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.PassTB);
            this.Controls.Add(this.UserNameTB);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.AccountTypecomboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox AccountTypecomboBox;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button panel3;
        private System.Windows.Forms.TextBox PassTB;
        private System.Windows.Forms.TextBox UserNameTB;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;

    }
}

