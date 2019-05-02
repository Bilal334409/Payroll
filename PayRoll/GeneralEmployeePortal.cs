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
    public partial class GeneralEmployeePortal : Form
    {

        string EmployeeID = "";
        public GeneralEmployeePortal(String EmployeeID)
        {
            InitializeComponent();
            this.EmployeeID = EmployeeID;

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

        private void button3_Click(object sender, EventArgs e)
        {
            EmployeeProfileForm Profile = new EmployeeProfileForm(EmployeeID);
            Profile.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AttendanceForm AF = new AttendanceForm(EmployeeID);
            AF.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GeneralEmployeePortal_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EntryExitBySelf EE = new EntryExitBySelf(EmployeeID);
            EE.ShowDialog();
        }
    }
}
