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
		Group group;

		public Group Group { get => group; }

		public AddGroupForm()
		{
			InitializeComponent();
			this.Icon = Icon.ExtractAssociatedIcon(Assembly.GetEntryAssembly().Location);
			group = new Group();
		}

        public AddGroupForm(Group group) : this()
        {
			this.group = group;
			btnAdd.Text = "Update";
		}

        void InitWithGroup()
		{
			tbGroupName.Text = group.Name;
			SetWeekdaysToForm(group.StudyDays);
			dtpDate.Value = group.StartDate;
			dtpTime.Value = group.StartDate + group.StartTime;
			comboLearningForm.SelectedIndex = comboLearningForm.Items.IndexOf(Connector.learningForms.FirstOrDefault(x => x.Value == group.LearningFormID).Key);
			comboStudyField.SelectedIndex = comboStudyField.Items.IndexOf(Connector.studyFields.FirstOrDefault(x => x.Value == group.StudyFieldID).Key);
		}

		void LoadStudyFields()
		{
			comboStudyField.Items.AddRange(Connector.studyFields.Keys.ToArray());
			comboStudyField.SelectedIndex = 0;
		}

		void LoadLearningForms()
		{
			comboLearningForm.Items.AddRange(Connector.learningForms.Keys.ToArray());
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

			return days;
		}

		void SetWeekdaysToForm(byte days)
		{
			for (byte i = 0; i < clbDays.Items.Count; i++)
			{
				clbDays.SetItemChecked(i, (days & (1 << i)) != 0);
			}
		}

		private void AddGroupForm_Load(object sender, EventArgs e)
		{
			LoadStudyFields();
			LoadLearningForms();
			if (group.Id != 0) InitWithGroup();

			//Console.WriteLine(sender.GetType());
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			GetWeekdaysFromForm();
			if (tbGroupName.Text.Length <= 0)
			{
				MessageBox.Show("Group name cannot be empty.");
				return;
			}

			group.Name = tbGroupName.Text;
			group.StudyDays = GetWeekdaysFromForm();
			group.StartDate = dtpDate.Value;
			group.StartTime = dtpTime.Value.TimeOfDay;
			group.StudyFieldID = Connector.studyFields[comboStudyField.Text];
			group.LearningFormID = Connector.learningForms[comboLearningForm.Text];


			try
			{
				if (group.Id == 0)
				{
					Connector.InsertGroup(group);
				}
				else
				{
					Connector.UpdateGroup(group);
				}
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			//catch (SqlException) { MessageBox.Show("Study field does not exist"); }
			catch (Exception exception) { MessageBox.Show(exception.Message); }
		}
	}
}
