namespace ContactsConnectionSQL
{
	partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSearchh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCoppy = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dgContacts = new System.Windows.Forms.DataGridView();
            this._ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.family = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNewContacts = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.تماسباماToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.سایتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.httpsmrx10irToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تلگرامToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shinlaglagiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اینستاگرامToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mrx10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.تلفنToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnThems = new System.Windows.Forms.ToolStripDropDownButton();
            this.رنگقرمزToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.قرمزToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.سبزToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.آبیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnChangePassword = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgContacts)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSearchh);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 73);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جستجو";
            // 
            // txtSearchh
            // 
            this.txtSearchh.Location = new System.Drawing.Point(48, 29);
            this.txtSearchh.Name = "txtSearchh";
            this.txtSearchh.Size = new System.Drawing.Size(589, 23);
            this.txtSearchh.TabIndex = 1;
            this.txtSearchh.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(643, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام کاربر: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnCoppy);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.dgContacts);
            this.groupBox2.Location = new System.Drawing.Point(12, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 443);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "لیست";
            // 
            // btnCoppy
            // 
            this.btnCoppy.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnCoppy.Location = new System.Drawing.Point(472, 414);
            this.btnCoppy.Name = "btnCoppy";
            this.btnCoppy.Size = new System.Drawing.Size(120, 23);
            this.btnCoppy.TabIndex = 3;
            this.btnCoppy.Text = "کپی شماره تلفن";
            this.btnCoppy.UseVisualStyleBackColor = true;
            this.btnCoppy.Click += new System.EventHandler(this.btnCoppy_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnDelete.Location = new System.Drawing.Point(598, 414);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Tahoma", 9F);
            this.btnEdit.Location = new System.Drawing.Point(679, 414);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dgContacts
            // 
            this.dgContacts.AllowUserToAddRows = false;
            this.dgContacts.AllowUserToDeleteRows = false;
            this.dgContacts.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.dgContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgContacts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._ID,
            this.name,
            this.family,
            this.numberphone,
            this.email,
            this.age,
            this.address});
            this.dgContacts.Location = new System.Drawing.Point(6, 22);
            this.dgContacts.Name = "dgContacts";
            this.dgContacts.ReadOnly = true;
            this.dgContacts.Size = new System.Drawing.Size(748, 386);
            this.dgContacts.TabIndex = 0;
            // 
            // _ID
            // 
            this._ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._ID.DataPropertyName = "_ID";
            this._ID.HeaderText = "کد شخص";
            this._ID.Name = "_ID";
            this._ID.ReadOnly = true;
            this._ID.Visible = false;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "نام";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 49;
            // 
            // family
            // 
            this.family.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.family.DataPropertyName = "family";
            this.family.HeaderText = "نام خانوادگی";
            this.family.Name = "family";
            this.family.ReadOnly = true;
            this.family.Width = 104;
            // 
            // numberphone
            // 
            this.numberphone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.numberphone.DataPropertyName = "numberphone";
            this.numberphone.HeaderText = "شماره تفن";
            this.numberphone.Name = "numberphone";
            this.numberphone.ReadOnly = true;
            this.numberphone.Width = 94;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "ایمیل";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 62;
            // 
            // age
            // 
            this.age.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.age.DataPropertyName = "age";
            this.age.HeaderText = "سن";
            this.age.Name = "age";
            this.age.ReadOnly = true;
            this.age.Width = 56;
            // 
            // address
            // 
            this.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.address.DataPropertyName = "addresss";
            this.address.HeaderText = "آدرس";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // btnNewContacts
            // 
            this.btnNewContacts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnNewContacts.Image = ((System.Drawing.Image)(resources.GetObject("btnNewContacts.Image")));
            this.btnNewContacts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewContacts.Name = "btnNewContacts";
            this.btnNewContacts.Size = new System.Drawing.Size(117, 22);
            this.btnNewContacts.Text = "افزودن شخص جدید";
            this.btnNewContacts.Click += new System.EventHandler(this.btnNewContacts_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnRefresh
            // 
            this.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(70, 22);
            this.btnRefresh.Text = "بروزرسانی";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.تماسباماToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(69, 22);
            this.toolStripSplitButton1.Text = "درباره ما";
            // 
            // تماسباماToolStripMenuItem
            // 
            this.تماسباماToolStripMenuItem.BackColor = System.Drawing.Color.LightBlue;
            this.تماسباماToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.سایتToolStripMenuItem,
            this.تلگرامToolStripMenuItem,
            this.اینستاگرامToolStripMenuItem,
            this.تلفنToolStripMenuItem});
            this.تماسباماToolStripMenuItem.Name = "تماسباماToolStripMenuItem";
            this.تماسباماToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.تماسباماToolStripMenuItem.Text = "تماس با ما";
            // 
            // سایتToolStripMenuItem
            // 
            this.سایتToolStripMenuItem.BackColor = System.Drawing.Color.LightBlue;
            this.سایتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.httpsmrx10irToolStripMenuItem});
            this.سایتToolStripMenuItem.Name = "سایتToolStripMenuItem";
            this.سایتToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.سایتToolStripMenuItem.Text = "سایت";
            // 
            // httpsmrx10irToolStripMenuItem
            // 
            this.httpsmrx10irToolStripMenuItem.BackColor = System.Drawing.Color.LightBlue;
            this.httpsmrx10irToolStripMenuItem.Name = "httpsmrx10irToolStripMenuItem";
            this.httpsmrx10irToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.httpsmrx10irToolStripMenuItem.Text = "www.mrx10.ir";
            this.httpsmrx10irToolStripMenuItem.Click += new System.EventHandler(this.httpsmrx10irToolStripMenuItem_Click);
            // 
            // تلگرامToolStripMenuItem
            // 
            this.تلگرامToolStripMenuItem.BackColor = System.Drawing.Color.LightBlue;
            this.تلگرامToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shinlaglagiToolStripMenuItem});
            this.تلگرامToolStripMenuItem.Name = "تلگرامToolStripMenuItem";
            this.تلگرامToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.تلگرامToolStripMenuItem.Text = "تلگرام";
            // 
            // shinlaglagiToolStripMenuItem
            // 
            this.shinlaglagiToolStripMenuItem.BackColor = System.Drawing.Color.LightBlue;
            this.shinlaglagiToolStripMenuItem.Name = "shinlaglagiToolStripMenuItem";
            this.shinlaglagiToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.shinlaglagiToolStripMenuItem.Text = "Shinlaglagi@";
            this.shinlaglagiToolStripMenuItem.Click += new System.EventHandler(this.shinlaglagiToolStripMenuItem_Click);
            // 
            // اینستاگرامToolStripMenuItem
            // 
            this.اینستاگرامToolStripMenuItem.BackColor = System.Drawing.Color.LightBlue;
            this.اینستاگرامToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mrx10ToolStripMenuItem});
            this.اینستاگرامToolStripMenuItem.Name = "اینستاگرامToolStripMenuItem";
            this.اینستاگرامToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.اینستاگرامToolStripMenuItem.Text = "اینستاگرام";
            // 
            // mrx10ToolStripMenuItem
            // 
            this.mrx10ToolStripMenuItem.BackColor = System.Drawing.Color.LightBlue;
            this.mrx10ToolStripMenuItem.Name = "mrx10ToolStripMenuItem";
            this.mrx10ToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.mrx10ToolStripMenuItem.Text = "m._r._x._10@";
            this.mrx10ToolStripMenuItem.Click += new System.EventHandler(this.mrx10ToolStripMenuItem_Click);
            // 
            // تلفنToolStripMenuItem
            // 
            this.تلفنToolStripMenuItem.BackColor = System.Drawing.Color.LightBlue;
            this.تلفنToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.تلفنToolStripMenuItem.Name = "تلفنToolStripMenuItem";
            this.تلفنToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.تلفنToolStripMenuItem.Text = "تلفن";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.LightBlue;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(153, 22);
            this.toolStripMenuItem2.Text = "09035170373";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.PowderBlue;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewContacts,
            this.toolStripSeparator1,
            this.btnRefresh,
            this.toolStripSeparator2,
            this.toolStripSplitButton1,
            this.toolStripSeparator3,
            this.btnThems,
            this.toolStripSeparator4,
            this.btnChangePassword});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnThems
            // 
            this.btnThems.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnThems.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.رنگقرمزToolStripMenuItem,
            this.قرمزToolStripMenuItem,
            this.سبزToolStripMenuItem,
            this.آبیToolStripMenuItem});
            this.btnThems.Image = ((System.Drawing.Image)(resources.GetObject("btnThems.Image")));
            this.btnThems.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThems.Name = "btnThems";
            this.btnThems.Size = new System.Drawing.Size(51, 22);
            this.btnThems.Text = "تم ها";
            // 
            // رنگقرمزToolStripMenuItem
            // 
            this.رنگقرمزToolStripMenuItem.BackColor = System.Drawing.Color.PowderBlue;
            this.رنگقرمزToolStripMenuItem.Name = "رنگقرمزToolStripMenuItem";
            this.رنگقرمزToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.رنگقرمزToolStripMenuItem.Text = "رنگ پیشفرض";
            this.رنگقرمزToolStripMenuItem.Click += new System.EventHandler(this.رنگقرمزToolStripMenuItem_Click);
            // 
            // قرمزToolStripMenuItem
            // 
            this.قرمزToolStripMenuItem.BackColor = System.Drawing.Color.Red;
            this.قرمزToolStripMenuItem.Name = "قرمزToolStripMenuItem";
            this.قرمزToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.قرمزToolStripMenuItem.Text = "قرمز";
            // 
            // سبزToolStripMenuItem
            // 
            this.سبزToolStripMenuItem.BackColor = System.Drawing.Color.LawnGreen;
            this.سبزToolStripMenuItem.Name = "سبزToolStripMenuItem";
            this.سبزToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.سبزToolStripMenuItem.Text = "سبز";
            // 
            // آبیToolStripMenuItem
            // 
            this.آبیToolStripMenuItem.BackColor = System.Drawing.Color.DodgerBlue;
            this.آبیToolStripMenuItem.Name = "آبیToolStripMenuItem";
            this.آبیToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.آبیToolStripMenuItem.Text = "آبی";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnChangePassword.Image = ((System.Drawing.Image)(resources.GetObject("btnChangePassword.Image")));
            this.btnChangePassword.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(86, 22);
            this.btnChangePassword.Text = "تغییر رمز عبور";
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  دفترچه تلفن";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgContacts)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView dgContacts;
		private System.Windows.Forms.DataGridViewTextBoxColumn _ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn name;
		private System.Windows.Forms.DataGridViewTextBoxColumn family;
		private System.Windows.Forms.DataGridViewTextBoxColumn numberphone;
		private System.Windows.Forms.DataGridViewTextBoxColumn email;
		private System.Windows.Forms.DataGridViewTextBoxColumn age;
		private System.Windows.Forms.DataGridViewTextBoxColumn address;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.ToolStripButton btnNewContacts;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton btnRefresh;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
		private System.Windows.Forms.ToolStripMenuItem تماسباماToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem سایتToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem httpsmrx10irToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem تلگرامToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem shinlaglagiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem اینستاگرامToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mrx10ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem تلفنToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.TextBox txtSearchh;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCoppy;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripDropDownButton btnThems;
        private System.Windows.Forms.ToolStripMenuItem رنگقرمزToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem قرمزToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem سبزToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem آبیToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnChangePassword;
    }
}

