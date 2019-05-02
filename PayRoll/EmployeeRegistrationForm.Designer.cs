namespace PayRoll
{
    partial class Employee_RegistrationForm
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
            this.designationtextBox = new System.Windows.Forms.ComboBox();
            this.DepartmentTextBoc = new System.Windows.Forms.ComboBox();
            this.StatuscomboBox = new System.Windows.Forms.ComboBox();
            this.GenderTB = new System.Windows.Forms.ComboBox();
            this.DateOfHired = new System.Windows.Forms.DateTimePicker();
            this.DateOfBirthTB = new System.Windows.Forms.DateTimePicker();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ProfilePicture = new System.Windows.Forms.PictureBox();
            this.Address = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.PasswordTb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.AddLine2tb = new System.Windows.Forms.TextBox();
            this.HouseNOtextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.postCodetextBox = new System.Windows.Forms.TextBox();
            this.AddLine1Tb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.JobTitletextBox = new System.Windows.Forms.TextBox();
            this.NICtextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BasicSalarytextBox = new System.Windows.Forms.TextBox();
            this.ContacttextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.LastNametextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.FirstNameTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            this.Address.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.designationtextBox);
            this.groupBox1.Controls.Add(this.DepartmentTextBoc);
            this.groupBox1.Controls.Add(this.StatuscomboBox);
            this.groupBox1.Controls.Add(this.GenderTB);
            this.groupBox1.Controls.Add(this.DateOfHired);
            this.groupBox1.Controls.Add(this.DateOfBirthTB);
            this.groupBox1.Controls.Add(this.BrowseButton);
            this.groupBox1.Controls.Add(this.ClearBtn);
            this.groupBox1.Controls.Add(this.AddBtn);
            this.groupBox1.Controls.Add(this.ProfilePicture);
            this.groupBox1.Controls.Add(this.Address);
            this.groupBox1.Controls.Add(this.JobTitletextBox);
            this.groupBox1.Controls.Add(this.NICtextBox);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.BasicSalarytextBox);
            this.groupBox1.Controls.Add(this.ContacttextBox);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.LastNametextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.FirstNameTB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(6, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1022, 552);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // designationtextBox
            // 
            this.designationtextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.designationtextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.designationtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.designationtextBox.FormattingEnabled = true;
            this.designationtextBox.Location = new System.Drawing.Point(546, 72);
            this.designationtextBox.Name = "designationtextBox";
            this.designationtextBox.Size = new System.Drawing.Size(218, 28);
            this.designationtextBox.TabIndex = 7;
            this.designationtextBox.Text = "Select";
            this.designationtextBox.SelectedIndexChanged += new System.EventHandler(this.designationtextBox_SelectedIndexChanged);
            // 
            // DepartmentTextBoc
            // 
            this.DepartmentTextBoc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.DepartmentTextBoc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.DepartmentTextBoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartmentTextBoc.FormattingEnabled = true;
            this.DepartmentTextBoc.Location = new System.Drawing.Point(546, 29);
            this.DepartmentTextBoc.Name = "DepartmentTextBoc";
            this.DepartmentTextBoc.Size = new System.Drawing.Size(218, 28);
            this.DepartmentTextBoc.TabIndex = 6;
            this.DepartmentTextBoc.Text = "Select";
            this.DepartmentTextBoc.SelectedIndexChanged += new System.EventHandler(this.DepartmentTextBoc_SelectedIndexChanged_1);
            this.DepartmentTextBoc.SelectedValueChanged += new System.EventHandler(this.DepartmentTextBoc_SelectedIndexChanged);
            // 
            // StatuscomboBox
            // 
            this.StatuscomboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.StatuscomboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.StatuscomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatuscomboBox.FormattingEnabled = true;
            this.StatuscomboBox.Items.AddRange(new object[] {
            "Active",
            "Fired",
            "On Hold"});
            this.StatuscomboBox.Location = new System.Drawing.Point(546, 114);
            this.StatuscomboBox.Name = "StatuscomboBox";
            this.StatuscomboBox.Size = new System.Drawing.Size(218, 28);
            this.StatuscomboBox.TabIndex = 8;
            this.StatuscomboBox.Text = "Select";
            this.StatuscomboBox.SelectedIndexChanged += new System.EventHandler(this.StatuscomboBox_SelectedIndexChanged);
            // 
            // GenderTB
            // 
            this.GenderTB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.GenderTB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.GenderTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenderTB.FormattingEnabled = true;
            this.GenderTB.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderTB.Location = new System.Drawing.Point(160, 160);
            this.GenderTB.Name = "GenderTB";
            this.GenderTB.Size = new System.Drawing.Size(218, 28);
            this.GenderTB.TabIndex = 3;
            this.GenderTB.Text = "Select";
            this.GenderTB.SelectedIndexChanged += new System.EventHandler(this.GenderTB_SelectedIndexChanged);
            // 
            // DateOfHired
            // 
            this.DateOfHired.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOfHired.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateOfHired.Location = new System.Drawing.Point(546, 158);
            this.DateOfHired.Name = "DateOfHired";
            this.DateOfHired.Size = new System.Drawing.Size(218, 26);
            this.DateOfHired.TabIndex = 9;
            this.DateOfHired.ValueChanged += new System.EventHandler(this.DateOfHired_ValueChanged);
            // 
            // DateOfBirthTB
            // 
            this.DateOfBirthTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOfBirthTB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateOfBirthTB.Location = new System.Drawing.Point(160, 114);
            this.DateOfBirthTB.Name = "DateOfBirthTB";
            this.DateOfBirthTB.Size = new System.Drawing.Size(218, 26);
            this.DateOfBirthTB.TabIndex = 2;
            this.DateOfBirthTB.ValueChanged += new System.EventHandler(this.DateOfBirthTB_ValueChanged);
            // 
            // BrowseButton
            // 
            this.BrowseButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BrowseButton.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 20F, System.Drawing.FontStyle.Bold);
            this.BrowseButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BrowseButton.Location = new System.Drawing.Point(797, 234);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(200, 54);
            this.BrowseButton.TabIndex = 17;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = false;
            this.BrowseButton.Click += new System.EventHandler(this.imageToolStripMenuItem_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 20F, System.Drawing.FontStyle.Bold);
            this.ClearBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClearBtn.Location = new System.Drawing.Point(778, 370);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(212, 54);
            this.ClearBtn.TabIndex = 19;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AddBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddBtn.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 20F, System.Drawing.FontStyle.Bold);
            this.AddBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddBtn.Location = new System.Drawing.Point(534, 370);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(212, 54);
            this.AddBtn.TabIndex = 18;
            this.AddBtn.Text = "Add Record";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ProfilePicture
            // 
            this.ProfilePicture.BackColor = System.Drawing.SystemColors.Control;
            this.ProfilePicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ProfilePicture.Image = global::PayRoll.Properties.Resources.User1;
            this.ProfilePicture.Location = new System.Drawing.Point(797, 32);
            this.ProfilePicture.Name = "ProfilePicture";
            this.ProfilePicture.Size = new System.Drawing.Size(200, 179);
            this.ProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProfilePicture.TabIndex = 133;
            this.ProfilePicture.TabStop = false;
            // 
            // Address
            // 
            this.Address.Controls.Add(this.checkBox1);
            this.Address.Controls.Add(this.PasswordTb);
            this.Address.Controls.Add(this.label10);
            this.Address.Controls.Add(this.label9);
            this.Address.Controls.Add(this.label11);
            this.Address.Controls.Add(this.AddLine2tb);
            this.Address.Controls.Add(this.HouseNOtextBox);
            this.Address.Controls.Add(this.label8);
            this.Address.Controls.Add(this.postCodetextBox);
            this.Address.Controls.Add(this.AddLine1Tb);
            this.Address.Controls.Add(this.label7);
            this.Address.Location = new System.Drawing.Point(4, 286);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(460, 266);
            this.Address.TabIndex = 126;
            this.Address.TabStop = false;
            this.Address.Text = "Address";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Location = new System.Drawing.Point(12, 230);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(102, 17);
            this.checkBox1.TabIndex = 141;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // PasswordTb
            // 
            this.PasswordTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTb.Location = new System.Drawing.Point(156, 187);
            this.PasswordTb.Name = "PasswordTb";
            this.PasswordTb.Size = new System.Drawing.Size(282, 26);
            this.PasswordTb.TabIndex = 16;
            this.PasswordTb.TextChanged += new System.EventHandler(this.PasswordTb_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(8, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 21);
            this.label10.TabIndex = 125;
            this.label10.Text = "Apt/House No:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(8, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 21);
            this.label9.TabIndex = 125;
            this.label9.Text = "Password:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(8, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 21);
            this.label11.TabIndex = 125;
            this.label11.Text = "Post Code:";
            // 
            // AddLine2tb
            // 
            this.AddLine2tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLine2tb.Location = new System.Drawing.Point(156, 102);
            this.AddLine2tb.Name = "AddLine2tb";
            this.AddLine2tb.Size = new System.Drawing.Size(282, 26);
            this.AddLine2tb.TabIndex = 14;
            this.AddLine2tb.TextChanged += new System.EventHandler(this.AddLine2tb_TextChanged);
            // 
            // HouseNOtextBox
            // 
            this.HouseNOtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HouseNOtextBox.Location = new System.Drawing.Point(156, 24);
            this.HouseNOtextBox.Name = "HouseNOtextBox";
            this.HouseNOtextBox.Size = new System.Drawing.Size(150, 26);
            this.HouseNOtextBox.TabIndex = 12;
            this.HouseNOtextBox.TextChanged += new System.EventHandler(this.HouseNOtextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(8, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 21);
            this.label8.TabIndex = 125;
            this.label8.Text = "Address line 2:";
            // 
            // postCodetextBox
            // 
            this.postCodetextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postCodetextBox.Location = new System.Drawing.Point(156, 145);
            this.postCodetextBox.Name = "postCodetextBox";
            this.postCodetextBox.Size = new System.Drawing.Size(150, 26);
            this.postCodetextBox.TabIndex = 15;
            this.postCodetextBox.TextChanged += new System.EventHandler(this.postCodetextBox_TextChanged);
            this.postCodetextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BasicSalarytextBox_KeyPress);
            // 
            // AddLine1Tb
            // 
            this.AddLine1Tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLine1Tb.Location = new System.Drawing.Point(156, 62);
            this.AddLine1Tb.Name = "AddLine1Tb";
            this.AddLine1Tb.Size = new System.Drawing.Size(282, 26);
            this.AddLine1Tb.TabIndex = 13;
            this.AddLine1Tb.TextChanged += new System.EventHandler(this.AddLine1Tb_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(8, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 21);
            this.label7.TabIndex = 125;
            this.label7.Text = "Address line 1:";
            // 
            // JobTitletextBox
            // 
            this.JobTitletextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobTitletextBox.Location = new System.Drawing.Point(546, 253);
            this.JobTitletextBox.MaxLength = 50;
            this.JobTitletextBox.Name = "JobTitletextBox";
            this.JobTitletextBox.Size = new System.Drawing.Size(218, 26);
            this.JobTitletextBox.TabIndex = 11;
            this.JobTitletextBox.TextChanged += new System.EventHandler(this.JobTitletextBox_TextChanged);
            this.JobTitletextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JobTitletextBox_KeyPress);
            // 
            // NICtextBox
            // 
            this.NICtextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NICtextBox.Location = new System.Drawing.Point(160, 253);
            this.NICtextBox.MaxLength = 15;
            this.NICtextBox.Name = "NICtextBox";
            this.NICtextBox.Size = new System.Drawing.Size(218, 26);
            this.NICtextBox.TabIndex = 5;
            this.NICtextBox.TextChanged += new System.EventHandler(this.NICtextBox_TextChanged);
            this.NICtextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NICtextBox_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(398, 256);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 21);
            this.label17.TabIndex = 125;
            this.label17.Text = "Job Title:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(12, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 21);
            this.label6.TabIndex = 125;
            this.label6.Text = "NIC:";
            // 
            // BasicSalarytextBox
            // 
            this.BasicSalarytextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BasicSalarytextBox.Location = new System.Drawing.Point(546, 210);
            this.BasicSalarytextBox.MaxLength = 7;
            this.BasicSalarytextBox.Name = "BasicSalarytextBox";
            this.BasicSalarytextBox.Size = new System.Drawing.Size(218, 26);
            this.BasicSalarytextBox.TabIndex = 10;
            this.BasicSalarytextBox.TextChanged += new System.EventHandler(this.BasicSalarytextBox_TextChanged);
            this.BasicSalarytextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BasicSalarytextBox_KeyPress);
            // 
            // ContacttextBox
            // 
            this.ContacttextBox.AcceptsReturn = true;
            this.ContacttextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContacttextBox.Location = new System.Drawing.Point(160, 210);
            this.ContacttextBox.MaxLength = 12;
            this.ContacttextBox.Name = "ContacttextBox";
            this.ContacttextBox.Size = new System.Drawing.Size(218, 26);
            this.ContacttextBox.TabIndex = 4;
            this.ContacttextBox.Text = "03";
            this.ContacttextBox.TextChanged += new System.EventHandler(this.ContacttextBox_TextChanged);
            this.ContacttextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ContacttextBox_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(398, 213);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(114, 21);
            this.label16.TabIndex = 125;
            this.label16.Text = "Basic Salary:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(12, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 21);
            this.label5.TabIndex = 125;
            this.label5.Text = "Contact:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(398, 165);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(129, 21);
            this.label15.TabIndex = 125;
            this.label15.Text = "Date of Hired:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(12, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 125;
            this.label3.Text = "Gender:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(398, 122);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 21);
            this.label14.TabIndex = 125;
            this.label14.Text = "Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 21);
            this.label2.TabIndex = 125;
            this.label2.Text = "Date Of Birth:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(398, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 21);
            this.label13.TabIndex = 125;
            this.label13.Text = "Designation:";
            // 
            // LastNametextBox
            // 
            this.LastNametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNametextBox.Location = new System.Drawing.Point(160, 75);
            this.LastNametextBox.MaxLength = 20;
            this.LastNametextBox.Name = "LastNametextBox";
            this.LastNametextBox.Size = new System.Drawing.Size(218, 26);
            this.LastNametextBox.TabIndex = 1;
            this.LastNametextBox.TextChanged += new System.EventHandler(this.LastNametextBox_TextChanged);
            this.LastNametextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LastNametextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 125;
            this.label1.Text = "last Name:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(398, 32);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 21);
            this.label12.TabIndex = 125;
            this.label12.Text = "Department:";
            // 
            // FirstNameTB
            // 
            this.FirstNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameTB.Location = new System.Drawing.Point(160, 29);
            this.FirstNameTB.MaxLength = 20;
            this.FirstNameTB.Name = "FirstNameTB";
            this.FirstNameTB.Size = new System.Drawing.Size(218, 26);
            this.FirstNameTB.TabIndex = 0;
            this.FirstNameTB.TextChanged += new System.EventHandler(this.FirstNameTB_TextChanged);
            this.FirstNameTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FirstNameTB_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(12, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 21);
            this.label4.TabIndex = 125;
            this.label4.Text = "First Name:";
            // 
            // Employee_RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PayRoll.Properties.Resources.admin_background_images_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1034, 564);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Employee_RegistrationForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Registration Form";
            this.Load += new System.EventHandler(this.Employee_RegistrationForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).EndInit();
            this.Address.ResumeLayout(false);
            this.Address.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox FirstNameTB;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox Address;
        public System.Windows.Forms.TextBox PasswordTb;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox AddLine2tb;
        public System.Windows.Forms.TextBox HouseNOtextBox;
        internal System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox postCodetextBox;
        public System.Windows.Forms.TextBox AddLine1Tb;
        internal System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox NICtextBox;
        internal System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox ContacttextBox;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox LastNametextBox;
        internal System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox JobTitletextBox;
        internal System.Windows.Forms.Label label17;
        public System.Windows.Forms.TextBox BasicSalarytextBox;
        internal System.Windows.Forms.Label label16;
        internal System.Windows.Forms.Label label15;
        internal System.Windows.Forms.Label label14;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox ProfilePicture;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button ClearBtn;
        public System.Windows.Forms.DateTimePicker DateOfBirthTB;
        public System.Windows.Forms.ComboBox GenderTB;
        public System.Windows.Forms.DateTimePicker DateOfHired;
        public System.Windows.Forms.ComboBox StatuscomboBox;
        private System.Windows.Forms.Button BrowseButton;
        public System.Windows.Forms.ComboBox DepartmentTextBoc;
        public System.Windows.Forms.ComboBox designationtextBox;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}