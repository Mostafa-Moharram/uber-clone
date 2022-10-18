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
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void allComplaintsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersComplaintsByUserId usersComplaintsByUserId = new UsersComplaintsByUserId();
            LoadForm(usersComplaintsByUserId);
        }

        private void getComplaintToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GetComplaintById getComplaintByIdForm = new GetComplaintById();
            LoadForm(getComplaintByIdForm);
        }

        private void savedPlacesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GetSavedPlaces getSavedPlacesForm = new GetSavedPlaces();
            LoadForm(getSavedPlacesForm);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadForm(Form form)
        {
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void newComplaintToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NewComplaint newComplaint = new NewComplaint();
            LoadForm(newComplaint);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void complaintsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComplaintsReportForm complaintsReportForm = new ComplaintsReportForm();
            LoadForm(complaintsReportForm);
        }

        private void formsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void complaintsOnADateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersComplaintsByDate usersComplaintsByDate = new UsersComplaintsByDate();
            LoadForm(usersComplaintsByDate);
        }

        private void savedPlacesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SavedPlacesReportForm savedPlacesReportForm = new SavedPlacesReportForm();
            LoadForm(savedPlacesReportForm);
        }
    }
}
