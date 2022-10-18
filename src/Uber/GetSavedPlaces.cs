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
    public partial class GetSavedPlaces : Form
    {
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;

        public GetSavedPlaces()
        {
            InitializeComponent();
        }

        private void GetSavedPlaces_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            string constr = "data source= orcl;user id = scott;password=tiger;";

            string cmdstr = @"select Place_Name, Latitude, Longitude
                              from Saved_Places
                              where User_Id =:n";

            adapter = new OracleDataAdapter(cmdstr, constr);
            adapter.SelectCommand.Parameters.Add("n", UserId.Text);
            ds = new DataSet();
            adapter.Fill(ds);
            SavedPlaces.DataSource = ds.Tables[0];
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
        }

        private void SavedPlaces_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
