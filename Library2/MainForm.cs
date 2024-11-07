using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Library2
{
	public partial class MainForm : Form
	{
		readonly string connectionString;
		SqlConnection connection;

		public MainForm()
		{
			connectionString = ConfigurationManager.ConnectionStrings["LibraryConnectionString"].ConnectionString;
			connection = new SqlConnection(connectionString);
			InitializeComponent();
		}

		private void btnExecute_Click(object sender, EventArgs e)
		{
			string cmdString = tbQuery.Text;
			SqlCommand cmd = new SqlCommand(cmdString, connection);
			connection.Open();
			DataTable dt = new DataTable();
			SqlDataReader dr = cmd.ExecuteReader();
			for (int i = 0; i < dr.FieldCount; i++) dt.Columns.Add(dr.GetName(i));

			while (dr.Read())
			{
				DataRow row = dt.NewRow();
				for (int i = 0; i < dr.FieldCount; i++) row[i] = dr[i];
				dt.Rows.Add(row);
			}
			dr.Close();
			connection.Close();
			dataGridView.DataSource = dt;
		}
	}
}
