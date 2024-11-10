using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{
	public partial class MainForm : Form
	{
		DataTable dtStudents;
		DataTable dtGroups;
		DataTable dtSubjects;
		DataTable dtTeachers;
		List<string> allGroups;
		public MainForm()
		{
			InitializeComponent();
			this.Icon = Icon.ExtractAssociatedIcon(Assembly.GetEntryAssembly().Location);
			allGroups = new List<string>();
			LoadDataSources();
			LoadFilterOptions();
		}

		void LoadDataSources()
		{
			dtStudents = Connector.Select(
						"[Name] = FORMATMESSAGE('%s %s %s', last_name, first_name, middle_name)," +
						"[Age] = DATEDIFF(day, birth_date, GETDATE()) / 365," +
						"[Group] = group_name," +
						"[Study Field] = study_field_name",
						"Students, Groups, StudyFields",
						"Students.group_id = Groups.id AND Groups.study_field_id = StudyFields.id"
				);
			dtGroups = Connector.Select(
						"[Name] = group_name," +
						"[Study Field] = study_field_name",
						"Groups, StudyFields",
						"Groups.study_field_id = StudyFields.id"
				);
			dtSubjects = Connector.Select(
						"[Name] = subject_name," +
						"[Amount of lessons] = amount_of_hours," +
						"[Report type] = report_type_name",
						"Subjects, ReportTypes",
						"Subjects.report_type_id = ReportTypes.id"
				);
			dtTeachers = Connector.Select(
						"[Name] = FORMATMESSAGE('%s %s %s', last_name, first_name, middle_name)," +
						"[Age] = DATEDIFF(day, birth_date, GETDATE()) / 365," +
						"[Experience] = DATEDIFF(day, year_started, GETDATE()) / 365",
						"Teachers"
				);
		}

		void LoadFilterOptions()
		{
			string item;
			comboStudentsFields.Items.Add("");
			for (int i = 0; i < dtGroups.Rows.Count; i++)
			{
				item = dtGroups.Rows[i]["Study Field"].ToString();
				allGroups.Add(dtGroups.Rows[i]["Name"].ToString());
				comboStudentsGroups.Items.Add(dtGroups.Rows[i]["Name"].ToString());
				if (!comboStudentsFields.Items.Contains(item)) comboStudentsFields.Items.Add(item);
			}
		}

		void LoadFilterGroups(string studyField = "")
		{
			comboStudentsGroups.Items.Clear();
			if (studyField != "")
			{
				for (int i = 0; i < dtGroups.Rows.Count; i++)
				{
					if (studyField == dtGroups.Rows[i]["Study Field"].ToString())
					{
						comboStudentsGroups.Items.Add(dtGroups.Rows[i]["Name"].ToString());
					}
				}
			}
			else
			{
				for (int i = 0; i < allGroups.Count; i++)
				{
					comboStudentsGroups.Items.Add(allGroups[i]);
				}
			}
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			dataGridView.DataSource = dtStudents;
			statusStripCount.Text = $"Amount of students: {dataGridView.RowCount}";
		}

		private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (tabControl.SelectedIndex)
			{
				case 0: // Students tab
					dataGridView.DataSource = dtStudents;
					statusStripCount.Text = $"Amount of students: {dataGridView.RowCount}";
					break;
				case 1: // Groups tab
					dataGridView.DataSource = dtGroups;
					statusStripCount.Text = $"Amount of groups: {dataGridView.RowCount}";
					break;
				case 2: // Subjects tab
					dataGridView.DataSource = dtSubjects;
					statusStripCount.Text = $"Amount of subjects: {dataGridView.RowCount}";
					break;
				case 3: // Teachers tab
					dataGridView.DataSource = dtTeachers;
					statusStripCount.Text = $"Amount of teachers: {dataGridView.RowCount}";
					break;
				default:
					break;
			}
		}

		private void tbSearchStudents_TextChanged(object sender, EventArgs e)
		{
			dtStudents.DefaultView.RowFilter = $"[Name] LIKE '%{tbSearchStudents.Text}%'";
		}

		private void comboStudentsGroups_SelectedIndexChanged(object sender, EventArgs e)
		{
			dtStudents.DefaultView.RowFilter = $"[Group] LIKE '{comboStudentsGroups.Text}'";
		}

		private void comboStudentsGroups_TextUpdate(object sender, EventArgs e)
		{
			dtStudents.DefaultView.RowFilter = $"[Group] LIKE '%{comboStudentsGroups.Text}%'";
		}

		private void comboStudentsFields_SelectedIndexChanged(object sender, EventArgs e)
		{
			dtStudents.DefaultView.RowFilter = $"[Study Field] LIKE '%{comboStudentsFields.Text}%'";
			LoadFilterGroups(comboStudentsFields.Text);
		}
	}
}
