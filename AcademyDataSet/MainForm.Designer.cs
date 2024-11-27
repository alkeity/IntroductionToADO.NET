namespace AcademyDataSet
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
			this.labelStudyField = new System.Windows.Forms.Label();
			this.labelGroup = new System.Windows.Forms.Label();
			this.comboFields = new System.Windows.Forms.ComboBox();
			this.comboGroups = new System.Windows.Forms.ComboBox();
			this.btnReset = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// labelStudyField
			// 
			this.labelStudyField.AutoSize = true;
			this.labelStudyField.Location = new System.Drawing.Point(18, 19);
			this.labelStudyField.Name = "labelStudyField";
			this.labelStudyField.Size = new System.Drawing.Size(62, 13);
			this.labelStudyField.TabIndex = 0;
			this.labelStudyField.Text = "Study Field:";
			// 
			// labelGroup
			// 
			this.labelGroup.AutoSize = true;
			this.labelGroup.Location = new System.Drawing.Point(38, 55);
			this.labelGroup.Name = "labelGroup";
			this.labelGroup.Size = new System.Drawing.Size(42, 13);
			this.labelGroup.TabIndex = 1;
			this.labelGroup.Text = "Group: ";
			// 
			// comboFields
			// 
			this.comboFields.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboFields.FormattingEnabled = true;
			this.comboFields.Location = new System.Drawing.Point(85, 15);
			this.comboFields.Name = "comboFields";
			this.comboFields.Size = new System.Drawing.Size(192, 21);
			this.comboFields.TabIndex = 2;
			this.comboFields.SelectedIndexChanged += new System.EventHandler(this.comboFields_SelectedIndexChanged);
			// 
			// comboGroups
			// 
			this.comboGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboGroups.FormattingEnabled = true;
			this.comboGroups.Location = new System.Drawing.Point(85, 51);
			this.comboGroups.Name = "comboGroups";
			this.comboGroups.Size = new System.Drawing.Size(192, 21);
			this.comboGroups.TabIndex = 3;
			// 
			// btnReset
			// 
			this.btnReset.Location = new System.Drawing.Point(12, 81);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(75, 23);
			this.btnReset.TabIndex = 4;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(305, 112);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.comboGroups);
			this.Controls.Add(this.comboFields);
			this.Controls.Add(this.labelGroup);
			this.Controls.Add(this.labelStudyField);
			this.Name = "MainForm";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelStudyField;
		private System.Windows.Forms.Label labelGroup;
		private System.Windows.Forms.ComboBox comboFields;
		private System.Windows.Forms.ComboBox comboGroups;
		private System.Windows.Forms.Button btnReset;
	}
}

