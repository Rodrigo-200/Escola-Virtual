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
    public partial class Student_Panel : Form
    {
        public Student_Panel()
        {
            InitializeComponent();
        }

        private void Student_Panel_Load(object sender, EventArgs e)
        {

            txt_StudentAddress.Text = Generic.CurrentStudent.Get_Address;
            txt_StudentName.Text = Generic.CurrentStudent.Get_Name;
            txt_StudentContact.Text = Generic.CurrentStudent.Get_Contact;
            txt_StudentNIF.Text = Generic.CurrentStudent.Get_NIF;
            txt_StudentNumber.Text = Generic.CurrentStudent.Get_studentID;
            txt_StudentPassword.Text = Generic.CurrentStudent.Get_password;


            School_Year year = new School_Year();
            Class _class = new Class();
            year = Generic._list_Of_School_Years.FirstOrDefault(y => y.Get_List_Of_Classes.Any(c => c.Get_List_Of_Student.Any(s => s.Get_studentID == Generic.CurrentStudent.Get_studentID)));
            
            
            
            _class =year.Get_List_Of_Classes.Where(c => c.Get_class_name.ToString() == Generic.CurrentStudent.Get_ClassName).FirstOrDefault();

            foreach (var s in _class.Get_List_Of_Subject)
            {
                TreeNode subject = new TreeNode();
                subject.Text = s.Get_name;
                tvw_Grades.Nodes.Add(subject);
                foreach(var g in Generic.CurrentStudent.Get_List_Of_Grades)
                {
                    if(g.Get_subject.Get_name==subject.Text)
                    {
                        TreeNode grade = new TreeNode();
                        grade.Text = g.Get_Grade.ToString();
                        subject.Nodes.Add(grade);
                    }
                }
            }

        }

        private void tvw_Grades_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            txt_Student_Readonly();
        }

        private void txt_Student_Readonly()
        {
            if(btn_Submit.Enabled==false)
            {
                txt_StudentAddress.ReadOnly = false;
                txt_StudentName.ReadOnly = false;
                txt_StudentContact.ReadOnly = false;
                txt_StudentNIF.ReadOnly = false;
                txt_StudentPassword.ReadOnly = false;
                btn_edit.Enabled = false;
                btn_Submit.Enabled = true;
            }
            else
            {
                txt_StudentAddress.ReadOnly = true;
                txt_StudentName.ReadOnly = true;
                txt_StudentContact.ReadOnly = true;
                txt_StudentNIF.ReadOnly = true;
                txt_StudentPassword.ReadOnly = true;
                btn_edit.Enabled = true;
                btn_Submit.Enabled = false;

                //Só atribuir nas textboxes que tiveram texto alterado
                txt_StudentAddress.Text = Generic.CurrentStudent.Get_Address;
                txt_StudentName.Text = Generic.CurrentStudent.Get_Name;
                txt_StudentContact.Text = Generic.CurrentStudent.Get_Contact;
                txt_StudentNIF.Text = Generic.CurrentStudent.Get_NIF;
                txt_StudentNumber.Text = Generic.CurrentStudent.Get_studentID;
                txt_StudentPassword.Text = Generic.CurrentStudent.Get_password;
            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            txt_Student_Readonly();
        }
    }
}
