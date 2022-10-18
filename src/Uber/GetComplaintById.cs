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


namespace Uber
{
    public partial class GetComplaintById : Form
    {
        OracleConnection connection;
        string ordb = "data source= orcl;user id = scott;password=tiger;";

        public GetComplaintById()
        {
            InitializeComponent();
        }

        private void GetComplaintById_Load(object sender, EventArgs e)
        {
            connection = new OracleConnection(ordb);
            connection.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = connection;
            cmd.CommandText = "select Complaint_Id from Complaints";

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ComplaintIds.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void Get_Complaint_Button_Click(object sender, EventArgs e)
        {
            connection = new OracleConnection(ordb);
            connection.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = connection;
            cmd.CommandText = "GetComplaintById";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("Idd", ComplaintIds.SelectedItem.ToString());

            OracleParameter Title = new OracleParameter();
            Title.ParameterName = "Title";
            Title.DbType = DbType.StringFixedLength;
            Title.Size = 35;
            Title.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(Title);

            OracleParameter Text = new OracleParameter();
            Text.ParameterName = "Text";
            Text.DbType = DbType.StringFixedLength;
            Text.Size = 35;
            Text.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(Text);

            cmd.Parameters.Add("Date", OracleDbType.Date, ParameterDirection.Output);

            cmd.Parameters.Add("IsAnswered", OracleDbType.Int32, ParameterDirection.Output);
            cmd.Parameters.Add("UserId", OracleDbType.Int32, ParameterDirection.Output);

            cmd.ExecuteNonQuery();

            Complaint_Title_TextBox.Text = cmd.Parameters["Title"].Value.ToString();
            Complaint_Text_TextBox.Text = cmd.Parameters["Text"].Value.ToString();
            Complaint_Date_TextBox.Text = cmd.Parameters["Date"].Value.ToString();
            Is_Answered_TextBox.Text = cmd.Parameters["IsAnswered"].Value.ToString() == "0" ? "No" : "Yes";
            User_Id_TextBox.Text = cmd.Parameters["UserId"].Value.ToString();

        }
    }
}
