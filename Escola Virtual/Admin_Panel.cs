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

            refresh();

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

            if (txt_TeacherAddress.Text != "" && txt_TeacherContact.Text != "" && txt_TeacherName.Text != "" && txt_TeacherNIF.Text != "" && Teacher_Chosen_Subjects())
            {



                Teachers teacher = new Teachers()
                {
                    Set_Name = txt_TeacherName.Text,
                    Set_Address = txt_TeacherAddress.Text,
                    Set_NIF = txt_TeacherNIF.Text,
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

                            school_Year = Generic._list_Of_School_Years.Where(m => m.Get_Year == Convert.ToInt32(Year)).FirstOrDefault();
                            turma = school_Year.Get_List_Of_Classes.Where(m => m.Get_class_name == Class).FirstOrDefault();
                            subject = turma.Get_List_Of_Subject.Where(m => m.Get_name == i.Text).FirstOrDefault();
                            subject.Set_Teacherid = teacher;


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
            else
            {
                MessageBox.Show("Tem de preencher todos os campos!", "Escola Virtual", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_StudentConfirm_Click(object sender, EventArgs e)
        {
            if (txt_StudentAddress.Text != "" && txt_StudentContact.Text != "" && txt_StudentName.Text != "" && txt_StudentNIF.Text != "" && tvw_Year_Class_Student.SelectedNode != null)
            {
                Student student = new Student()
                {
                    Set_Name = txt_StudentName.Text,
                    Set_Address = txt_StudentAddress.Text,
                    Set_Contact = txt_StudentContact.Text,
                    Set_NIF = txt_StudentNIF.Text,
                    Set_Password = txt_StudentPassword.Text,
                    Set_StudentID = txt_StudentNumber.Text,
                    Set_ClassName = tvw_Year_Class_Student.SelectedNode.Text,
                };


                /*List<Student> students = new List<Student>();  



                students.Add(student);*/



                foreach (var year in Generic._list_Of_School_Years)
                {
                    if (year.Get_Year == Convert.ToInt32(tvw_Year_Class_Student.SelectedNode.Parent.Text.Split('º')[0]))
                    {
                        year.Get_List_Of_Classes.Where(m => m.Get_class_name == tvw_Year_Class_Student.SelectedNode.Text).ToList().FirstOrDefault().Get_List_Of_Student.Add(student);
                        break;
                    }
                }





                Generic.StudentID++;

                clearStudentControls();
            }
            else
            {
                MessageBox.Show("Tem de preencher todos os campos!", "Escola Virtual", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            txt_TeacherPassword.Clear();
            tvw_TeacherYearsAndSubjects.CheckBoxes = false;
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

        private bool Teacher_Chosen_Subjects()
        {

            foreach (TreeNode y in tvw_TeacherYearsAndSubjects.Nodes)
            {
                foreach (TreeNode c in y.Nodes)
                {
                    foreach (TreeNode s in c.Nodes)
                    {
                        if (s.Checked)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private void tc_Choices_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh();
        }



        private void refresh()
        {

            lb_ChangesRequests.Items.Clear();

            foreach (Change_Request change in Generic._list_Of_Changes)
            {
                int cnt = 0;
                

                foreach (string field in change.Get_List_Of_Fields_To_Change)
                {
                    string str = "O User " + change.Get_UserID + " deseja alterar " + field + " para " + change.Get_List_Of_Changes[cnt];
                    lb_ChangesRequests.Items.Add(str);
                    cnt++;
                }
            }

            tvw_CreateSubject.Nodes.Clear();
            tvw_TeacherYearsAndSubjects.Nodes.Clear();
            tvw_Year_Class_Student.Nodes.Clear();
            tvw_AdminCreateClass.Nodes.Clear();
            cbb_ChooseSchoolYear.Items.Clear();

            if (Generic.StudentID < 1)
            {
                Generic.StudentID = 1;
                txt_StudentNumber.Text = "S" + Generic.StudentID.ToString().PadLeft(4, '0');
            }
            else
            {
                txt_StudentNumber.Text = "S" + Generic.StudentID.ToString().PadLeft(4, '0');
            }

            if (Generic.TeacherID < 1)
            {
                Generic.TeacherID = 1;
                txt_TeacherNumber.Text = "T" + Generic.TeacherID.ToString().PadLeft(4, '0');
            }
            else
            {
                txt_TeacherNumber.Text = "T" + Generic.TeacherID.ToString().PadLeft(4, '0');
            }

            foreach (var i in Generic._list_Of_School_Years)
            {
                TreeNode Ano = new TreeNode();
                Ano.Text = i.Get_Year.ToString() + "º ano";
                tvw_AdminCreateClass.Nodes.Add(Ano);



                foreach (var it in i.Get_List_Of_Classes)
                {
                    TreeNode Class = new TreeNode();
                    Class.Text = it.Get_class_name;
                    Ano.Nodes.Add(Class);

                }

            }


            foreach (var i in Generic._list_Of_School_Years)
            {
                TreeNode Ano = new TreeNode();
                Ano.Text = i.Get_Year.ToString() + "º ano";
                tvw_CreateSubject.Nodes.Add(Ano);



                foreach (var it in i.Get_List_Of_Classes)
                {
                    TreeNode Class = new TreeNode();
                    Class.Text = it.Get_class_name;
                    Ano.Nodes.Add(Class);

                }

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


            foreach (var item in Generic._list_Of_School_Years)
            {
                cbb_ChooseSchoolYear.Items.Add(item.Get_Year + "º ano");
            }
        }

        private void tc_AdminCreateThings_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh();
        }

        #region "Outros"
        private void btn_CreateSchoolYear_Click(object sender, EventArgs e)
        {
            //VERIFICAR SE O ANO A CRIAR JA EXISTE

            if (txt_CreateSchoolYear.Text != "")
            {
                School_Year school_Year = new School_Year()
                {
                    Set_Year = Convert.ToInt32(txt_CreateSchoolYear.Text),
                };

                Generic._list_Of_School_Years.Add(school_Year);

                refresh();
                refreshClassLabelErrors();
                txt_CreateSchoolYear.Clear();
            }
            else
            {
                refreshClassLabelErrors();
                lbl_CreateSchoolYearError.Text = "Tem de preencher este campo";
            }
        }

        private void btn_CreateClass_Click(object sender, EventArgs e)
        {
            //VERIFICAR SE A TURMA A CRIAR JÁ EXISTE

            if (txt_ClassName.Text != "" && txt_ClassAcronym.Text != "" && cbb_ChooseSchoolYear.SelectedItem != null)
            {
                School_Year school_Year = new School_Year();
                school_Year = Generic._list_Of_School_Years.Where(m => m.Get_Year.ToString() == cbb_ChooseSchoolYear.SelectedItem.ToString().Split('º')[0]).FirstOrDefault();

                Class newclass = new Class()
                {
                    Set_class_name = txt_ClassName.Text,
                    Set_class_acronym = txt_ClassAcronym.Text,
                    Set_school_year = school_Year.Get_Year,
                };

                school_Year.Get_List_Of_Classes.Add(newclass);

                refresh();
                refreshClassLabelErrors();
                clearNewClassInputs();
            }
            else
            {
                refreshClassLabelErrors();
                if (txt_ClassName.Text == "")
                {
                    lbl_ClassNameError.Text = "Tem de preencher este campo";
                    txt_ClassName.Focus();
                }
                if(txt_ClassAcronym.Text == "")
                {
                    lbl_ClassAcronymError.Text = "Tem de preencher este campo";
                    txt_ClassAcronym.Focus();
                }
                if(cbb_ChooseSchoolYear.SelectedItem == null)
                {
                    lbl_ChooseYearError.Text = "Tem de escolher uma opção";
                    cbb_ChooseSchoolYear.Focus();
                }
            }

        }

        private void btn_CreateSubject_Click(object sender, EventArgs e)
        {
            //VERIFICAR SE A DISCIPLINA A CRIAR JÁ EXISTE

            if (txt_SubjectName.Text != "" && txt_SubjectAcronym.Text != "" && txt_SubjectAmmountOfClasses.Text != "" && tvw_CreateSubject.SelectedNode != null)
            {
                Subject subject = new Subject()
                {
                    Set_name = txt_SubjectName.Text,
                    Set_subject_acronym = txt_SubjectAcronym.Text,
                    Set_subject_number = Convert.ToInt32(txt_SubjectAmmountOfClasses.Text),
                };


                foreach (var year in Generic._list_Of_School_Years)
                {
                    if (year.Get_Year == Convert.ToInt32(tvw_CreateSubject.SelectedNode.Parent.Text.Split('º')[0]))
                    {

                        year.Get_List_Of_Classes.Where(m => m.Get_class_name == tvw_CreateSubject.SelectedNode.Text).ToList().FirstOrDefault().Get_List_Of_Subject.Add(subject);
                        break;
                    }
                }
                refreshSubjectLabelErrors();
                clearNewSubjectInputs();
                refresh();
            }
            else
            {
                refreshSubjectLabelErrors();
                if (txt_SubjectName.Text == "")
                {
                    lbl_SubjectNameError.Text = "Tem de preencher este campo";
                    txt_SubjectName.Focus();
                }
                if(txt_SubjectAcronym.Text == "")
                {
                    lbl_SubjectAcronymError.Text = "Tem de preencher este campo";
                    txt_SubjectAcronym.Focus();
                }
                if(txt_SubjectAmmountOfClasses.Text == "")
                {
                    lbl_AmmountOfClassesError.Text = "Tem de preencher este campo";
                    txt_SubjectAmmountOfClasses.Focus();
                }
                if(tvw_CreateSubject.SelectedNode == null)
                {
                    lbl_ChooseClassToCreateSubjectError.Text = "Tem de preencher este campo";
                    tvw_CreateSubject.Focus();
                }
            }


        }


        private void clearNewClassInputs()
        {
            txt_ClassAcronym.Clear();
            txt_ClassName.Clear();
        }

        private void clearNewSubjectInputs()
        {
            txt_SubjectAcronym.Clear();
            txt_SubjectName.Clear();
            txt_SubjectAmmountOfClasses.Clear();
        }
        private void refreshClassLabelErrors()
        {
            lbl_CreateSchoolYearError.Text = "";
            lbl_ChooseYearError.Text = "";
            lbl_ClassAcronymError.Text = "";
            lbl_ClassNameError.Text = "";
        }

        private void refreshSubjectLabelErrors()
        {
            lbl_SubjectNameError.Text = "";
            lbl_SubjectAcronymError.Text = "";
            lbl_ChooseClassToCreateSubjectError.Text = "";
            lbl_AmmountOfClassesError.Text = "";
        }



        #endregion

        private void btn_Aprove_Click(object sender, EventArgs e)
        {
            btn_Aprove.Enabled = false;
            btn_Deny.Enabled = false;


        }

        private void lb_ChangesRequests_SelectedValueChanged(object sender, EventArgs e)
        {
            if (lb_ChangesRequests.SelectedItem != null)
            {

                btn_Aprove.Enabled = true;
                btn_Deny.Enabled = true;
            }
            else
            { 
                btn_Aprove.Enabled = false;
                btn_Deny.Enabled = false;
            }
        }
    }


}
