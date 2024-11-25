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
	public partial class AddStudentForm : Form
	{
		Student student;
		Dictionary<string, int> groups;

		public AddStudentForm()
		{
			InitializeComponent();
			this.Icon = Icon.ExtractAssociatedIcon(Assembly.GetEntryAssembly().Location);
			groups = Connector.SelectColumnWithID("group_name", "Groups");
			student = new Student();
		}

        public AddStudentForm(Student student) : this()
        {
			this.student = student;
			btnAdd.Text = "Update";
			this.Text = "Update student";
        }

		private void Init()
		{
			tbFirstName.Text = student.FirstName;
			tbLastName.Text = student.LastName;
			tbMiddleName.Text = student.MiddleName;
			dtpBirthdate.Value = student.BirthDate;
			comboGroups.SelectedIndex = comboGroups.Items.IndexOf(groups.FirstOrDefault(x => x.Value == student.GroupID).Key);
		}

        private void AddStudentForm_Load(object sender, EventArgs e)
		{
			comboGroups.Items.AddRange(groups.Keys.ToArray());
			comboGroups.SelectedIndex = 0;
			if (student.ID != 0) Init();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			student.LastName = tbLastName.Text;
			student.FirstName = tbFirstName.Text;
			student.MiddleName = tbMiddleName.Text;
			student.BirthDate = dtpBirthdate.Value;
			student.GroupID = groups[comboGroups.Text];

			try
			{
				if (student.ID == 0)
				{
					Connector.InsertStudent(student);
					DialogResult = DialogResult.OK;
					this.Close();
				}
				else
				{
					Connector.UpdateStudent(student);
					DialogResult = DialogResult.OK;
					this.Close();
				}
			}
			catch (Exception exception) { MessageBox.Show(exception.Message); }
		}
	}
}
