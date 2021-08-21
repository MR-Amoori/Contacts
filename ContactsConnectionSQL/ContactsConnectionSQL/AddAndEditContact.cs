using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsConnectionSQL
{
	public partial class AddAndEditContact : Form
	{
		public int Contactsid = 0;
		IContactsRepository repository;
		public AddAndEditContact()
		{
			InitializeComponent();
			repository = new ContactsRepository();
		}

		private void AddAndEditContact_Load(object sender, EventArgs e)
		{
			if (Contactsid == 0)
			{
				this.Text = " افزودن شخص جدید ";
				txtName.ForeColor = Color.Red;
				txtName.Text = "ضروری*";
				txtFamily.ForeColor = Color.Red;
				txtFamily.Text = "ضروری*";
				txtNumberPhone.ForeColor = Color.Red;
				txtNumberPhone.Text = "ضروری*";

			}


			else
			{
				this.Text = " ویرایش کاربر ";
				txtName.Text = "";
				txtName.ForeColor = Color.Black;
				txtFamily.Text = "";
				txtFamily.ForeColor = Color.Black;
				txtNumberPhone.Text = "";
				txtNumberPhone.ForeColor = Color.Black;

				DataTable dt = repository.selectrow(Contactsid);
				txtName.Text = dt.Rows[0][1].ToString();
				txtFamily.Text = dt.Rows[0][2].ToString();
				txtNumberPhone.Text = dt.Rows[0][3].ToString();
				txtEmail.Text = dt.Rows[0][4].ToString();
				numAge.Value = (int)dt.Rows[0][5];
				txtAddress.Text = dt.Rows[0][6].ToString();

			}


		}

		bool ValidateInputs()
		{

			if (txtName.Text == "" || txtName.Text == "ضروری*")
			{
				MessageBox.Show("لطفا نام کاربر را وارد کنید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			if (txtFamily.Text == "" || txtFamily.Text == "ضروری*")
			{
				MessageBox.Show("لطفا نام خانوادگی کاربر را وارد کنید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			if (txtNumberPhone.Text == "" || txtNumberPhone.Text == "ضروری*")
			{
				MessageBox.Show("لطفا شماره تلفن کاربر را وارد کنید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			return true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (ValidateInputs())
			{
				bool isSoccess;

				if (Contactsid == 0)
				{
					 isSoccess = repository.insetr(txtName.Text, txtFamily.Text, txtNumberPhone.Text, txtEmail.Text, (int)numAge.Value, txtAddress.Text);

				}
				else
				{
					isSoccess = repository.update(Contactsid, txtName.Text, txtFamily.Text, txtNumberPhone.Text, txtEmail.Text, (int)numAge.Value, txtAddress.Text);
				}

				if (isSoccess == true)
				{
					MessageBox.Show("عملیات با موفقیت انجام شد", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
					DialogResult = DialogResult.OK;
				}

				else
				{
					MessageBox.Show(" ! ناموفق", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void txtName_Click(object sender, EventArgs e)
		{
			if (Contactsid == 0)
			{
				txtName.Text = "";
				txtName.ForeColor = Color.Black;
			}
		}

		private void txtNumberPhone_Click(object sender, EventArgs e)
		{
			if (Contactsid == 0)
			{

				txtNumberPhone.Text = "";
				txtNumberPhone.ForeColor = Color.Black;
			}
		}

		private void txtFamily_Click(object sender, EventArgs e)
		{
			if (Contactsid == 0)
			{
				txtFamily.Text = "";
				txtFamily.ForeColor = Color.Black;
			}
		}

		private void txtFamily_Enter(object sender, EventArgs e)
		{
			txtFamily.ForeColor = Color.Black;
		}

		private void txtNumberPhone_Enter(object sender, EventArgs e)
		{
			txtNumberPhone.ForeColor = Color.Black;
		}
	}
}
