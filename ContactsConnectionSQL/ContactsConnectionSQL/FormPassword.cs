using System;
using System.Windows.Forms;

namespace ContactsConnectionSQL
{
    public partial class FormPassword : Form
    {
        public int _id = 0;
        ContactsRepository repository;
        public FormPassword()
        {
            InitializeComponent();
            repository = new ContactsRepository();
        }

        private void FormPassword_Load(object sender, EventArgs e)
        {
            if (_id!=0)
            {
                this.btnEnter.Text = "تغییر";

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           // System.Windows.Forms.Application.ExitThread();
            this.Close();
        }
    }
}
