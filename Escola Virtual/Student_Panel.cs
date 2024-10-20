using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
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

            //Verifica se a textbox txt_MsgContent nao contem texto If(true) modifica a propriedade "Visible" a true e mostra o PlaceHolder
            if (txt_MsgContent.Text == "")
            {
                lbl_PlaceHolder.Text = "Mensagem para " + cbb_SelectUserChat.Text.Split('-')[0];
                lbl_PlaceHolder.Visible = true;
            }

            //Verifica se o utilizador tem mensagens por ler e conta quantas são
            int Num_New_Msg=0;
            foreach(var chat in Generic._List_Of_Chats)
            {
                if(chat.Get_destinatary==Generic.CurrentStudent.Get_studentID&&chat.Get_isRead==false)
                {
                    Num_New_Msg++; 
                }
            }
            if (Num_New_Msg > 0)
            {
                //Apresenta a message box com a quantidade de mensagens por ler do utilizador
                MessageBox.Show("Tem " + Num_New_Msg + " mensagens por ler!", "Escola Virtual", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //Mostra o saldo atual do utilizador ao carregar o form "Student"
            lbl_ShowBalance.Text = "Saldo: " + Generic.CurrentStudent.Get_saldo.ToString();

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


            //Limpa os items da LisBox "lb_History"  para evitar repetições de items
            lb_History.Items.Clear();

            //Adiciona o Historico do cartão do aluno a ListBox "lb_History"
            lb_History.Items.AddRange(Generic.CurrentStudent.Get_History.ToArray());

            //Ao carregar a página Atualiza no painel "Perfil" os dados do utilizador
            txt_StudentAddress.Text = Generic.CurrentStudent.Get_Address;
            txt_StudentName.Text = Generic.CurrentStudent.Get_Name;
            txt_StudentContact.Text = Generic.CurrentStudent.Get_Contact;
            txt_StudentNIF.Text = Generic.CurrentStudent.Get_NIF;
            txt_StudentNumber.Text = Generic.CurrentStudent.Get_studentID;
            txt_StudentPassword.Text = Generic.CurrentStudent.Get_password;

            /*
             * Atualiza a TreeView "tvw_Grades" com todas as notas do Aluno organizadas pela disciplina correspondente
             */

            School_Year year = new School_Year();
            Class _class = new Class();
            year = Generic._list_Of_School_Years.FirstOrDefault(y => y.Get_List_Of_Classes.Any(c => c.Get_List_Of_Student.Any(s => s.Get_studentID == Generic.CurrentStudent.Get_studentID)));
            _class = year.Get_List_Of_Classes.Where(c => c.Get_class_name.ToString() == Generic.CurrentStudent.Get_ClassName).FirstOrDefault();

            foreach (var s in _class.Get_List_Of_Subject)
            {
                TreeNode subject = new TreeNode();
                subject.Text = s.Get_name;
                tvw_Grades.Nodes.Add(subject);
                foreach (var g in Generic.CurrentStudent.Get_List_Of_Grades)
                {
                    if (g.Get_subject.Get_name == subject.Text)
                    {
                        TreeNode grade = new TreeNode();
                        grade.Text = g.Get_Grade.ToString();
                        subject.Nodes.Add(grade);
                    }
                }
            }

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            txt_Student_Readonly();
        }

        /// <summary>
        /// Metodo encarregue de mudar todas as TextBoxes entre não se poder escrever e poder (Verifica o estado do botão btn_Submit para mudar entre os 2 estados)
        /// </summary>
        private void txt_Student_Readonly()
        {
            if (btn_Submit.Enabled == false)
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


            }
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            /*
             * Serie de ifs que verificam quais os campos que o utilizador pretende modificar e adiciona essa mudança a Lista de mudanças Generic._list_Of_Changes
             */
            if (txt_StudentAddress.Text != Generic.CurrentStudent.Get_Address)
            {
                Change_Request Alteration = new Change_Request();
                Alteration.Set_UserID = Generic.CurrentStudent.Get_studentID;
                Alteration.Set_Message = "O User " + Generic.CurrentStudent.Get_studentID + " deseja alterar a morada para " + txt_StudentAddress.Text;
                Alteration.Set_Name_Of_Field = "morada";
                Alteration.Set_New_Content = txt_StudentAddress.Text;
                txt_StudentAddress.Text = Generic.CurrentStudent.Get_Address;
                Generic._list_Of_Changes.Add(Alteration);
            }

            if(txt_StudentName.Text != Generic.CurrentStudent.Get_Name)
            {
                Change_Request Alteration = new Change_Request();
                Alteration.Set_UserID = Generic.CurrentStudent.Get_studentID;
                Alteration.Set_Message = "O User " + Generic.CurrentStudent.Get_studentID + " deseja alterar o nome para " + txt_StudentName.Text;
                Alteration.Set_Name_Of_Field = "nome";
                Alteration.Set_New_Content = txt_StudentName.Text;
                txt_StudentName.Text = Generic.CurrentStudent.Get_Name;
                Generic._list_Of_Changes.Add(Alteration);
            }

            if(txt_StudentContact.Text != Generic.CurrentStudent.Get_Contact)
            {
                Change_Request Alteration = new Change_Request();
                Alteration.Set_UserID = Generic.CurrentStudent.Get_studentID;
                Alteration.Set_Message = "O User " + Generic.CurrentStudent.Get_studentID + " deseja alterar o contacto para " + txt_StudentContact.Text;
                Alteration.Set_Name_Of_Field = "contacto";
                Alteration.Set_New_Content = txt_StudentContact.Text;
                txt_StudentContact.Text = Generic.CurrentStudent.Get_Contact;
                Generic._list_Of_Changes.Add(Alteration);
            }

            if(txt_StudentNIF.Text != Generic.CurrentStudent.Get_NIF)
            {
                Change_Request Alteration = new Change_Request();
                Alteration.Set_UserID = Generic.CurrentStudent.Get_studentID;
                Alteration.Set_Message = "O User " + Generic.CurrentStudent.Get_studentID + " deseja alterar o NIF para " + txt_StudentNIF.Text;
                Alteration.Set_Name_Of_Field = "NIF";
                Alteration.Set_New_Content = txt_StudentNIF.Text;
                txt_StudentNIF.Text = Generic.CurrentStudent.Get_NIF;
                Generic._list_Of_Changes.Add(Alteration);
            }

            if(txt_StudentPassword.Text != Generic.CurrentStudent.Get_password)
            {
                Change_Request Alteration = new Change_Request();
                Alteration.Set_UserID = Generic.CurrentStudent.Get_studentID;
                Alteration.Set_Message = "O User " + Generic.CurrentStudent.Get_studentID + " deseja alterar a password para " + txt_StudentPassword.Text;
                Alteration.Set_Name_Of_Field = "password";
                Alteration.Set_New_Content = txt_StudentPassword.Text;
                txt_StudentPassword.Text = Generic.CurrentStudent.Get_password;
                Generic._list_Of_Changes.Add(Alteration);
            }

            txt_Student_Readonly();
        }

        private void btn_Deposit_Click(object sender, EventArgs e)
        {
            /*
             * Adiciona o saldo que o utilizador pretende adicionar ao hitorico do aluno e adicinar ao saldo
             */

            if (txt_QuantityDeposit.Text != "")
            {
                int saldo = Generic.CurrentStudent.Get_saldo;
                lbl_QuantityDepositError.Text = "";

                string aux = "Deposito no valor de " + txt_QuantityDeposit.Text + "€";

                Generic.CurrentStudent.Get_History.Add(aux);

                saldo += Convert.ToInt32(txt_QuantityDeposit.Text);
                Generic.CurrentStudent.Set_saldo = saldo;
                lbl_ShowBalance.Text = "Saldo: " + Generic.CurrentStudent.Get_saldo.ToString();

                lb_History.Items.Clear();
                lb_History.Items.AddRange(Generic.CurrentStudent.Get_History.ToArray());

            }
            else
            {
                lbl_QuantityDepositError.Text = "Campo obrigatório"; //Caso o utilizador não preencha o campo do saldo Avisa com uma label de erro
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
                    Set_origin = Generic.CurrentStudent.Get_studentID,
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

        /// <summary>
        /// Atualiza a ListBox lb_Chat com as mensagens do utilizador como "Eu" e do destinatario como "Nome do destinatario" e atualiza a variavel isRead
        /// </summary>
        private void refreshChat()
        {
            lb_Chat.Items.Clear();
            foreach (var item in Generic._List_Of_Chats)
            {
                if (item.Get_origin == Generic.CurrentStudent.Get_studentID && item.Get_destinatary == cbb_SelectUserChat.SelectedItem.ToString().Trim().Split('-')[1])
                {
                    lb_Chat.Items.Add("Eu: " + item.Get_Message);
                }
                if (item.Get_destinatary == Generic.CurrentStudent.Get_studentID && item.Get_origin == cbb_SelectUserChat.SelectedItem.ToString().Trim().Split('-')[1])
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

        private void txt_MsgContent_Leave(object sender, EventArgs e)
        {
            //Atualiza a lbl_PLaceHolder para visivel uma vez que o utilizado já nao esta na TextBox txt_MsgContent

            if (txt_MsgContent.Text == "")
            {
                lbl_PlaceHolder.Text = "Mensagem para " + cbb_SelectUserChat.Text.Split('-')[0];
                lbl_PlaceHolder.Visible = true;
            }
        }

        private void txt_MsgContent_Enter(object sender, EventArgs e)
        {
            //Atualiza a lbl_PLaceHolder para nao visivel uma vez que o utilizado quer escrever a mensagem
                lbl_PlaceHolder.Visible = false;
        }
    }
}
