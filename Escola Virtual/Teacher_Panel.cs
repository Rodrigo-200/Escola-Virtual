using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
                tvw_GradeLaunch.Nodes.Add(year);


                foreach(var c in i.Get_List_Of_Classes)
                {
                    if(Generic.CurrentTeacher.Get_List_Of_Subjects_Teaching.Any(c.Get_List_Of_Subject.Contains))
                    {
                        TreeNode Class = new TreeNode();
                        Class.Text = c.Get_class_name;
                        year.Nodes.Add(Class);

                        foreach (var s in c.Get_List_Of_Subject)
                        {
                            TreeNode subject = new TreeNode();
                            subject.Text = s.Get_name;

                            if (Generic.CurrentTeacher.Get_List_Of_Subjects_Teaching.Contains(s))
                            {
                                Class.Nodes.Add(subject);

                                foreach(var st in c.Get_List_Of_Student)
                                {
                                    TreeNode student = new TreeNode();
                                    student.Text = st.Get_Name;
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

        }
    }
}
