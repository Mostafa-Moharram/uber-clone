using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uber
{
    public partial class ComplaintsReportForm : Form
    {
        ComplaintsReport report;
        public ComplaintsReportForm()
        {
            InitializeComponent();
        }

        private void ComplaintsReportForm_Load(object sender, EventArgs e)
        {
            report = new ComplaintsReport();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            report.SetParameterValue(0, start_date_txt.Text);
            report.SetParameterValue(1, end_date_txt.Text);
            complaints_report_viewer.ReportSource = report;
        }
    }
}
