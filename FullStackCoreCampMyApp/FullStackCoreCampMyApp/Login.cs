using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FullStackCoreCampMyApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUserName.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                if (DataStore.AppUser.UserName == txtUserName.Text && DataStore.AppUser.Password == txtPassword.Text)
                {
                    Form form = new Form1();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Giriş bilgileriniz hatalı");
                }
            }
            else
            {
                MessageBox.Show("Giriş bilgileri boş bırakılamaz");
            }
        }
    }
}
