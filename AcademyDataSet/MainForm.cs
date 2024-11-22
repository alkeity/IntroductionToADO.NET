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

namespace AcademyDataSet
{
	public partial class MainForm : Form
	{
		readonly string connectionStr;
		SqlConnection connection;
		DataSet groupsRelationData;
		public MainForm()
		{
			InitializeComponent();
			connectionStr = ConfigurationManager.ConnectionStrings["AcademyConnectionString"].ConnectionString;
		}

		private void MainForm_Load(object sender, EventArgs e)
		{

		}
	}
}
