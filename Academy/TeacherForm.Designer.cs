namespace Academy
{
	partial class TeacherForm
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
			this.dtpWorkSince = new System.Windows.Forms.DateTimePicker();
			this.tbRate = new System.Windows.Forms.TextBox();
			this.labelWorkSience = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
			this.SuspendLayout();
			// 
			// dtpWorkSince
			// 
			this.dtpWorkSince.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dtpWorkSince.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpWorkSince.Location = new System.Drawing.Point(232, 274);
			this.dtpWorkSince.Name = "dtpWorkSince";
			this.dtpWorkSince.Size = new System.Drawing.Size(315, 31);
			this.dtpWorkSince.TabIndex = 18;
			// 
			// tbRate
			// 
			this.tbRate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.tbRate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
			this.tbRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbRate.Location = new System.Drawing.Point(232, 326);
			this.tbRate.Name = "tbRate";
			this.tbRate.Size = new System.Drawing.Size(100, 31);
			this.tbRate.TabIndex = 19;
			// 
			// labelWorkSience
			// 
			this.labelWorkSience.AutoSize = true;
			this.labelWorkSience.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelWorkSience.Location = new System.Drawing.Point(119, 279);
			this.labelWorkSience.Name = "labelWorkSience";
			this.labelWorkSience.Size = new System.Drawing.Size(107, 25);
			this.labelWorkSience.TabIndex = 20;
			this.labelWorkSience.Text = "Работа с:";
			this.labelWorkSience.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(55, 329);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(171, 25);
			this.label2.TabIndex = 21;
			this.label2.Text = "Ставка за пару:";
			// 
			// TeacherForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(847, 430);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.labelWorkSience);
			this.Controls.Add(this.tbRate);
			this.Controls.Add(this.dtpWorkSince);
			this.Name = "TeacherForm";
			this.Text = "TeacherForm";
			this.Load += new System.EventHandler(this.TeacherForm_Load);
			this.Controls.SetChildIndex(this.tbLastName, 0);
			this.Controls.SetChildIndex(this.tbFirstName, 0);
			this.Controls.SetChildIndex(this.tbMiddleName, 0);
			this.Controls.SetChildIndex(this.dtpBirthDate, 0);
			this.Controls.SetChildIndex(this.pbPhoto, 0);
			this.Controls.SetChildIndex(this.tbEmail, 0);
			this.Controls.SetChildIndex(this.tbPhone, 0);
			this.Controls.SetChildIndex(this.dtpWorkSince, 0);
			this.Controls.SetChildIndex(this.tbRate, 0);
			this.Controls.SetChildIndex(this.labelWorkSience, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dtpWorkSince;
		private System.Windows.Forms.TextBox tbRate;
		private System.Windows.Forms.Label labelWorkSience;
		private System.Windows.Forms.Label label2;
	}
}