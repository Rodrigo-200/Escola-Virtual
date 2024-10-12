﻿using System;
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

                

                foreach(var s in Generic.CurrentTeacher.Get_List_Of_Subjects_Teaching)
                {
                    Subject subject = new Subject();
                    Class turma = new Class();

                    turma = Generic._list_Of_School_Years.Get_List_Of_Classes.Where(m => m.Get_class_name == Class).FirstOrDefault();
                    subject = turma.Get_List_Of_Subject.Where(m => m.Get_name == i.Text).FirstOrDefault();
                }

                


                foreach (var it in Generic._list_Of_School_Years.Where(y => y.Get_List_Of_Classes.Where(c => )))
                {
                    TreeNode Class = new TreeNode();
                    Class.Text = it.Get_name;
                    Ano.Nodes.Add(Class);


                    foreach (var ite in it.)
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
