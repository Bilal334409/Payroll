using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayRoll
{
    public partial class EmpReportForm : Form
    {
        DataTable GetData;
        String ReportPath;
        public EmpReportForm(DataTable GetData , String ReportPath)
        {
            InitializeComponent();
            this.GetData = GetData;
            this.ReportPath = ReportPath;
           
        }
        // @"Reports\EmpReport.rpt"
        private void EmpReportForm_Load(object sender, EventArgs e)
        {
           
            DataTable GetData2 = new DataTable();
            GetData2 = GetData;
            ShowReport(GetData2);
        }
        private void ShowReport(DataTable dtReportData)
        {
            crystalReportViewer1.SelectionMode = CrystalDecisions.Windows.Forms.SelectionMode.None;


            try
            {
                 ReportDocument rdoc = new ReportDocument();
            string reportPath = ReportPath;
            
            rdoc.Load(reportPath);
            rdoc.SetDataSource(dtReportData);
            crystalReportViewer1.ReportSource = rdoc;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
        }

       

    }
}
