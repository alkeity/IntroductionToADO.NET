namespace Academy
{
	partial class AddStudentForm
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
			this.labelFirstName = new System.Windows.Forms.Label();
			this.labelLastName = new System.Windows.Forms.Label();
			this.labelMiddleName = new System.Windows.Forms.Label();
			this.labelBirthdate = new System.Windows.Forms.Label();
			this.labelGroup = new System.Windows.Forms.Label();
			this.tbFirstName = new System.Windows.Forms.TextBox();
			this.tbLastName = new System.Windows.Forms.TextBox();
			this.tbMiddleName = new System.Windows.Forms.TextBox();
			this.dtpBirthdate = new System.Windows.Forms.DateTimePicker();
			this.comboGroups = new System.Windows.Forms.ComboBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelFirstName
			// 
			this.labelFirstName.AutoSize = true;
			this.labelFirstName.Location = new System.Drawing.Point(24, 22);
			this.labelFirstName.Name = "labelFirstName";
			this.labelFirstName.Size = new System.Drawing.Size(58, 13);
			this.labelFirstName.TabIndex = 0;
			this.labelFirstName.Text = "First name:";
			// 
			// labelLastName
			// 
			this.labelLastName.AutoSize = true;
			this.labelLastName.Location = new System.Drawing.Point(23, 49);
			this.labelLastName.Name = "labelLastName";
			this.labelLastName.Size = new System.Drawing.Size(59, 13);
			this.labelLastName.TabIndex = 1;
			this.labelLastName.Text = "Last name:";
			// 
			// labelMiddleName
			// 
			this.labelMiddleName.AutoSize = true;
			this.labelMiddleName.Location = new System.Drawing.Point(12, 76);
			this.labelMiddleName.Name = "labelMiddleName";
			this.labelMiddleName.Size = new System.Drawing.Size(70, 13);
			this.labelMiddleName.TabIndex = 2;
			this.labelMiddleName.Text = "Middle name:";
			// 
			// labelBirthdate
			// 
			this.labelBirthdate.AutoSize = true;
			this.labelBirthdate.Location = new System.Drawing.Point(25, 103);
			this.labelBirthdate.Name = "labelBirthdate";
			this.labelBirthdate.Size = new System.Drawing.Size(57, 13);
			this.labelBirthdate.TabIndex = 3;
			this.labelBirthdate.Text = "Birth Date:";
			// 
			// labelGroup
			// 
			this.labelGroup.AutoSize = true;
			this.labelGroup.Location = new System.Drawing.Point(43, 130);
			this.labelGroup.Name = "labelGroup";
			this.labelGroup.Size = new System.Drawing.Size(39, 13);
			this.labelGroup.TabIndex = 4;
			this.labelGroup.Text = "Group:";
			// 
			// tbFirstName
			// 
			this.tbFirstName.Location = new System.Drawing.Point(98, 18);
			this.tbFirstName.Name = "tbFirstName";
			this.tbFirstName.Size = new System.Drawing.Size(142, 20);
			this.tbFirstName.TabIndex = 5;
			// 
			// tbLastName
			// 
			this.tbLastName.Location = new System.Drawing.Point(98, 45);
			this.tbLastName.Name = "tbLastName";
			this.tbLastName.Size = new System.Drawing.Size(142, 20);
			this.tbLastName.TabIndex = 6;
			// 
			// tbMiddleName
			// 
			this.tbMiddleName.Location = new System.Drawing.Point(98, 72);
			this.tbMiddleName.Name = "tbMiddleName";
			this.tbMiddleName.Size = new System.Drawing.Size(142, 20);
			this.tbMiddleName.TabIndex = 7;
			// 
			// dtpBirthdate
			// 
			this.dtpBirthdate.Location = new System.Drawing.Point(98, 99);
			this.dtpBirthdate.Name = "dtpBirthdate";
			this.dtpBirthdate.Size = new System.Drawing.Size(142, 20);
			this.dtpBirthdate.TabIndex = 8;
			this.dtpBirthdate.Value = new System.DateTime(2024, 11, 25, 3, 41, 15, 0);
			// 
			// comboGroups
			// 
			this.comboGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboGroups.FormattingEnabled = true;
			this.comboGroups.Location = new System.Drawing.Point(98, 126);
			this.comboGroups.Name = "comboGroups";
			this.comboGroups.Size = new System.Drawing.Size(142, 21);
			this.comboGroups.TabIndex = 9;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(42, 160);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 10;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(139, 160);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 11;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// AddStudentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(257, 200);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.comboGroups);
			this.Controls.Add(this.dtpBirthdate);
			this.Controls.Add(this.tbMiddleName);
			this.Controls.Add(this.tbLastName);
			this.Controls.Add(this.tbFirstName);
			this.Controls.Add(this.labelGroup);
			this.Controls.Add(this.labelBirthdate);
			this.Controls.Add(this.labelMiddleName);
			this.Controls.Add(this.labelLastName);
			this.Controls.Add(this.labelFirstName);
			this.Name = "AddStudentForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AddStudentForm";
			this.Load += new System.EventHandler(this.AddStudentForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelFirstName;
		private System.Windows.Forms.Label labelLastName;
		private System.Windows.Forms.Label labelMiddleName;
		private System.Windows.Forms.Label labelBirthdate;
		private System.Windows.Forms.Label labelGroup;
		private System.Windows.Forms.TextBox tbFirstName;
		private System.Windows.Forms.TextBox tbLastName;
		private System.Windows.Forms.TextBox tbMiddleName;
		private System.Windows.Forms.DateTimePicker dtpBirthdate;
		private System.Windows.Forms.ComboBox comboGroups;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnCancel;
	}
}