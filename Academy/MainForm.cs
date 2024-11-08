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
		public MainForm()
		{
			InitializeComponent();
			this.Icon = Icon.ExtractAssociatedIcon(Assembly.GetEntryAssembly().Location);
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			dataGridViewStudents.DataSource = Connector.Select(
						"[Name] = FORMATMESSAGE('%s %s %s', last_name, first_name, middle_name)," +
						"[Birth date] = birth_date," +
						"[Group] = group_name," +
						"[Study Field] = study_field_name",
						"Students, Groups, StudyFields",
						"Students.group_id = Groups.id AND Groups.study_field_id = StudyFields.id"
				);
			statusStripCount.Text = $"Количество студентов: {dataGridViewStudents.RowCount}";
		}

		private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
		{
			int tabName = tabControl.SelectedIndex;
			statusStripCount.Text = "";
		}
	}
}
