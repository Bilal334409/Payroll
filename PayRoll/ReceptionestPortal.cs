using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayRoll
{
    public partial class ReceptionestPortal : Form
    {
        public ReceptionestPortal()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EmployeeEntryFormRec Entry = new EmployeeEntryFormRec();
            Entry.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EmployeeExitFormRec Exit = new EmployeeExitFormRec();
            Exit.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Log Out Your Account", "Yes Or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Res == DialogResult.Yes)
            {
                this.Hide();
                Login f1 = new Login();
                f1.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeAbsentFormRec Ab = new EmployeeAbsentFormRec();
            Ab.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
