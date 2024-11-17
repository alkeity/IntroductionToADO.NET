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
		Dictionary<string, int> studyFields;
		Dictionary<string, int> learningForms;

		public AddGroupForm()
		{
			InitializeComponent();
			this.Icon = Icon.ExtractAssociatedIcon(Assembly.GetEntryAssembly().Location);
			studyFields = new Dictionary<string, int>();
			learningForms = new Dictionary<string, int>();
		}

        public AddGroupForm(Dictionary<string, int> studyFields, Dictionary<string, int> learningForms)
        {
			InitializeComponent();
			this.Icon = Icon.ExtractAssociatedIcon(Assembly.GetEntryAssembly().Location);
			this.studyFields = studyFields;
			this.learningForms = learningForms;
		}

		void LoadStudyFields()
		{
			if (studyFields.Count <= 0) studyFields = Connector.SelectColumnWithID("study_field_name", "StudyFields");
			comboStudyField.Items.AddRange(studyFields.Keys.ToArray());
			comboStudyField.SelectedIndex = 0;
		}

		void LoadLearningForms()
		{
			if (learningForms.Count <= 0) learningForms = Connector.SelectColumnWithID("form_name", "LearningForms");
			comboLearningForm.Items.AddRange(learningForms.Keys.ToArray());
			comboLearningForm.SelectedIndex = 0;
		}

		byte GetWeekdaysFromForm()
		{
			byte days = 0;
			byte day = 1;

			for (byte i = 0; i < clbDays.Items.Count; i++)
			{
				if (clbDays.GetItemChecked(i)) days |= Convert.ToByte(day << i);
			}
			Console.WriteLine(days);

			return days;
		}

		void SetWeekdaysToForm(byte days)
		{
			for (int i = 0; i < clbDays.Items.Count; i++)
			{
				if ((days & (1 << i)) != 0) clbDays.Items[i] = true;
				else clbDays.Items[i] = false;
			}
		}

		private void AddGroupForm_Load(object sender, EventArgs e)
		{
			LoadStudyFields();
			LoadLearningForms();

			//Console.WriteLine(sender.GetType());
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			//SetWeekdaysToForm(21); // 21 == mon wed fri
			GetWeekdaysFromForm();
			if (tbGroupName.Text.Length <= 0)
			{
				MessageBox.Show("Group name cannot be empty.");
				return;
			}

			Group group = new Group(
				tbGroupName.Text,
				GetWeekdaysFromForm(),
				dtpDate.Value, dtpTime.Value.TimeOfDay,
				studyFields[comboStudyField.Text],
				learningForms[comboLearningForm.Text]
				);

			try
			{
				Connector.InsertGroup(group);
				MessageBox.Show($"Success! New group added:\n{tbGroupName.Text}, study field: {comboStudyField.Text}");
				tbGroupName.Text = "";
				comboStudyField.SelectedIndex = 0;
			}
			//catch (SqlException) { MessageBox.Show("Study field does not exist"); }
			catch (Exception exception) { MessageBox.Show(exception.Message); }
		}
	}
}
