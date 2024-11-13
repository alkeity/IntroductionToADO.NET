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
			this.SuspendLayout();
			// 
			// tbGroupName
			// 
			this.tbGroupName.Location = new System.Drawing.Point(104, 25);
			this.tbGroupName.Name = "tbGroupName";
			this.tbGroupName.Size = new System.Drawing.Size(172, 20);
			this.tbGroupName.TabIndex = 0;
			// 
			// comboStudyField
			// 
			this.comboStudyField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboStudyField.FormattingEnabled = true;
			this.comboStudyField.Location = new System.Drawing.Point(104, 62);
			this.comboStudyField.Name = "comboStudyField";
			this.comboStudyField.Size = new System.Drawing.Size(172, 21);
			this.comboStudyField.TabIndex = 1;
			// 
			// labelGroupName
			// 
			this.labelGroupName.AutoSize = true;
			this.labelGroupName.Location = new System.Drawing.Point(13, 28);
			this.labelGroupName.Name = "labelGroupName";
			this.labelGroupName.Size = new System.Drawing.Size(70, 13);
			this.labelGroupName.TabIndex = 2;
			this.labelGroupName.Text = "Group Name:";
			// 
			// labelStudyField
			// 
			this.labelStudyField.AutoSize = true;
			this.labelStudyField.Location = new System.Drawing.Point(13, 65);
			this.labelStudyField.Name = "labelStudyField";
			this.labelStudyField.Size = new System.Drawing.Size(62, 13);
			this.labelStudyField.TabIndex = 3;
			this.labelStudyField.Text = "Study Field:";
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(77, 99);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 4;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(158, 99);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// AddGroupForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(311, 137);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.labelStudyField);
			this.Controls.Add(this.labelGroupName);
			this.Controls.Add(this.comboStudyField);
			this.Controls.Add(this.tbGroupName);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AddGroupForm";
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
	}
}