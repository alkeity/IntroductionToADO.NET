namespace Academy
{
	partial class AddGroupForm
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
			this.tbGroupName = new System.Windows.Forms.TextBox();
			this.comboStudyField = new System.Windows.Forms.ComboBox();
			this.labelGroupName = new System.Windows.Forms.Label();
			this.labelStudyField = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.labelLearningForm = new System.Windows.Forms.Label();
			this.comboLearningForm = new System.Windows.Forms.ComboBox();
			this.labelDays = new System.Windows.Forms.Label();
			this.clbDays = new System.Windows.Forms.CheckedListBox();
			this.labelTime = new System.Windows.Forms.Label();
			this.dtpDate = new System.Windows.Forms.DateTimePicker();
			this.dtpTime = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// tbGroupName
			// 
			this.tbGroupName.Location = new System.Drawing.Point(105, 20);
			this.tbGroupName.Name = "tbGroupName";
			this.tbGroupName.Size = new System.Drawing.Size(347, 20);
			this.tbGroupName.TabIndex = 0;
			// 
			// comboStudyField
			// 
			this.comboStudyField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboStudyField.FormattingEnabled = true;
			this.comboStudyField.Location = new System.Drawing.Point(105, 51);
			this.comboStudyField.Name = "comboStudyField";
			this.comboStudyField.Size = new System.Drawing.Size(347, 21);
			this.comboStudyField.TabIndex = 1;
			// 
			// labelGroupName
			// 
			this.labelGroupName.AutoSize = true;
			this.labelGroupName.Location = new System.Drawing.Point(14, 23);
			this.labelGroupName.Name = "labelGroupName";
			this.labelGroupName.Size = new System.Drawing.Size(70, 13);
			this.labelGroupName.TabIndex = 2;
			this.labelGroupName.Text = "Group Name:";
			// 
			// labelStudyField
			// 
			this.labelStudyField.AutoSize = true;
			this.labelStudyField.Location = new System.Drawing.Point(14, 54);
			this.labelStudyField.Name = "labelStudyField";
			this.labelStudyField.Size = new System.Drawing.Size(62, 13);
			this.labelStudyField.TabIndex = 3;
			this.labelStudyField.Text = "Study Field:";
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(296, 192);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 4;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(377, 192);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// labelLearningForm
			// 
			this.labelLearningForm.AutoSize = true;
			this.labelLearningForm.Location = new System.Drawing.Point(14, 86);
			this.labelLearningForm.Name = "labelLearningForm";
			this.labelLearningForm.Size = new System.Drawing.Size(74, 13);
			this.labelLearningForm.TabIndex = 6;
			this.labelLearningForm.Text = "Learning form:";
			// 
			// comboLearningForm
			// 
			this.comboLearningForm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboLearningForm.FormattingEnabled = true;
			this.comboLearningForm.Location = new System.Drawing.Point(105, 83);
			this.comboLearningForm.Name = "comboLearningForm";
			this.comboLearningForm.Size = new System.Drawing.Size(347, 21);
			this.comboLearningForm.TabIndex = 7;
			// 
			// labelDays
			// 
			this.labelDays.AutoSize = true;
			this.labelDays.Location = new System.Drawing.Point(43, 119);
			this.labelDays.Name = "labelDays";
			this.labelDays.Size = new System.Drawing.Size(34, 13);
			this.labelDays.TabIndex = 8;
			this.labelDays.Text = "Days:";
			// 
			// clbDays
			// 
			this.clbDays.CheckOnClick = true;
			this.clbDays.ColumnWidth = 49;
			this.clbDays.FormattingEnabled = true;
			this.clbDays.Items.AddRange(new object[] {
            "Mon",
            "Tue",
            "Wed",
            "Thu",
            "Fri",
            "Sat",
            "Sun"});
			this.clbDays.Location = new System.Drawing.Point(105, 118);
			this.clbDays.MultiColumn = true;
			this.clbDays.Name = "clbDays";
			this.clbDays.Size = new System.Drawing.Size(347, 19);
			this.clbDays.TabIndex = 9;
			// 
			// labelTime
			// 
			this.labelTime.AutoSize = true;
			this.labelTime.Location = new System.Drawing.Point(43, 148);
			this.labelTime.Name = "labelTime";
			this.labelTime.Size = new System.Drawing.Size(33, 13);
			this.labelTime.TabIndex = 10;
			this.labelTime.Text = "Time:";
			// 
			// dtpDate
			// 
			this.dtpDate.Location = new System.Drawing.Point(105, 145);
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Size = new System.Drawing.Size(202, 20);
			this.dtpDate.TabIndex = 11;
			// 
			// dtpTime
			// 
			this.dtpTime.CustomFormat = "HH:mm";
			this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpTime.Location = new System.Drawing.Point(325, 145);
			this.dtpTime.Name = "dtpTime";
			this.dtpTime.ShowUpDown = true;
			this.dtpTime.Size = new System.Drawing.Size(127, 20);
			this.dtpTime.TabIndex = 12;
			// 
			// AddGroupForm
			// 
			this.AcceptButton = this.btnAdd;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(468, 227);
			this.Controls.Add(this.dtpTime);
			this.Controls.Add(this.dtpDate);
			this.Controls.Add(this.labelTime);
			this.Controls.Add(this.clbDays);
			this.Controls.Add(this.labelDays);
			this.Controls.Add(this.comboLearningForm);
			this.Controls.Add(this.labelLearningForm);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.labelStudyField);
			this.Controls.Add(this.labelGroupName);
			this.Controls.Add(this.comboStudyField);
			this.Controls.Add(this.tbGroupName);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AddGroupForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Add new group";
			this.Load += new System.EventHandler(this.AddGroupForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbGroupName;
		private System.Windows.Forms.ComboBox comboStudyField;
		private System.Windows.Forms.Label labelGroupName;
		private System.Windows.Forms.Label labelStudyField;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label labelLearningForm;
		private System.Windows.Forms.ComboBox comboLearningForm;
		private System.Windows.Forms.Label labelDays;
		private System.Windows.Forms.CheckedListBox clbDays;
		private System.Windows.Forms.Label labelTime;
		private System.Windows.Forms.DateTimePicker dtpDate;
		private System.Windows.Forms.DateTimePicker dtpTime;
	}
}