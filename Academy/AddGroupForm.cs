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
			comboStudyField.Items.AddRange(Connector.SelectColumn("study_field_name", "StudyFields").ToArray());
			comboStudyField.SelectedIndex = 0;
		}

		void LoadLearningForms()
		{
			comboLearningForm.Items.AddRange(Connector.SelectColumn("form_name", "LearningForms").ToArray());
			comboLearningForm.SelectedIndex = 0;
		}

		byte GetWeekdaysFromForm()
		{
			byte days = 0;
			byte day = 1;

			for (byte i = 0; i < clbDays.Items.Count; i++)
			{
				Console.Write(clbDays.GetItemChecked(i) + "\n");
				if (clbDays.GetItemChecked(i)) days |= Convert.ToByte(day << i);
			}
			Console.WriteLine();
			Console.WriteLine(days);

			return days;
		}

		private void AddGroupForm_Load(object sender, EventArgs e)
		{
			LoadStudyFields();
			LoadLearningForms();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			GetWeekdays();
			//if (tbGroupName.Text.Length <= 0)
			//{
			//	MessageBox.Show("Group name cannot be empty.");
			//	return;
			//}

			//try
			//{
			//	Connector.InsertGroup(tbGroupName.Text, comboStudyField.Text);
			//	MessageBox.Show($"Success! New group added:\n{tbGroupName.Text}, study field: {comboStudyField.Text}");
			//	tbGroupName.Text = "";
			//	comboStudyField.SelectedIndex = 0;
			//}
			////catch (SqlException) { MessageBox.Show("Study field does not exist"); }
			//catch (Exception exception) { MessageBox.Show(exception.Message); }
		}
	}
}
