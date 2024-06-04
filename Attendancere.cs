using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBG20FinalProject
{
    public partial class Attendancere : Form
    {
        public Attendancere()
        {
            InitializeComponent();
        }

        private void CrystalReport21_InitReport(object sender, EventArgs e)
        {

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void Attendancere_Load(object sender, EventArgs e)
        {
            LoadCrystalReport();
        }
        private void LoadCrystalReport()
        {
            try
            {
                // Load your Crystal Report file
                ReportDocument reportDocument = new ReportDocument();
                reportDocument.Load("Crystal_Attendance.rpt"); // Replace "YourReportFilePath.rpt" with the actual path of your Crystal Report file

                // Set database connection information if needed
                // This is needed if your Crystal Report is using a database
                // For example:
                // reportDocument.SetDatabaseLogon("username", "password", "server", "database");

                // Set the report source for the Crystal Report Viewer control
                crystalReportViewer1.ReportSource = reportDocument;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Crystal Report: " + ex.Message);
            }
        }
    }
}
