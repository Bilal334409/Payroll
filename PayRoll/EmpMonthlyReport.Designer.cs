namespace PayRoll
{
    partial class EmpMonthlyReport
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
            this.ViewdataGridView = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.MonthYear = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.MasterSearchTB);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(40, 25);
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
            // ViewdataGridView
            // 
            this.ViewdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ViewdataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewdataGridView.Location = new System.Drawing.Point(-8, 116);
            this.ViewdataGridView.Name = "ViewdataGridView";
            this.ViewdataGridView.Size = new System.Drawing.Size(1050, 447);
            this.ViewdataGridView.TabIndex = 229;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 20F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(860, 36);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 44);
            this.button3.TabIndex = 232;
            this.button3.Text = "Report";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MonthYear
            // 
            this.MonthYear.CustomFormat = "MMM/yyyy";
            this.MonthYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.MonthYear.Location = new System.Drawing.Point(567, 44);
            this.MonthYear.Name = "MonthYear";
            this.MonthYear.Size = new System.Drawing.Size(197, 26);
            this.MonthYear.TabIndex = 240;
            this.MonthYear.Value = new System.DateTime(2018, 6, 14, 0, 0, 0, 0);
            this.MonthYear.ValueChanged += new System.EventHandler(this.MonthYear_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1034, 160);
            this.dataGridView1.TabIndex = 241;
            this.dataGridView1.Visible = false;
            // 
            // EmpMonthlyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.MonthYear);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ViewdataGridView);
            this.Controls.Add(this.button3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmpMonthlyReport";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empoyee Monthly Report";
            this.Load += new System.EventHandler(this.EmpMonthlyReport_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox MasterSearchTB;
        private System.Windows.Forms.DataGridView ViewdataGridView;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker MonthYear;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}