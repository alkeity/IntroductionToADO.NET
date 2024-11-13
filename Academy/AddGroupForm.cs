using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{
	public partial class AddGroupForm : Form
	{
		public AddGroupForm()
		{
			InitializeComponent();
			this.Icon = Icon.ExtractAssociatedIcon(Assembly.GetEntryAssembly().Location);
		}

		void LoadStudyFields()
		{
			DataTable studyFields = Connector.Select("study_field_name", "StudyFields");
			for (int i = 0; i < studyFields.Rows.Count; i++)
			{
				comboStudyField.Items.Add(studyFields.Rows[i][0].ToString());
			}
			comboStudyField.SelectedIndex = 0;
		}

		private void AddGroupForm_Load(object sender, EventArgs e)
		{
			LoadStudyFields();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (tbGroupName.Text.Length <= 0)
			{
				MessageBox.Show("Group name cannot be empty.");
				return;
			}

			try
			{
				Connector.InsertGroup(tbGroupName.Text, comboStudyField.Text);
				MessageBox.Show($"Success! New group added:\n{tbGroupName.Text}, study field: {comboStudyField.Text}");
				tbGroupName.Text = "";
				comboStudyField.SelectedIndex = 0;
			}
			//catch (SqlException) { MessageBox.Show("Study field does not exist"); }
			catch (Exception exception) { MessageBox.Show(exception.Message); }
		}
	}
}
