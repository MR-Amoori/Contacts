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
	public partial class Form1 : Form
	{
		IContactsRepository repository;
		public Form1()
		{
			InitializeComponent();
			repository = new ContactsRepository();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			FormPassword frm = new FormPassword();
			frm.ShowDialog();
			if (frm.DialogResult == DialogResult.OK)
			{
				selectAll();
			}
			else
			{
				Application.Exit();
			}
		}

		private void selectAll()
		{
			dgContacts.AutoGenerateColumns = false;
			dgContacts.DataSource = repository.selectall();
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			selectAll();
		}

		private void btnNewContacts_Click(object sender, EventArgs e)
		{
			AddAndEditContact FormAdd = new AddAndEditContact();
			FormAdd.ShowDialog();
			if (FormAdd.DialogResult == DialogResult.OK)
			{
				selectAll();
			}
		}

		private void mrx10ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://www.instagram.com/m._r._x._10/");
		}

		private void shinlaglagiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://t.me/shinlaglagi");
		}

		private void httpsmrx10irToolStripMenuItem_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://mrx10.ir");
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{

		}

		private void btnDelete_Click_1(object sender, EventArgs e)
		{
			string name = dgContacts.CurrentRow.Cells[1].Value.ToString();
			string family = dgContacts.CurrentRow.Cells[2].Value.ToString();
			string fullname=name+" "+family;

			if (dgContacts.CurrentRow != null)
			{
				 if(MessageBox.Show("آیا از حذف "+fullname+" مطمئن هستید؟","توجه",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
				 {
					 int id = (int)dgContacts.CurrentRow.Cells[0].Value;
					 repository.delete(id);
					 selectAll();
				 }
			}

			else
			{
				MessageBox.Show("لطفا یک شخص را از لیست انتخاب کنید","خطا",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			string name = dgContacts.CurrentRow.Cells[1].Value.ToString();
			string family = dgContacts.CurrentRow.Cells[2].Value.ToString();
			string fullname = name + " " + family;

			if (dgContacts.CurrentRow != null)
			{
				if (MessageBox.Show("آیا از ویرایش " + fullname + " مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
				{
					int _ID = (int)dgContacts.CurrentRow.Cells[0].Value;
					AddAndEditContact editcontactsform = new AddAndEditContact();
					editcontactsform.Contactsid = _ID;
					if(editcontactsform.ShowDialog()==DialogResult.OK)
					{
						selectAll();
					}
					
				}
			}

			else
			{
				MessageBox.Show("لطفا یک شخص را از لیست انتخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

			}
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			dgContacts.DataSource = repository.search(txtSearchh.Text);
		}

		private void btnCoppy_Click(object sender, EventArgs e)
		{
		string Coppy=dgContacts.CurrentRow.Cells[3].Value.ToString();
		string name = dgContacts.CurrentRow.Cells[1].Value.ToString();
		string family = dgContacts.CurrentRow.Cells[2].Value.ToString();
		string FullName = name + " " + family; 
			Clipboard.SetText(Coppy);
		MessageBox.Show(" شماره "+FullName+" کپی شد ","کپی",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}

        private void رنگقرمزToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            FormPassword frm = new FormPassword();
            frm._id = 1;
            frm.ShowDialog();
           
        }
    }
}
