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
            int Num_New_Msg = 0;
            foreach (var chat in Generic._List_Of_Chats)
            {
                if (chat.Get_destinatary == Generic.CurrentTeacher.Get_TeacherID && chat.Get_isRead == false)
                {
                    Num_New_Msg++;
                }
            }
            if (Num_New_Msg > 0)
            {
                MessageBox.Show("Tem " + Num_New_Msg + " mensagens por ler!", "Escola Virtual", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            cbb_SelectUserChat.Items.Clear();

            foreach (var item in Generic._listOf_Teachers)
            {
                cbb_SelectUserChat.Items.Add(item.Get_Name + "-" + item.Get_TeacherID);
            }

            foreach (var item in Generic._list_Of_School_Years)
            {
                foreach (var item2 in item.Get_List_Of_Classes)
                {
                    foreach (var item3 in item2.Get_List_Of_Student)
                    {
                        cbb_SelectUserChat.Items.Add(item3.Get_Name + "-" + item3.Get_studentID);
                    }
                }
            }

            txt_TeacherAddress.Text = Generic.CurrentTeacher.Get_Address;
            txt_TeacherName.Text = Generic.CurrentTeacher.Get_Name;
            txt_TeacherContact.Text = Generic.CurrentTeacher.Get_Contact;
            txt_TeacherNIF.Text = Generic.CurrentTeacher.Get_NIF;
            txt_TeacherNumber.Text = Generic.CurrentTeacher.Get_TeacherID;
            txt_TeacherPassword.Text = Generic.CurrentTeacher.Get_password;

            List<School_Year> Year = new List<School_Year>();
            Year = Generic._list_Of_School_Years.Where(y => y.Get_List_Of_Classes.Any(c => c.Get_List_Of_Subject.Any(s => s.Get_Teacherid == Generic.CurrentTeacher.Get_TeacherID))).ToList();
            
            foreach (var i in Year)
            {
                TreeNode year = new TreeNode();
                year.Text = i.Get_Year.ToString() + "º ano";
                year.Tag = i.Get_Year;
                tvw_GradeLaunch.Nodes.Add(year);

                List<Class> classes = new List<Class>();
                classes = i.Get_List_Of_Classes.Where(c => c.Get_List_Of_Subject.Any(s => s.Get_Teacherid == Generic.CurrentTeacher.Get_TeacherID)).ToList();

                foreach (var c in classes)
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

                            if (Generic.CurrentTeacher.Get_TeacherID==s.Get_Teacherid)
                            {
                                Class.Nodes.Add(subject);

                                foreach (var st in c.Get_List_Of_Student)
                                {
                                    TreeNode student = new TreeNode();
                                    student.Text = st.Get_Name + "-" + st.Get_studentID;
                                    subject.Nodes.Add(student);
                                }
                            }

                        }


                    
                }




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

        private void btn_TeacherEdit_Click(object sender, EventArgs e)
        {
            txt_Teacher_Readonly();
        }

        private void txt_Teacher_Readonly()
        {
            if (btn_TeacherSubmit.Enabled == false)
            {
                txt_TeacherAddress.ReadOnly = false;
                txt_TeacherContact.ReadOnly = false;
                txt_TeacherName.ReadOnly = false;
                txt_TeacherNIF.ReadOnly = false;
                txt_TeacherPassword.ReadOnly = false;
                btn_TeacherEdit.Enabled = false;
                btn_TeacherSubmit.Enabled = true;
            }
            else
            {
                txt_TeacherAddress.ReadOnly = true;
                txt_TeacherContact.ReadOnly = true;
                txt_TeacherName.ReadOnly = true;
                txt_TeacherNIF.ReadOnly = true;
                txt_TeacherPassword.ReadOnly = true;
                btn_TeacherEdit.Enabled = true;
                btn_TeacherSubmit.Enabled = false;

            }
        }

        private void btn_TeacherSubmit_Click(object sender, EventArgs e)
        {

            if (txt_TeacherAddress.Text != Generic.CurrentTeacher.Get_Address)
            {
                Change_Request Alteration = new Change_Request();
                Alteration.Set_UserID = Generic.CurrentTeacher.Get_TeacherID;
                Alteration.Set_Message="O User " + Generic.CurrentTeacher.Get_TeacherID + " deseja alterar a morada para " + txt_TeacherAddress.Text;
                Alteration.Set_Name_Of_Field = "morada";
                Alteration.Set_New_Content = txt_TeacherAddress.Text;
                txt_TeacherAddress.Text = Generic.CurrentTeacher.Get_Address;
                Generic._list_Of_Changes.Add(Alteration);
            }
            if (txt_TeacherName.Text != Generic.CurrentTeacher.Get_Name)
            {
                Change_Request Alteration = new Change_Request();
                Alteration.Set_UserID = Generic.CurrentTeacher.Get_TeacherID;
                Alteration.Set_Message = "O User " + Generic.CurrentTeacher.Get_TeacherID + " deseja alterar o nome para " + txt_TeacherName.Text;
                Alteration.Set_New_Content=txt_TeacherName.Text;
                Alteration.Set_Name_Of_Field = "nome";
                txt_TeacherName.Text = Generic.CurrentTeacher.Get_Name;
                Generic._list_Of_Changes.Add(Alteration);
            }
            if (txt_TeacherContact.Text != Generic.CurrentTeacher.Get_Contact)
            {
                Change_Request Alteration = new Change_Request();
                Alteration.Set_UserID = Generic.CurrentTeacher.Get_TeacherID;
                Alteration.Set_Message="O User " + Generic.CurrentTeacher.Get_TeacherID + " deseja alterar o contacto para " + txt_TeacherContact.Text;
                Alteration.Set_New_Content=txt_TeacherContact.Text;
                Alteration.Set_Name_Of_Field= "contacto";  
                txt_TeacherContact.Text = Generic.CurrentTeacher.Get_Contact;
                Generic._list_Of_Changes.Add(Alteration);

            }
            if (txt_TeacherNIF.Text != Generic.CurrentTeacher.Get_NIF)
            {
                Change_Request Alteration = new Change_Request();
                Alteration.Set_UserID = Generic.CurrentTeacher.Get_TeacherID;
                Alteration.Set_Message = "O User " + Generic.CurrentTeacher.Get_TeacherID + " deseja alterar o NIF para " + txt_TeacherNIF.Text;
                Alteration.Set_New_Content = txt_TeacherNIF.Text;
                Alteration.Set_Name_Of_Field = "NIF";
                txt_TeacherContact.Text = Generic.CurrentTeacher.Get_NIF;
                Generic._list_Of_Changes.Add(Alteration);
            }
            if (txt_TeacherPassword.Text != Generic.CurrentTeacher.Get_password)
            {
                Change_Request Alteration = new Change_Request();
                Alteration.Set_UserID = Generic.CurrentTeacher.Get_TeacherID;
                Alteration.Set_Message = "O User " + Generic.CurrentTeacher.Get_TeacherID + " deseja alterar a password para " + txt_TeacherPassword.Text;
                Alteration.Set_New_Content = txt_TeacherPassword.Text;
                Alteration.Set_Name_Of_Field = "password";
                txt_TeacherContact.Text = Generic.CurrentTeacher.Get_password;
                Generic._list_Of_Changes.Add(Alteration);
            }

            txt_Teacher_Readonly();
        }

        private void btn_GradeLaunch_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txt_GradeValue.Text) > 20 || Convert.ToInt32(txt_GradeValue.Text) < 0)
            {
                MessageBox.Show("Valor de nota inválido!", "Escola Virtual", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tvw_GradeLaunch.SelectedNode.Parent.Tag.ToString() != "Disciplina" || tvw_GradeLaunch.SelectedNode == null)
            {
                MessageBox.Show("Não selecionou um aluno!", "Escola Virtual", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                //Procurar a turma a que o aluno pertence
                School_Year year = new School_Year();
                Class _class = new Class();
                year = Generic._list_Of_School_Years.Where(y => y.Get_Year.ToString() == tvw_GradeLaunch.SelectedNode.Parent.Parent.Parent.Tag.ToString()).FirstOrDefault();
                _class = year.Get_List_Of_Classes.Where(c => c.Get_class_name == tvw_GradeLaunch.SelectedNode.Parent.Parent.Text).FirstOrDefault();

                //Criação da nota
                Grade nota = new Grade();
                nota.Set_Grade = Convert.ToInt32(txt_GradeValue.Text);
                nota.Set_subject = _class.Get_List_Of_Subject.Where(s => s.Get_name == tvw_GradeLaunch.SelectedNode.Parent.Text).FirstOrDefault();

                _class.Get_List_Of_Student.Where(st => st.Get_studentID == tvw_GradeLaunch.SelectedNode.Text.Split('-')[1]).FirstOrDefault().Get_List_Of_Grades.Add(nota);
                txt_GradeValue.Clear();
                txt_GradeValue.Focus();
            }
        }

        private void btn_SendMsg_Click(object sender, EventArgs e)
        {
            string mensagem = txt_MsgContent.Text;

            Chat NewChatMsg = new Chat()
            {
                Set_isRead = false,
                Set_destinatary = cbb_SelectUserChat.SelectedItem.ToString().Trim().Split('-')[1],
                Set_origin = Generic.CurrentTeacher.Get_TeacherID,
                Set_Message = mensagem,
            };

            Generic._List_Of_Chats.Add(NewChatMsg);

            refreshChat();
            txt_MsgContent.Clear();
            txt_MsgContent.Focus();
        }

        private void cbb_SelectUserChat_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshChat();
        }
        private void refreshChat()
        {
            lb_Chat.Items.Clear();
            foreach (var item in Generic._List_Of_Chats)
            {

                if (item.Get_origin == Generic.CurrentTeacher.Get_TeacherID && item.Get_destinatary == cbb_SelectUserChat.SelectedItem.ToString().Trim().Split('-')[1])
                {
                    lb_Chat.Items.Add("Eu: " + item.Get_Message);
                }

                if (item.Get_destinatary == Generic.CurrentTeacher.Get_TeacherID && item.Get_origin == cbb_SelectUserChat.SelectedItem.ToString().Trim().Split('-')[1])
                {
                    lb_Chat.Items.Add(cbb_SelectUserChat.SelectedItem.ToString().Trim().Split('-')[0] + ": " + item.Get_Message);
                    item.Set_isRead = true;
                }


            }
        }
    }



}
