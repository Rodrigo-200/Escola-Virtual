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
                TreeNode Ano = new TreeNode();
                Ano.Text = i.Get_Year.ToString() + "º ano";
                tvw_GradeLaunch.Nodes.Add(Ano);



                foreach (var it in Generic.CurrentTeacher.Get_List_Of_Subjects_Teaching)
                {
                    TreeNode Class = new TreeNode();
                    Class.Text = it.;
                    Ano.Nodes.Add(Class);

                    foreach (var ite in it.Get_List_Of_Subject)
                    {
                        TreeNode Subject = new TreeNode();
                        Subject.Text = ite.Get_name;
                        Class.Nodes.Add(Subject);
                    }


                }

            }
        }

        private void btn_GradeLaunch_Click(object sender, EventArgs e)
        {

        }
    }
}
