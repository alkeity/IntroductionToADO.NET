#define CONSOLE

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace AcademyDataSet
{
	public partial class MainForm : Form
	{
		readonly string connectionStr;
		SqlConnection connection;
		DataSet groupsRelatedData;

		public MainForm()
		{
			InitializeComponent();
			connectionStr = ConfigurationManager.ConnectionStrings["AcademyConnectionString"].ConnectionString;
			connection = new SqlConnection(connectionStr);
			groupsRelatedData = new DataSet(nameof(groupsRelatedData));
#if CONSOLE
			AllocConsole();
#endif
		}

		~MainForm()
		{
#if CONSOLE
			FreeConsole();
#endif
		}

		private void InitDataSet()
		{
			string dsTableFields = "StudyFields";
			groupsRelatedData.Tables.Add(dsTableFields);
			groupsRelatedData.Tables[dsTableFields].Columns.Add("id", typeof(int));
			groupsRelatedData.Tables[dsTableFields].Columns.Add("study_field_name", typeof(string));
			groupsRelatedData.Tables[dsTableFields].PrimaryKey = new DataColumn[] { groupsRelatedData.Tables[dsTableFields].Columns["id"] };

			groupsRelatedData.Tables.Add("Groups");
			groupsRelatedData.Tables["Groups"].Columns.Add("id", typeof(int));
			groupsRelatedData.Tables["Groups"].Columns.Add("group_name", typeof(string));
			groupsRelatedData.Tables["Groups"].Columns.Add("study_field_id", typeof(int));
			groupsRelatedData.Tables["Groups"].PrimaryKey = new DataColumn[] { groupsRelatedData.Tables["Groups"].Columns["id"] };

			groupsRelatedData.Relations.Add(
				"GroupsStudyField",
				groupsRelatedData.Tables[dsTableFields].Columns["id"],
				groupsRelatedData.Tables["Groups"].Columns["study_field_id"]
				);

			string cmdStrFields = "SELECT * FROM StudyFields";
			string cmdStrGroups = "SELECT * FROM Groups";
			SqlDataAdapter adapterFields = new SqlDataAdapter(cmdStrFields, connection);
			SqlDataAdapter adapterGroups = new SqlDataAdapter(cmdStrGroups, connection);

			connection.Open();
			try
			{
				adapterFields.Fill(groupsRelatedData.Tables[dsTableFields]);
				adapterGroups.Fill(groupsRelatedData.Tables["Groups"]);
			}
			finally { connection.Close(); }

			foreach (DataRow row in groupsRelatedData.Tables[dsTableFields].Rows)
			{
				Console.WriteLine($"{row["id"]}: {row["study_field_name"]}");
			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			InitDataSet();
		}

		[DllImport("kernel32.dll")]
		private static extern bool AllocConsole();
		[DllImport("kernel32.dll")]
		private static extern bool FreeConsole();
	}
}
