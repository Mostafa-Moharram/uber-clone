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
using System.Text.RegularExpressions;

namespace Uber
{
    public partial class NewComplaint : Form
    {
        public NewComplaint()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void NewComplaint_Load(object sender, EventArgs e)
        {
            Program.conn = new OracleConnection(Program.conn_str);
            Program.conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Program.conn;
            cmd.CommandText = "select user_id, first_name, last_name from users";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                name_cmb.Items.Add(dr[0].ToString() + ": " + dr[1].ToString() + " " + dr[2].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (name_cmb.SelectedIndex == -1)
            {
                MessageBox.Show("Select a user");
            } else if (string.IsNullOrEmpty(complaint_title.Text))
            {
                MessageBox.Show("The complaint title cannot be empty");
            } else if (string.IsNullOrEmpty(complaint_body.Text))
            {
                MessageBox.Show("The complaint cannot be empty");
            } else
            {
                int user_id = Int32.Parse(Regex.Match(name_cmb.SelectedItem.ToString(), @"\d+").Value);
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Program.conn;
                cmd.CommandText = "insert into complaints values (complaint_id_seq.nextval, :title, :body, sysdate, 0, :id)";
                cmd.Parameters.Add("title", complaint_title.Text);
                cmd.Parameters.Add("body", complaint_body.Text);
                cmd.Parameters.Add("id", user_id.ToString());
                int ret = cmd.ExecuteNonQuery();
                if (ret == -1)
                {
                    MessageBox.Show("Error! Please try again");
                } else
                {
                    MessageBox.Show("Complaint added successfuly");
                }
            }
        }

        private void name_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            // name_cmb.SelectedText = name_cmb.SelectedItem.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
