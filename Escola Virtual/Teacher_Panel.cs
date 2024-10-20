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
            //Verifica se a textbox txt_MsgContent nao contem texto If(true) modifica a propriedade "Visible" a true e mostra o PlaceHolder
            if (txt_MsgContent.Text == "")
            {
                lbl_PlaceHolder.Text = "Mensagem para " + cbb_SelectUserChat.Text.Split('-')[0];
                lbl_PlaceHolder.Visible = true;
            }

            //Verifica se o utilizador tem mensagens por ler e conta quantas são
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
                //Apresenta a message box com a quantidade de mensagens por ler do utilizador
                MessageBox.Show("Tem " + Num_New_Msg + " mensagens por ler!", "Escola Virtual", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //Limpa os items da ComboBox "cbb_SelectUserChat" para evitar repetição de items
            cbb_SelectUserChat.Items.Clear();

            /*
             * Serie de foreach encarregues por adicionar à ComboBox "cbb_SelectUserChat" todos os Utilizadores (Alunos e Professores)
             */
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

            //Ao carregar a página Atualiza no painel "Perfil" os dados do utilizador
            txt_TeacherAddress.Text = Generic.CurrentTeacher.Get_Address;
            txt_TeacherName.Text = Generic.CurrentTeacher.Get_Name;
            txt_TeacherContact.Text = Generic.CurrentTeacher.Get_Contact;
            txt_TeacherNIF.Text = Generic.CurrentTeacher.Get_NIF;
            txt_TeacherNumber.Text = Generic.CurrentTeacher.Get_TeacherID;
            txt_TeacherPassword.Text = Generic.CurrentTeacher.Get_password;

            /*
             * Atualiza a TreeView "tvw_GradeLaunch" com todos os alunos das suas disciplinas para lançar as notas
             */
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

        /// <summary>
        /// Metodo encarregue de mudar todas as TextBoxes entre não se poder escrever e poder (Verifica o estado do botão btn_Submit para mudar entre os 2 estados)
        /// </summary>
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
            /*
             * Serie de ifs que verificam quais os campos que o utilizador pretende modificar e adiciona essa mudança a Lista de mudanças Generic._list_Of_Changes
             */
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
            //Verifica se a nota que o professor é válida 
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

                if (_class.Get_List_Of_Student.Where(s => s.Get_studentID == tvw_GradeLaunch.SelectedNode.Text.Split('-')[1]).FirstOrDefault().Get_List_Of_Grades.Where(sb => sb.Get_subject == nota.Get_subject).Count() > 0) 
                {
                    MessageBox.Show("Já foi lançada uma nota para este aluno nesta disciplina", "Escola Virtual", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    _class.Get_List_Of_Student.Where(st => st.Get_studentID == tvw_GradeLaunch.SelectedNode.Text.Split('-')[1]).FirstOrDefault().Get_List_Of_Grades.Add(nota);
                    txt_GradeValue.Clear();
                    txt_GradeValue.Focus();
                }
            }
        }

        private void btn_SendMsg_Click(object sender, EventArgs e)
        {
            /*
             * Adiciona a mensagem a lista de "chats" contendo a origem, destinatario, a mensagem e define a mensagem como não vista (isRead = false)
             * Atualiza a ListBox lb_Chat
             */

            string mensagem = txt_MsgContent.Text;

            if (mensagem != "")
            {
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

                if (txt_MsgContent.Text == "")
                {
                    lbl_PlaceHolder.Text = "Mensagem para " + cbb_SelectUserChat.Text.Split('-')[0];
                    lbl_PlaceHolder.Visible = true;
                }
            }
        }

        private void cbb_SelectUserChat_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshChat();
            if (txt_MsgContent.Text == "")
            {
                lbl_PlaceHolder.Text = "Mensagem para " + cbb_SelectUserChat.Text.Split('-')[0];
                lbl_PlaceHolder.Visible = true;
            }
        }

        /// <summary>
        /// Atualiza a ListBox lb_Chat com as mensagens do utilizador como "Eu" e do destinatario como "Nome do destinatario" e atualiza a variavel isRead
        /// </summary>
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

        private void lbl_PlaceHolder_Click(object sender, EventArgs e)
        {
            //Atualiza a lbl_PLaceHolder para nao visivel uma vez que o utilizado quer escrever a mensagem e dá focus à textBox para o utilizador escrever a sua mensagem
            lbl_PlaceHolder.Visible = false;
            txt_MsgContent.Focus();
        }

        private void txt_MsgContent_Enter(object sender, EventArgs e)
        {
            //Atualiza a lbl_PLaceHolder para nao visivel uma vez que o utilizado quer escrever a mensagem
            lbl_PlaceHolder.Visible = false;
        }

        private void txt_MsgContent_Leave(object sender, EventArgs e)
        {
            //Atualiza a lbl_PLaceHolder para visivel uma vez que o utilizado já nao esta na TextBox txt_MsgContent
            if (txt_MsgContent.Text == "")
            {
                lbl_PlaceHolder.Text = "Mensagem para " + cbb_SelectUserChat.Text.Split('-')[0];
                lbl_PlaceHolder.Visible = true;
            }
        }
    }



}
