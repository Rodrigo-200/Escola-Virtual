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

        private void Admin_Panel_Load(object sender, EventArgs e)
        {
            if (Generic.StudentID < 1)
            {
                Generic.StudentID = 1;
                txt_StudentNumber.Text = "S" + Generic.StudentID.ToString().PadLeft(4, '0');
            }

            if (Generic.TeacherID < 1)
            {
                Generic.TeacherID = 1;
                txt_TeacherNumber.Text = "T" + Generic.TeacherID.ToString().PadLeft(4, '0');
            }




            foreach (var i in Generic._list_Of_School_Years)
            {
                TreeNode Ano = new TreeNode();
                Ano.Text = i.Get_Year.ToString() + "º ano";
                tvw_TeacherYearsAndSubjects.Nodes.Add(Ano);



                foreach (var it in i.Get_List_Of_Classes)
                {
                    TreeNode Class = new TreeNode();
                    Class.Text = it.Get_class_name;
                    Ano.Nodes.Add(Class);

                    foreach (var ite in it.Get_List_Of_Subject)
                    {
                        TreeNode Subject = new TreeNode();
                        Subject.Text = ite.Get_name;
                        Class.Nodes.Add(Subject);
                    }


                }

            }

            foreach (var it in Generic._list_Of_School_Years)
            {
                TreeNode Year = new TreeNode();
                Year.Text = it.Get_Year.ToString() + "º ano";
                tvw_Year_Class_Student.Nodes.Add(Year);



                foreach (var ite in it.Get_List_Of_Classes)
                {
                    TreeNode Class = new TreeNode();
                    Class.Text = ite.Get_class_name;
                    Year.Nodes.Add(Class);
                }
            }



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

        private void btn_TeacherConfirm_Click(object sender, EventArgs e)
        {
            Teachers teacher = new Teachers()
            {
                Set_Name = txt_TeacherName.Text,
                Set_Address = txt_TeacherAddress.Text,
                Set_Contact = txt_TeacherContact.Text,
                Set_TeacherID = txt_TeacherNumber.Text,
                Set_Password = txt_TeacherPassword.Text,
            };

            foreach (TreeNode g in tvw_TeacherYearsAndSubjects.Nodes)
            {
                string Year = g.Text.Split('º')[0];

                foreach (TreeNode u in g.Nodes)
                {
                    string Class = u.Text;

                    foreach (TreeNode i in u.Nodes)
                    {
                        School_Year school_Year = new School_Year();
                        Subject subject = new Subject();
                        Class turma = new Class();

                        school_Year =  Generic._list_Of_School_Years.Where(m => m.Get_Year == Convert.ToInt32(Year)).FirstOrDefault();
                        turma = school_Year.Get_List_Of_Classes.Where(m => m.Get_class_name == Class).FirstOrDefault();
                        subject = turma.Get_List_Of_Subject.Where(m => m.Get_name == i.Text).FirstOrDefault();


                        if (i.Checked == true)
                        {
                            teacher.Get_List_Of_Subjects_Teaching.Add(subject);
                        }

                    }
                }
            }

            Generic.TeacherID++;

            Generic._listOf_Teachers.Add(teacher);

            clearTeahcerControls();

        }

        private void btn_StudentConfirm_Click(object sender, EventArgs e)
        {
            Student student = new Student()
            {
                Set_Name = txt_StudentName.Text,
                Set_Address = txt_StudentAddress.Text,
                Set_Contact = txt_StudentContact.Text,
                Set_NIF = txt_StudentNIF.Text,
                Set_Password = txt_StudentPassword.Text,
                Set_StudentID = txt_StudentNumber.Text,
            };


            List<Student> students = new List<Student>();  

            students.Add(student);

            foreach(var year in Generic._list_Of_School_Years)
            {
                year.Get_List_Of_Classes.Where(m => m.Get_class_name == tvw_Year_Class_Student.SelectedNode.Text).ToList().FirstOrDefault().Set_List_Of_Student = students;
            }





            Generic.StudentID++;

            clearStudentControls();
        }

        private void chb_show_Password_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_show_Password.Checked)
            {
                chb_show_Password.ImageIndex = 0;
                txt_StudentPassword.PasswordChar = '\0';
            }
            else
            {
                chb_show_Password.ImageIndex = 1;
                txt_StudentPassword.PasswordChar = '*';
            }
        }

        private void chb_TeacherShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_TeacherShowPassword.Checked)
            {
                chb_TeacherShowPassword.ImageIndex = 0;
                txt_TeacherPassword.PasswordChar = '\0';
            }
            else
            {
                chb_TeacherShowPassword.ImageIndex = 1;
                txt_TeacherPassword.PasswordChar = '*';
            }
        }

        private void clearStudentControls()
        {
            txt_StudentNIF.Clear();
            txt_StudentName.Clear();
            txt_StudentAddress.Clear();
            txt_StudentContact.Clear();
            txt_StudentPassword.Clear();
            txt_StudentNumber.Text = "S" + Generic.StudentID.ToString().PadLeft(4, '0');
        }

        private void clearTeahcerControls()
        {
            txt_TeacherNIF.Clear();
            txt_TeacherName.Clear();
            txt_TeacherAddress.Clear();
            txt_TeacherContact.Clear();
            tvw_TeacherYearsAndSubjects.CheckBoxes=false;
            tvw_TeacherYearsAndSubjects.CheckBoxes = true;
            txt_TeacherNumber.Text = "T" + Generic.TeacherID.ToString().PadLeft(4, '0');

          
        }



        private void tvw_TeacherYearsAndSubjects_AfterCheck(object sender, TreeViewEventArgs e)
        {

            CheckChildren(e.Node, e.Node.Checked);

        }

        private void CheckChildren(TreeNode rootNode, bool isChecked)
        {
            foreach (TreeNode node in rootNode.Nodes)
            {
                CheckChildren(node, isChecked);
                node.Checked = isChecked;
            }
        }
    }
}
