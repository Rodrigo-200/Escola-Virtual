using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escola_Virtual
{
    public partial class Login : Form
    {

        Admin_Panel adminpanel = new Admin_Panel();
        public Login()
        {
            InitializeComponent();
        }

        private void chb_show_Password_CheckedChanged(object sender, EventArgs e)
        {

            if (chb_show_Password.Checked)
            {
                chb_show_Password.ImageIndex = 0;
                txt_password.PasswordChar = '\0';
            }
            else
            {
                chb_show_Password.ImageIndex = 1;
                txt_password.PasswordChar = '*';
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            adminpanel = new Admin_Panel();
            adminpanel.FormClosed += onForm2Close;
            adminpanel.ShowDialog();
        }

        private void onForm2Close(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
        }
    }
}
