namespace PayRoll
{
    partial class EmployeeTotalDeductionForm
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
            this.MonthcomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Emp_ID = new System.Windows.Forms.TextBox();
            this.yearcomboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ViewdataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewdataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.MasterSearchTB);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(191, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 55);
            this.groupBox2.TabIndex = 241;
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
            this.MasterSearchTB.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MasterSearchTB_KeyUp);
            // 
            // MonthcomboBox
            // 
            this.MonthcomboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.MonthcomboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.MonthcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthcomboBox.FormattingEnabled = true;
            this.MonthcomboBox.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.MonthcomboBox.Location = new System.Drawing.Point(324, 112);
            this.MonthcomboBox.Name = "MonthcomboBox";
            this.MonthcomboBox.Size = new System.Drawing.Size(125, 28);
            this.MonthcomboBox.TabIndex = 240;
            this.MonthcomboBox.SelectedIndexChanged += new System.EventHandler(this.MonthcomboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(251, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 239;
            this.label1.Text = "Month:";
            // 
            // Emp_ID
            // 
            this.Emp_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emp_ID.Location = new System.Drawing.Point(100, 110);
            this.Emp_ID.Name = "Emp_ID";
            this.Emp_ID.Size = new System.Drawing.Size(120, 30);
            this.Emp_ID.TabIndex = 238;
            this.Emp_ID.TextChanged += new System.EventHandler(this.Emp_ID_TextChanged);
            // 
            // yearcomboBox
            // 
            this.yearcomboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.yearcomboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.yearcomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearcomboBox.FormattingEnabled = true;
            this.yearcomboBox.Items.AddRange(new object[] {
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035",
            "2036",
            "2037",
            "2038",
            "2039",
            "2040",
            "2041",
            "2042",
            "2043",
            "2044",
            "2045",
            "2046",
            "2047",
            "2048",
            "2049",
            "2050",
            "2051",
            "2052",
            "2053",
            "2054",
            "2055",
            "2056",
            "2057",
            "2058",
            "2059",
            "2060",
            "2061",
            "2062",
            "2063",
            "2064",
            "2065",
            "2066",
            "2067",
            "2068",
            "2069",
            "2070",
            "2071",
            "2072",
            "2073",
            "2074",
            "2075",
            "2076",
            "2077",
            "2078",
            "2079",
            "2080",
            "2081",
            "2082",
            "2083",
            "2084",
            "2085",
            "2086",
            "2087",
            "2088",
            "2089",
            "2090",
            "2091",
            "2092",
            "2093",
            "2094",
            "2095",
            "2096",
            "2097",
            "2098",
            "2099",
            "2100"});
            this.yearcomboBox.Location = new System.Drawing.Point(547, 113);
            this.yearcomboBox.Name = "yearcomboBox";
            this.yearcomboBox.Size = new System.Drawing.Size(125, 28);
            this.yearcomboBox.TabIndex = 237;
            this.yearcomboBox.SelectedIndexChanged += new System.EventHandler(this.yearcomboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(474, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 21);
            this.label5.TabIndex = 236;
            this.label5.Text = "Year:";
            // 
            // ViewdataGridView
            // 
            this.ViewdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ViewdataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewdataGridView.Location = new System.Drawing.Point(-8, 167);
            this.ViewdataGridView.Name = "ViewdataGridView";
            this.ViewdataGridView.Size = new System.Drawing.Size(1050, 395);
            this.ViewdataGridView.TabIndex = 235;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(38, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 21);
            this.label2.TabIndex = 242;
            this.label2.Text = "ID:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 20F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(874, 20);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 44);
            this.button3.TabIndex = 243;
            this.button3.Text = "Report";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            this.button1.TabIndex = 244;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.EndTimePicker);
            this.groupBox1.Controls.Add(this.StartTimePicker);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(692, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 124);
            this.groupBox1.TabIndex = 250;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(874, 81);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(147, 62);
            this.groupBox3.TabIndex = 258;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Total  Allowance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(15, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 21);
            this.label3.TabIndex = 253;
            this.label3.Text = "Rs: ";
            // 
            // EmployeeTotalDeductionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1034, 561);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.MonthcomboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Emp_ID);
            this.Controls.Add(this.yearcomboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ViewdataGridView);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmployeeTotalDeductionForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Total Deduction";
            this.Load += new System.EventHandler(this.EmployeeTotalDeductionForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewdataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox MasterSearchTB;
        private System.Windows.Forms.ComboBox MonthcomboBox;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Emp_ID;
        private System.Windows.Forms.ComboBox yearcomboBox;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView ViewdataGridView;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker EndTimePicker;
        private System.Windows.Forms.DateTimePicker StartTimePicker;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        internal System.Windows.Forms.Label label3;
    }
}