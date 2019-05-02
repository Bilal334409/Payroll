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
    public partial class AccountantPortal : Form
    {
        public AccountantPortal()
        {
            InitializeComponent();
        }

        private void employeeRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm SF = new SearchForm();
            SF.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AllowanceForm AF = new AllowanceForm();
            AF.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetectionForm Df = new DetectionForm();
            Df.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SalaryUpdateForm SUF = new SalaryUpdateForm();
            SUF.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PaymentForm PF = new PaymentForm();
            PF.ShowDialog();
        }

        private void attendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AttendanceForm AF = new AttendanceForm("");
            AF.ShowDialog();
        }

        private void employeeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EmployeeForm EF = new EmployeeForm();
            EF.ShowDialog();
        }

        private void employeeTotalAllowanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeTotalAllowanceForm Etaf = new EmployeeTotalAllowanceForm();
            Etaf.ShowDialog();
        }

        private void employeeTotalDeductionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeTotalDeductionForm ETDf = new EmployeeTotalDeductionForm();
            ETDf.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Log Out Your Account", "Yes Or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Res == DialogResult.Yes)
            {
                this.Hide();
                Login f1 = new Login();
                f1.Show();
            }
        }

        private void AccountantPortal_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void paymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaymentReport pr = new PaymentReport();
            pr.ShowDialog();
        }

        private void addHolydayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddHollyday Ah = new AddHollyday();
            Ah.ShowDialog();
        }

        private void hollydayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HollyDayReportForm Hr = new HollyDayReportForm();
            Hr.ShowDialog();
        }
    }
}
