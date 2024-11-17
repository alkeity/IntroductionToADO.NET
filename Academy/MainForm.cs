using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{
	public partial class MainForm : Form
	{
		DataTable dtSource;
		Dictionary<string, int> studyFields;
		Dictionary<string, int> learningForms;

		HashSet<string> allGroups;
		public MainForm()
		{
			InitializeComponent();
			this.Icon = Icon.ExtractAssociatedIcon(Assembly.GetEntryAssembly().Location);
			allGroups = new HashSet<string>();
			dtSource = new DataTable();

			studyFields = Connector.SelectColumnWithID("study_field_name", "StudyFields");
			learningForms = Connector.SelectColumnWithID("form_name", "LearningForms");

			LoadStudents();
			AllocConsole();
		}

		~MainForm()
		{
			FreeConsole();
		}
		
		void LoadStudents()
		{
			dtSource.Clear();
			dtSource = Connector.Select(
						"[Name] = FORMATMESSAGE('%s %s %s', last_name, first_name, middle_name)," +
						"[Age] = DATEDIFF(day, birth_date, GETDATE()) / 365," +
						"[Group] = group_name," +
						"[Study Field] = study_field_name",
						"Students, Groups, StudyFields",
						"Students.group_id = Groups.id AND Groups.study_field_id = StudyFields.id"
				);
			statusStripCount.Text = $"Amount of students: {dtSource.Rows.Count}";
			dataGridView.DataSource = dtSource;
			LoadFilterOptionsForStudents();
		}

		void LoadGroups()
		{
			dtSource.Clear();
			dtSource = Connector.Select(
						"[Name] = group_name," +
						"[Study Field] = study_field_name",
						"Groups, StudyFields",
						"Groups.study_field_id = StudyFields.id"
				);
			statusStripCount.Text = $"Amount of groups: {dtSource.Rows.Count}";
			dataGridView.DataSource = dtSource;
		}

		void LoadSubjects()
		{
			dtSource.Clear();
			dtSource = Connector.Select(
						"[Name] = subject_name," +
						"[Amount of lessons] = amount_of_hours," +
						"[Report type] = report_type_name",
						"Subjects, ReportTypes",
						"Subjects.report_type_id = ReportTypes.id"
				);
			statusStripCount.Text = $"Amount of subjects: {dtSource.Rows.Count}";
			dataGridView.DataSource = dtSource;
		}

		void LoadTeachers()
		{
			dtSource.Clear();
			dtSource = Connector.Select(
						"[Name] = FORMATMESSAGE('%s %s %s', last_name, first_name, middle_name)," +
						"[Age] = DATEDIFF(day, birth_date, GETDATE()) / 365," +
						"[Experience] = DATEDIFF(day, year_started, GETDATE()) / 365",
						"Teachers"
				);
			statusStripCount.Text = $"Amount of teachers: {dtSource.Rows.Count}";
			dataGridView.DataSource = dtSource;
		}

		void LoadFilterOptionsForStudents()
		{
			comboStudentsFields.Items.Clear();
			comboStudentsGroups.Items.Clear();
			allGroups.Clear();

			HashSet<string> studyFields = new HashSet<string>();

			comboStudentsFields.Items.Add("");
			for (int i = 0; i < dtSource.Rows.Count; i++)
			{
				allGroups.Add(dtSource.Rows[i]["Group"].ToString());
				studyFields.Add(dtSource.Rows[i]["Study Field"].ToString());
			}
			comboStudentsGroups.Items.AddRange(allGroups.ToArray());
			comboStudentsFields.Items.AddRange(studyFields.ToArray());
		}

		void LoadFilterGroups(string studyField = "")
		{
			comboStudentsGroups.Items.Clear();
			if (studyField != "")
			{
				HashSet<string> groups = new HashSet<string>();
				for (int i = 0; i < dtSource.Rows.Count; i++)
				{
					if (dtSource.Rows[i]["Study Field"].ToString() == studyField)
					{
						groups.Add(dtSource.Rows[i]["Group"].ToString());
					}
				}
				comboStudentsGroups.Items.AddRange(groups.ToArray());
			}
			else comboStudentsGroups.Items.AddRange(allGroups.ToArray());
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			dataGridView.DataSource = dtSource;
			//foreach (KeyValuePair<string, int> value in studyFields)
			//{
			//	Console.WriteLine($"{value.Key}: id {value.Value}");
			//}
		}

		private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (tabControl.SelectedIndex)
			{
				case 0: // Students tab
					LoadStudents();
					break;
				case 1: // Groups tab
					LoadGroups();
					break;
				case 2: // Subjects tab
					LoadSubjects();
					break;
				case 3: // Teachers tab
					LoadTeachers();
					break;
				default:
					break;
			}
		}

		private void tbSearchStudents_TextChanged(object sender, EventArgs e)
		{
			dtSource.DefaultView.RowFilter = $"[Name] LIKE '%{tbSearchStudents.Text}%'";
		}

		private void comboStudentsGroups_SelectedIndexChanged(object sender, EventArgs e)
		{
			dtSource.DefaultView.RowFilter = $"[Group] LIKE '{comboStudentsGroups.Text}'";
		}

		private void comboStudentsGroups_TextUpdate(object sender, EventArgs e)
		{
			dtSource.DefaultView.RowFilter = $"[Group] LIKE '%{comboStudentsGroups.Text}%'";
		}

		private void comboStudentsFields_SelectedIndexChanged(object sender, EventArgs e)
		{
			dtSource.DefaultView.RowFilter = $"[Study Field] LIKE '%{comboStudentsFields.Text}%'";
			LoadFilterGroups(comboStudentsFields.Text);
		}

		private void btnAddGroup_Click(object sender, EventArgs e)
		{
			using (AddGroupForm addGroupForm = new AddGroupForm(studyFields, learningForms)) addGroupForm.ShowDialog();
			LoadGroups();
		}

		[DllImport("kernel32.dll")]
		private static extern bool AllocConsole();
		[DllImport("kernel32.dll")]
		private static extern bool FreeConsole();
	}
}
