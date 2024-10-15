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
        Student_Panel studentpanel = new Student_Panel();
        Teacher_Panel teacherpanel = new Teacher_Panel();
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
            if (!txt_accnumber.Text.ToLower().Contains('a') && !txt_accnumber.Text.ToLower().Contains('s') && !txt_accnumber.Text.ToLower().Contains('t'))
            {
                lbl_LoginErrors.Text = "Dados de acesso inválidos";
            }
            else
            {
                if (txt_accnumber.Text.ToLower().Contains('a'))
                {
                    if (txt_accnumber.Text.ToLower() == "a0000" && txt_password.Text == "0000")
                    {
                        this.Visible = false;
                        adminpanel = new Admin_Panel();
                        adminpanel.FormClosed += onForm2Close;
                        adminpanel.ShowDialog();
                        clearControls();
                        return;
                    }
                    else
                    {
                        lbl_LoginErrors.Text = "Dados de acesso inválidos";
                    }
                }




                if (txt_accnumber.Text.ToLower().Contains('s'))
                {
                    bool exist = true;

                    foreach (var i in Generic._list_Of_School_Years)
                    {
                        foreach (var ite in i.Get_List_Of_Classes)
                        {
                            if (ite.Get_List_Of_Student.Where(m => m.Get_studentID.ToLower() == txt_accnumber.Text.ToLower() && m.Get_password == txt_password.Text).FirstOrDefault() != null)
                            {

                                Generic.CurrentStudent = ite.Get_List_Of_Student.Where(m => m.Get_studentID.ToLower() == txt_accnumber.Text.ToLower()).FirstOrDefault();
                                this.Visible = false;
                                studentpanel = new Student_Panel();
                                studentpanel.FormClosed += onForm2Close;
                                studentpanel.ShowDialog();
                                clearControls();
                                return;

                            }
                            else
                            {
                                exist = false;
                            }
                        }

                    }

                    if (exist == false)
                    {
                        lbl_LoginErrors.Text = "Dados de acesso inválidos";
                    }
                }

                if (txt_accnumber.Text.ToLower().Contains('t'))
                {


                    if (Generic._listOf_Teachers.Where(m => m.Get_TeacherID.ToLower() == txt_accnumber.Text.ToLower() && m.Get_password == txt_password.Text).FirstOrDefault() != null)
                    {

                        Generic.CurrentTeacher = Generic._listOf_Teachers.Where(m => m.Get_TeacherID.ToLower() == txt_accnumber.Text.ToLower()).FirstOrDefault();
                        this.Visible = false;
                        teacherpanel = new Teacher_Panel();
                        teacherpanel.FormClosed += onForm2Close;
                        teacherpanel.ShowDialog();
                        clearControls();
                        return;

                    }
                    else
                    {
                        lbl_LoginErrors.Text = "Dados de acesso inválidos";
                    }

                }
            }


        }

        private void onForm2Close(object sender, FormClosedEventArgs e)
        {
            this.Visible = true;
        }

        private void clearControls()
        {
            txt_accnumber.Clear();
            txt_password.Clear();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

    }
}
