using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Uber {
    public partial class UsersComplaintsByDate : Form {
        private static string CONNECTION_STRING = "data source=orcl; user id=scott; password=tiger;";
        private static string FETCH_COMPLAINTS_BY_DATE_STRING = "GetComplaintsByDate";
        private OracleConnection connection;
        private ComplaintInstances complaintInstances;
        public UsersComplaintsByDate() {
            InitializeComponent();
        }

        private void showComplaintButton_Click(object sender, EventArgs e) {
            OracleCommand command = new OracleCommand {
                Connection = connection,
                CommandText = FETCH_COMPLAINTS_BY_DATE_STRING,
                CommandType = CommandType.StoredProcedure
            };
            DateTime dateTime = new DateTime(
                complaintDatePicker.Value.Year,
                complaintDatePicker.Value.Month,
                complaintDatePicker.Value.Day);
            command.Parameters.Add("complaintDate", dateTime);
            command.Parameters.Add("complaints", OracleDbType.RefCursor, ParameterDirection.Output);
            connection.Open();
            OracleDataReader dataReader = command.ExecuteReader();
            complaintInstances.clear();
            complaintInstances.fillComplaints(dataReader);
            dataReader.Close();
            connection.Close();
            if (complaintInstances.empty()) {
                disableNavigation();
                return;
            }
            enableNavigation();
            setComplaint();
        }
        private void setComplaint() {
            Complaint complaint = complaintInstances.current();
            complaintIdTextBox.Text = complaint.id.ToString();
            titleTextBox.Text = complaint.title;
            descriptionTextBox.Text = complaint.description;
            datePicker.Value = complaint.date;
            yesRadioButton.Checked = complaint.isAnswered;
            noRadioButton.Checked = !complaint.isAnswered;
            userIdTextBox.Text = complaint.userId.ToString();
        }
        private void UsersComplaintsByDate_Load(object sender, EventArgs e) {
            connection = new OracleConnection(CONNECTION_STRING);
            complaintInstances = new ComplaintInstances();
            disableNavigation();
        }

        private void showNextButton_Click(object sender, EventArgs e) {
            complaintInstances.next();
            currentComplaintTextBox.Text = (complaintInstances.getCurrentIndex() + 1).ToString();
            setComplaint();
        }

        private void showPreviousButton_Click(object sender, EventArgs e) {
            complaintInstances.previous();
            currentComplaintTextBox.Text = (complaintInstances.getCurrentIndex() + 1).ToString();
            setComplaint();
        }
        private void disableNavigation() {
            showPreviousButton.Enabled = showNextButton.Enabled = false;
            complaintCountTextBox.Text = string.Empty;
            currentComplaintTextBox.Text = string.Empty;
            complaintIdTextBox.Text = string.Empty;
            titleTextBox.Text = string.Empty;
            descriptionTextBox.Text = string.Empty;
            datePicker.Value = DateTime.Now;
            userIdTextBox.Text = string.Empty;
        }
        private void enableNavigation() {
            showPreviousButton.Enabled = showNextButton.Enabled = true;
            complaintCountTextBox.Text = complaintInstances.size().ToString();
            currentComplaintTextBox.Text = "1";
        }
    }
}
