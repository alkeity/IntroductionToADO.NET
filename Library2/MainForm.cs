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
			LoadTablesToComboBox();
		}

		void LoadTablesToComboBox()
		{
			string cmdStr = "SELECT table_name FROM information_schema.tables";
			SqlCommand cmd = new SqlCommand(cmdStr, connection);
			connection.Open();
			SqlDataReader reader = cmd.ExecuteReader();
			if (reader.HasRows)
			{
				while (reader.Read())
				{
					tbQuery.Items.Add(reader[0]);
				}
			}
			reader.Close();
			connection.Close();
		}

		void SelectAllFromTable(string tableName)
		{
			string cmdStr = $"SELECT * FROM [{tableName}]";
			SqlCommand cmd = new SqlCommand(cmdStr, connection);
			connection.Open();
			SqlDataReader reader = cmd.ExecuteReader();
			if (reader.HasRows)
			{
				DataTable table = new DataTable();
				for (int i = 0; i < reader.FieldCount; i++) table.Columns.Add(reader.GetName(i));
				while (reader.Read())
				{
					DataRow row = table.NewRow();
					for (int i = 0; i < reader.FieldCount; i++) row[i] = reader[i];
					table.Rows.Add(row);
				}
				dataGridView.DataSource = table;
			}
			reader.Close();
			connection.Close();
		}

		private void btnExecute_Click(object sender, EventArgs e)
		{
			SelectAllFromTable(tbQuery.Text);
		}

		private void tbQuery_SelectedIndexChanged(object sender, EventArgs e)
		{
			dataGridView.DataSource = null;
			SelectAllFromTable(tbQuery.Text);
		}
	}
}
