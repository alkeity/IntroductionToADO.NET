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
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.tabPageGroups = new System.Windows.Forms.TabPage();
			this.tabPageSubjects = new System.Windows.Forms.TabPage();
			this.tabPageTeachers = new System.Windows.Forms.TabPage();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.statusStripCount = new System.Windows.Forms.ToolStripStatusLabel();
			this.tabControl.SuspendLayout();
			this.tabPageStudents.SuspendLayout();
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
			this.labelStudyField.Location = new System.Drawing.Point(376, 8);
			this.labelStudyField.Name = "labelStudyField";
			this.labelStudyField.Size = new System.Drawing.Size(62, 13);
			this.labelStudyField.TabIndex = 6;
			this.labelStudyField.Text = "Study Field:";
			// 
			// comboStudentsFields
			// 
			this.comboStudentsFields.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboStudentsFields.FormattingEnabled = true;
			this.comboStudentsFields.Location = new System.Drawing.Point(454, 4);
			this.comboStudentsFields.Name = "comboStudentsFields";
			this.comboStudentsFields.Size = new System.Drawing.Size(121, 21);
			this.comboStudentsFields.TabIndex = 5;
			this.comboStudentsFields.SelectedIndexChanged += new System.EventHandler(this.comboStudentsFields_SelectedIndexChanged);
			// 
			// comboStudentsGroups
			// 
			this.comboStudentsGroups.FormattingEnabled = true;
			this.comboStudentsGroups.Location = new System.Drawing.Point(239, 4);
			this.comboStudentsGroups.Name = "comboStudentsGroups";
			this.comboStudentsGroups.Size = new System.Drawing.Size(121, 21);
			this.comboStudentsGroups.TabIndex = 4;
			this.comboStudentsGroups.SelectedIndexChanged += new System.EventHandler(this.comboStudentsGroups_SelectedIndexChanged);
			this.comboStudentsGroups.TextUpdate += new System.EventHandler(this.comboStudentsGroups_TextUpdate);
			// 
			// labelGroup
			// 
			this.labelGroup.AutoSize = true;
			this.labelGroup.Location = new System.Drawing.Point(184, 8);
			this.labelGroup.Name = "labelGroup";
			this.labelGroup.Size = new System.Drawing.Size(39, 13);
			this.labelGroup.TabIndex = 3;
			this.labelGroup.Text = "Group:";
			// 
			// tbSearchStudents
			// 
			this.tbSearchStudents.Location = new System.Drawing.Point(68, 4);
			this.tbSearchStudents.Name = "tbSearchStudents";
			this.tbSearchStudents.Size = new System.Drawing.Size(100, 20);
			this.tbSearchStudents.TabIndex = 2;
			this.tbSearchStudents.TextChanged += new System.EventHandler(this.tbSearchStudents_TextChanged);
			// 
			// labelSearch
			// 
			this.labelSearch.AutoSize = true;
			this.labelSearch.Location = new System.Drawing.Point(8, 8);
			this.labelSearch.Name = "labelSearch";
			this.labelSearch.Size = new System.Drawing.Size(44, 13);
			this.labelSearch.TabIndex = 1;
			this.labelSearch.Text = "Search:";
			// 
			// dataGridView
			// 
			this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(4, 59);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.Size = new System.Drawing.Size(593, 398);
			this.dataGridView.TabIndex = 0;
			// 
			// tabPageGroups
			// 
			this.tabPageGroups.Location = new System.Drawing.Point(4, 22);
			this.tabPageGroups.Name = "tabPageGroups";
			this.tabPageGroups.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageGroups.Size = new System.Drawing.Size(591, 33);
			this.tabPageGroups.TabIndex = 1;
			this.tabPageGroups.Text = "Groups";
			this.tabPageGroups.UseVisualStyleBackColor = true;
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
			this.Text = "Academy";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.tabControl.ResumeLayout(false);
			this.tabPageStudents.ResumeLayout(false);
			this.tabPageStudents.PerformLayout();
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
	}
}

