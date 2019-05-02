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
    public partial class AdminPortal : Form
    {
        public AdminPortal()
        {
            InitializeComponent();
        }

        private void employeeTotalAllowanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeTotalAllowanceForm Etaf = new EmployeeTotalAllowanceForm();
            Etaf.ShowDialog();
        }

        private void employeeRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee_RegistrationForm ERF = new Employee_RegistrationForm();
            ERF.ShowDialog();
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

        private void button4_Click(object sender, EventArgs e)
        {
            SearchForm SF = new SearchForm();
            SF.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SalaryUpdateForm SUF = new SalaryUpdateForm();
            SUF.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Log Out Your Account" , "Yes Or No" , MessageBoxButtons.YesNo , MessageBoxIcon.Question);
            if (Res == DialogResult.Yes)
            {
                this.Hide();
                Login f1 = new Login();
                f1.Show();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            PaymentForm PF = new PaymentForm();
            PF.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AttendanceForm AF = new AttendanceForm("");
            AF.ShowDialog();
        }

        private void employeeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EmployeeForm EF = new EmployeeForm(1);
            EF.ShowDialog();
        }

        private void employeeTotalDeductionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeTotalDeductionForm ETDf = new EmployeeTotalDeductionForm();
            ETDf.ShowDialog();
        }

        private void auditTrailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuditTrailForm ATF = new AuditTrailForm();
            ATF.ShowDialog();
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

        private void addDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDepartment Ad = new AddDepartment();
            Ad.ShowDialog();
        }

        private void addDesignationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDesignations Ad = new AddDesignations();
            Ad.ShowDialog();
        }

        private void companyDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompanyDetailForm CDF = new CompanyDetailForm();
            CDF.ShowDialog();
        }

        private void companyTimingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addHollydaysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddHollyday Ah = new AddHollyday();
            Ah.ShowDialog();
        }

        private void hollydaysToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HollyDayReportForm Hr = new HollyDayReportForm();
            Hr.ShowDialog();
        }

        private void monthlyReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmpMonthlyReport Er = new EmpMonthlyReport();
            Er.ShowDialog();
        }
    }
}
