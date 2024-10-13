using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Escola_Virtual
{
    public partial class Teacher_Panel : Form
    {
        public Teacher_Panel()
        {
            InitializeComponent();
        }

        private void Teacher_Panel_Load(object sender, EventArgs e)
        {

            foreach (var i in Generic._list_Of_School_Years)
            {
                TreeNode year = new TreeNode();
                year.Text = i.Get_Year.ToString() + "º ano";
                year.Tag = i.Get_Year;
                tvw_GradeLaunch.Nodes.Add(year);


                foreach(var c in i.Get_List_Of_Classes)
                {
                    if(Generic.CurrentTeacher.Get_List_Of_Subjects_Teaching.Any(c.Get_List_Of_Subject.Contains))
                    {
                        TreeNode Class = new TreeNode();
                        Class.Text = c.Get_class_name;
                        Class.Tag = "Turma";
                        year.Nodes.Add(Class);

                        foreach (var s in c.Get_List_Of_Subject)
                        {
                            TreeNode subject = new TreeNode();
                            subject.Text = s.Get_name;
                            subject.Tag = "Disciplina";

                            if (Generic.CurrentTeacher.Get_List_Of_Subjects_Teaching.Contains(s))
                            {
                                Class.Nodes.Add(subject);

                                foreach(var st in c.Get_List_Of_Student)
                                {
                                    TreeNode student = new TreeNode();
                                    student.Text = st.Get_Name+"-"+st.Get_studentID;
                                    subject.Nodes.Add(student);
                                }
                            }

                        }
                        
                    }
                }


             

            }
        }

        private void btn_GradeLaunch_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(txt_GradeValue.Text)>20)
            {
                MessageBox.Show("Valor de nota inválido!", "Escola Virtual", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(tvw_GradeLaunch.SelectedNode.Parent.Tag.ToString()!="Disciplina"||tvw_GradeLaunch.SelectedNode == null)
                {
                MessageBox.Show("Não selecionou um aluno!", "Escola Virtual", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                //Procurar a turma a que o aluno pertence
                School_Year year = new School_Year();
                Class _class = new Class();
               year = Generic._list_Of_School_Years.Where(y => y.Get_Year.ToString() == tvw_GradeLaunch.SelectedNode.Parent.Parent.Parent.Tag.ToString()).FirstOrDefault();
                _class=year.Get_List_Of_Classes.Where(c => c.Get_class_name == tvw_GradeLaunch.SelectedNode.Parent.Parent.Text).FirstOrDefault();

                //Criação da nota
                Grade nota = new Grade();
                nota.Set_Grade = Convert.ToInt32(txt_GradeValue.Text);
                nota.Set_subject = _class.Get_List_Of_Subject.Where(s => s.Get_name == tvw_GradeLaunch.SelectedNode.Parent.Text).FirstOrDefault();

                _class.Get_List_Of_Student.Where(st => st.Get_studentID == tvw_GradeLaunch.SelectedNode.Text.Split('-')[1]).FirstOrDefault().Get_List_Of_Grades.Add(nota);
            }
            
        }

        private void txt_GradeValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {

            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
