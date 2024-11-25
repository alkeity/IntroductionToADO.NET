namespace Academy
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPageStudents = new System.Windows.Forms.TabPage();
			this.labelStudyField = new System.Windows.Forms.Label();
			this.comboStudentsFields = new System.Windows.Forms.ComboBox();
			this.comboStudentsGroups = new System.Windows.Forms.ComboBox();
			this.labelGroup = new System.Windows.Forms.Label();
			this.tbSearchStudents = new System.Windows.Forms.TextBox();
			this.labelSearch = new System.Windows.Forms.Label();
			this.tabPageGroups = new System.Windows.Forms.TabPage();
			this.btnAddGroup = new System.Windows.Forms.Button();
			this.labelGroupsFields = new System.Windows.Forms.Label();
			this.labelGroupsSearch = new System.Windows.Forms.Label();
			this.tbGroupsSearch = new System.Windows.Forms.TextBox();
			this.comboGroupsFields = new System.Windows.Forms.ComboBox();
			this.tabPageSubjects = new System.Windows.Forms.TabPage();
			this.tabPageTeachers = new System.Windows.Forms.TabPage();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.statusStripCount = new System.Windows.Forms.ToolStripStatusLabel();
			this.btnAddStudent = new System.Windows.Forms.Button();
			this.tabControl.SuspendLayout();
			this.tabPageStudents.SuspendLayout();
			this.tabPageGroups.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.statusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl.Controls.Add(this.tabPageStudents);
			this.tabControl.Controls.Add(this.tabPageGroups);
			this.tabControl.Controls.Add(this.tabPageSubjects);
			this.tabControl.Controls.Add(this.tabPageTeachers);
			this.tabControl.Location = new System.Drawing.Point(0, 0);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(599, 59);
			this.tabControl.TabIndex = 0;
			this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
			// 
			// tabPageStudents
			// 
			this.tabPageStudents.Controls.Add(this.btnAddStudent);
			this.tabPageStudents.Controls.Add(this.labelStudyField);
			this.tabPageStudents.Controls.Add(this.comboStudentsFields);
			this.tabPageStudents.Controls.Add(this.comboStudentsGroups);
			this.tabPageStudents.Controls.Add(this.labelGroup);
			this.tabPageStudents.Controls.Add(this.tbSearchStudents);
			this.tabPageStudents.Controls.Add(this.labelSearch);
			this.tabPageStudents.Location = new System.Drawing.Point(4, 22);
			this.tabPageStudents.Name = "tabPageStudents";
			this.tabPageStudents.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageStudents.Size = new System.Drawing.Size(591, 33);
			this.tabPageStudents.TabIndex = 0;
			this.tabPageStudents.Text = "Students";
			this.tabPageStudents.UseVisualStyleBackColor = true;
			// 
			// labelStudyField
			// 
			this.labelStudyField.AutoSize = true;
			this.labelStudyField.Location = new System.Drawing.Point(309, 10);
			this.labelStudyField.Name = "labelStudyField";
			this.labelStudyField.Size = new System.Drawing.Size(62, 13);
			this.labelStudyField.TabIndex = 6;
			this.labelStudyField.Text = "Study Field:";
			// 
			// comboStudentsFields
			// 
			this.comboStudentsFields.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboStudentsFields.FormattingEnabled = true;
			this.comboStudentsFields.Location = new System.Drawing.Point(375, 6);
			this.comboStudentsFields.Name = "comboStudentsFields";
			this.comboStudentsFields.Size = new System.Drawing.Size(121, 21);
			this.comboStudentsFields.TabIndex = 5;
			this.comboStudentsFields.SelectedIndexChanged += new System.EventHandler(this.comboStudentsFields_SelectedIndexChanged);
			// 
			// comboStudentsGroups
			// 
			this.comboStudentsGroups.FormattingEnabled = true;
			this.comboStudentsGroups.Location = new System.Drawing.Point(208, 6);
			this.comboStudentsGroups.Name = "comboStudentsGroups";
			this.comboStudentsGroups.Size = new System.Drawing.Size(93, 21);
			this.comboStudentsGroups.TabIndex = 4;
			this.comboStudentsGroups.SelectedIndexChanged += new System.EventHandler(this.comboStudentsGroups_SelectedIndexChanged);
			this.comboStudentsGroups.TextUpdate += new System.EventHandler(this.comboStudentsGroups_TextUpdate);
			// 
			// labelGroup
			// 
			this.labelGroup.AutoSize = true;
			this.labelGroup.Location = new System.Drawing.Point(169, 10);
			this.labelGroup.Name = "labelGroup";
			this.labelGroup.Size = new System.Drawing.Size(39, 13);
			this.labelGroup.TabIndex = 3;
			this.labelGroup.Text = "Group:";
			// 
			// tbSearchStudents
			// 
			this.tbSearchStudents.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.tbSearchStudents.Location = new System.Drawing.Point(55, 6);
			this.tbSearchStudents.Name = "tbSearchStudents";
			this.tbSearchStudents.Size = new System.Drawing.Size(100, 20);
			this.tbSearchStudents.TabIndex = 2;
			this.tbSearchStudents.TextChanged += new System.EventHandler(this.tbSearchStudents_TextChanged);
			// 
			// labelSearch
			// 
			this.labelSearch.AutoSize = true;
			this.labelSearch.Location = new System.Drawing.Point(8, 10);
			this.labelSearch.Name = "labelSearch";
			this.labelSearch.Size = new System.Drawing.Size(44, 13);
			this.labelSearch.TabIndex = 1;
			this.labelSearch.Text = "Search:";
			// 
			// tabPageGroups
			// 
			this.tabPageGroups.Controls.Add(this.btnAddGroup);
			this.tabPageGroups.Controls.Add(this.labelGroupsFields);
			this.tabPageGroups.Controls.Add(this.labelGroupsSearch);
			this.tabPageGroups.Controls.Add(this.tbGroupsSearch);
			this.tabPageGroups.Controls.Add(this.comboGroupsFields);
			this.tabPageGroups.Location = new System.Drawing.Point(4, 22);
			this.tabPageGroups.Name = "tabPageGroups";
			this.tabPageGroups.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageGroups.Size = new System.Drawing.Size(591, 33);
			this.tabPageGroups.TabIndex = 1;
			this.tabPageGroups.Text = "Groups";
			this.tabPageGroups.UseVisualStyleBackColor = true;
			// 
			// btnAddGroup
			// 
			this.btnAddGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAddGroup.Location = new System.Drawing.Point(511, 5);
			this.btnAddGroup.Name = "btnAddGroup";
			this.btnAddGroup.Size = new System.Drawing.Size(75, 23);
			this.btnAddGroup.TabIndex = 8;
			this.btnAddGroup.Text = "Add Group";
			this.btnAddGroup.UseVisualStyleBackColor = true;
			this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
			// 
			// labelGroupsFields
			// 
			this.labelGroupsFields.AutoSize = true;
			this.labelGroupsFields.Location = new System.Drawing.Point(174, 10);
			this.labelGroupsFields.Name = "labelGroupsFields";
			this.labelGroupsFields.Size = new System.Drawing.Size(62, 13);
			this.labelGroupsFields.TabIndex = 7;
			this.labelGroupsFields.Text = "Study Field:";
			// 
			// labelGroupsSearch
			// 
			this.labelGroupsSearch.AutoSize = true;
			this.labelGroupsSearch.Location = new System.Drawing.Point(8, 10);
			this.labelGroupsSearch.Name = "labelGroupsSearch";
			this.labelGroupsSearch.Size = new System.Drawing.Size(44, 13);
			this.labelGroupsSearch.TabIndex = 2;
			this.labelGroupsSearch.Text = "Search:";
			// 
			// tbGroupsSearch
			// 
			this.tbGroupsSearch.Location = new System.Drawing.Point(63, 6);
			this.tbGroupsSearch.Name = "tbGroupsSearch";
			this.tbGroupsSearch.Size = new System.Drawing.Size(100, 20);
			this.tbGroupsSearch.TabIndex = 1;
			// 
			// comboGroupsFields
			// 
			this.comboGroupsFields.FormattingEnabled = true;
			this.comboGroupsFields.Location = new System.Drawing.Point(247, 6);
			this.comboGroupsFields.Name = "comboGroupsFields";
			this.comboGroupsFields.Size = new System.Drawing.Size(121, 21);
			this.comboGroupsFields.TabIndex = 0;
			// 
			// tabPageSubjects
			// 
			this.tabPageSubjects.Location = new System.Drawing.Point(4, 22);
			this.tabPageSubjects.Name = "tabPageSubjects";
			this.tabPageSubjects.Size = new System.Drawing.Size(591, 33);
			this.tabPageSubjects.TabIndex = 3;
			this.tabPageSubjects.Text = "Subjects";
			this.tabPageSubjects.UseVisualStyleBackColor = true;
			// 
			// tabPageTeachers
			// 
			this.tabPageTeachers.Location = new System.Drawing.Point(4, 22);
			this.tabPageTeachers.Name = "tabPageTeachers";
			this.tabPageTeachers.Size = new System.Drawing.Size(591, 33);
			this.tabPageTeachers.TabIndex = 2;
			this.tabPageTeachers.Text = "Teachers";
			this.tabPageTeachers.UseVisualStyleBackColor = true;
			// 
			// dataGridView
			// 
			this.dataGridView.AllowUserToAddRows = false;
			this.dataGridView.AllowUserToDeleteRows = false;
			this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dataGridView.Location = new System.Drawing.Point(4, 59);
			this.dataGridView.MultiSelect = false;
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.ReadOnly = true;
			this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView.Size = new System.Drawing.Size(593, 398);
			this.dataGridView.TabIndex = 0;
			this.dataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentDoubleClick);
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripCount});
			this.statusStrip.Location = new System.Drawing.Point(0, 460);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(599, 22);
			this.statusStrip.TabIndex = 0;
			this.statusStrip.Text = "statusStrip1";
			// 
			// statusStripCount
			// 
			this.statusStripCount.Name = "statusStripCount";
			this.statusStripCount.Size = new System.Drawing.Size(118, 17);
			this.statusStripCount.Text = "toolStripStatusLabel1";
			// 
			// btnAddStudent
			// 
			this.btnAddStudent.Location = new System.Drawing.Point(508, 5);
			this.btnAddStudent.Name = "btnAddStudent";
			this.btnAddStudent.Size = new System.Drawing.Size(75, 23);
			this.btnAddStudent.TabIndex = 7;
			this.btnAddStudent.Text = "Add";
			this.btnAddStudent.UseVisualStyleBackColor = true;
			this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(599, 482);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.dataGridView);
			this.MinimumSize = new System.Drawing.Size(615, 521);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Academy";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.tabControl.ResumeLayout(false);
			this.tabPageStudents.ResumeLayout(false);
			this.tabPageStudents.PerformLayout();
			this.tabPageGroups.ResumeLayout(false);
			this.tabPageGroups.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPageStudents;
		private System.Windows.Forms.TabPage tabPageGroups;
		private System.Windows.Forms.TabPage tabPageTeachers;
		private System.Windows.Forms.TabPage tabPageSubjects;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel statusStripCount;
		private System.Windows.Forms.ComboBox comboStudentsFields;
		private System.Windows.Forms.ComboBox comboStudentsGroups;
		private System.Windows.Forms.Label labelGroup;
		private System.Windows.Forms.TextBox tbSearchStudents;
		private System.Windows.Forms.Label labelSearch;
		private System.Windows.Forms.Label labelStudyField;
		private System.Windows.Forms.ComboBox comboGroupsFields;
		private System.Windows.Forms.Label labelGroupsFields;
		private System.Windows.Forms.Label labelGroupsSearch;
		private System.Windows.Forms.TextBox tbGroupsSearch;
		private System.Windows.Forms.Button btnAddGroup;
		private System.Windows.Forms.Button btnAddStudent;
	}
}

