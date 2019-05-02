namespace PayRoll
{
    partial class EmployeeForm
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
            this.ViewdataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.MasterSearchTB = new System.Windows.Forms.TextBox();
            this.Emp_ID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ViewdataGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ViewdataGridView
            // 
            this.ViewdataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ViewdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewdataGridView.Location = new System.Drawing.Point(-8, 117);
            this.ViewdataGridView.Name = "ViewdataGridView";
            this.ViewdataGridView.Size = new System.Drawing.Size(1050, 447);
            this.ViewdataGridView.TabIndex = 224;
            this.ViewdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewdataGridView_CellContentClick);
            this.ViewdataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ViewdataGridView_CellMouseDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.MasterSearchTB);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(294, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 55);
            this.groupBox2.TabIndex = 225;
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
            this.MasterSearchTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Emp_ID
            // 
            this.Emp_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emp_ID.Location = new System.Drawing.Point(45, 43);
            this.Emp_ID.Name = "Emp_ID";
            this.Emp_ID.Size = new System.Drawing.Size(105, 30);
            this.Emp_ID.TabIndex = 0;
            this.Emp_ID.TextChanged += new System.EventHandler(this.IDTB_TextChanged);
            this.Emp_ID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.IDTB_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(10, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 21);
            this.label5.TabIndex = 226;
            this.label5.Text = "ID:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft JhengHei UI Light", 20F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(860, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 44);
            this.button3.TabIndex = 227;
            this.button3.Text = "Report";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PayRoll.Properties.Resources.admin_background_images_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1034, 561);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Emp_ID);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ViewdataGridView);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmployeeForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Form";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewdataGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ViewdataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox MasterSearchTB;
        private System.Windows.Forms.TextBox Emp_ID;
        internal System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
    }
}