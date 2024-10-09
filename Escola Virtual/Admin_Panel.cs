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
    public partial class Admin_Panel : Form
    {
        public Admin_Panel()
        {
            InitializeComponent();
        }

        private void txt_TeacherName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_TeacherContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_TeacherNIF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_StudentName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_StudentContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {

            }
            else
            {
                e.Handled = true;
            }
        }

        private void txt_StudentNIF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {

            }
            else
            {
                e.Handled = true;
            }
        }
        private void Admin_Panel_Load(object sender, EventArgs e)
        {

            School_Year Years = new School_Year();
            Years = Generic._list_Of_School_Years.Where(m => m.Get_Year == Years.Get_Year).FirstOrDefault();


            foreach (var i in Generic._list_Of_School_Years)
            {
                TreeNode Ano = new TreeNode();
                Ano.Text = i.Get_Year.ToString() + "º ano";
                tvw_TeacherYearsAndSubjects.Nodes.Add(Ano);



                foreach (var it in i.Get_List_Of_Classes)
                {
                    TreeNode Turma = new TreeNode();
                    Turma.Text = it.Get_class_name;
                    Ano.Nodes.Add(Turma);
                }
            }



        }

        private void btn_TeacherConfirm_Click(object sender, EventArgs e)
        {
            foreach (TreeNode i in tvw_TeacherYearsAndSubjects.Nodes)
            {
                if (i.Parent == null && i.Checked == true)
                {

                }
            }

            Teachers teacher = new Teachers()
            {
                Set_Name = txt_TeacherName.Text,
                Set_Address = txt_TeacherAddress.Text,
                Set_Contact = txt_TeacherContact.Text,

                //Set_List_Of_School_Years_Teaching;
            };

            foreach (TreeNode i in tvw_TeacherYearsAndSubjects.Nodes)
            {
                if (i.Parent == null && i.Checked == true)
                {
                    teacher.Set_List_Of_School_Years_Teaching.Add(i.Text);
                }
            }
        }
    }
}
