namespace ContactsConnectionSQL
{
	partial class AddAndEditContact
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
			this.lblName = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtNumberPhone = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtFamily = new System.Windows.Forms.TextBox();
			this.numAge = new System.Windows.Forms.NumericUpDown();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numAge)).BeginInit();
			this.SuspendLayout();
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.ForeColor = System.Drawing.Color.DarkSlateBlue;
			this.lblName.Location = new System.Drawing.Point(438, 31);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(29, 16);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "نام:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
			this.label1.Location = new System.Drawing.Point(179, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(36, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "سن:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
			this.label2.Location = new System.Drawing.Point(179, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 16);
			this.label2.TabIndex = 0;
			this.label2.Text = "نام خانوادگی:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.ForeColor = System.Drawing.Color.DarkSlateBlue;
			this.label3.Location = new System.Drawing.Point(438, 59);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 16);
			this.label3.TabIndex = 0;
			this.label3.Text = "موبایل:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
			this.label4.Location = new System.Drawing.Point(438, 88);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(42, 16);
			this.label4.TabIndex = 0;
			this.label4.Text = "ایمیل:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.ForeColor = System.Drawing.Color.DarkSlateBlue;
			this.label5.Location = new System.Drawing.Point(438, 116);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(43, 16);
			this.label5.TabIndex = 0;
			this.label5.Text = "آدرس:";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.groupBox1.Controls.Add(this.txtAddress);
			this.groupBox1.Controls.Add(this.txtEmail);
			this.groupBox1.Controls.Add(this.txtNumberPhone);
			this.groupBox1.Controls.Add(this.txtName);
			this.groupBox1.Controls.Add(this.txtFamily);
			this.groupBox1.Controls.Add(this.numAge);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.lblName);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(491, 208);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "اطلاعات کاربر";
			// 
			// txtAddress
			// 
			this.txtAddress.BackColor = System.Drawing.Color.Gainsboro;
			this.txtAddress.Location = new System.Drawing.Point(18, 113);
			this.txtAddress.Multiline = true;
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(414, 79);
			this.txtAddress.TabIndex = 2;
			// 
			// txtEmail
			// 
			this.txtEmail.BackColor = System.Drawing.Color.Gainsboro;
			this.txtEmail.Location = new System.Drawing.Point(277, 85);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(155, 23);
			this.txtEmail.TabIndex = 2;
			// 
			// txtNumberPhone
			// 
			this.txtNumberPhone.BackColor = System.Drawing.Color.Gainsboro;
			this.txtNumberPhone.ForeColor = System.Drawing.Color.Red;
			this.txtNumberPhone.Location = new System.Drawing.Point(277, 56);
			this.txtNumberPhone.Name = "txtNumberPhone";
			this.txtNumberPhone.Size = new System.Drawing.Size(155, 23);
			this.txtNumberPhone.TabIndex = 2;
			this.txtNumberPhone.Click += new System.EventHandler(this.txtNumberPhone_Click);
			this.txtNumberPhone.Enter += new System.EventHandler(this.txtNumberPhone_Enter);
			// 
			// txtName
			// 
			this.txtName.BackColor = System.Drawing.Color.Gainsboro;
			this.txtName.ForeColor = System.Drawing.Color.Red;
			this.txtName.Location = new System.Drawing.Point(277, 28);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(155, 23);
			this.txtName.TabIndex = 2;
			this.txtName.Click += new System.EventHandler(this.txtName_Click);
			// 
			// txtFamily
			// 
			this.txtFamily.BackColor = System.Drawing.Color.Gainsboro;
			this.txtFamily.ForeColor = System.Drawing.Color.Red;
			this.txtFamily.Location = new System.Drawing.Point(18, 28);
			this.txtFamily.Name = "txtFamily";
			this.txtFamily.Size = new System.Drawing.Size(155, 23);
			this.txtFamily.TabIndex = 2;
			this.txtFamily.Click += new System.EventHandler(this.txtFamily_Click);
			this.txtFamily.Enter += new System.EventHandler(this.txtFamily_Enter);
			// 
			// numAge
			// 
			this.numAge.BackColor = System.Drawing.Color.Gainsboro;
			this.numAge.Location = new System.Drawing.Point(18, 57);
			this.numAge.Name = "numAge";
			this.numAge.Size = new System.Drawing.Size(155, 23);
			this.numAge.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.GreenYellow;
			this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.button1.Location = new System.Drawing.Point(428, 226);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "ثبت";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// AddAndEditContact
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkGray;
			this.ClientSize = new System.Drawing.Size(515, 253);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "AddAndEditContact";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Load += new System.EventHandler(this.AddAndEditContact_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numAge)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtNumberPhone;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtFamily;
		private System.Windows.Forms.NumericUpDown numAge;
		private System.Windows.Forms.Button button1;
	}
}