using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace Uber
{
    public partial class SavedPlacesReportForm : Form
    {
        SavedPlacesReport report;
        public SavedPlacesReportForm()
        {
            InitializeComponent();
        }

        private void SavedPlacesReportForm_Load(object sender, EventArgs e)
        {
            report = new SavedPlacesReport();
            saved_places_report_viewer.ReportSource = report;
        }

        private void saved_places_report_viewer_Load(object sender, EventArgs e)
        {

        }
    }
}
