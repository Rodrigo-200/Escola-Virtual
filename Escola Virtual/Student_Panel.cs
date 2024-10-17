﻿using System;
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


            lb_History.Items.Clear();
            lb_History.Items.AddRange(Generic.CurrentStudent.Get_History.ToArray());

            txt_StudentAddress.Text = Generic.CurrentStudent.Get_Address;
            txt_StudentName.Text = Generic.CurrentStudent.Get_Name;
            txt_StudentContact.Text = Generic.CurrentStudent.Get_Contact;
            txt_StudentNIF.Text = Generic.CurrentStudent.Get_NIF;
            txt_StudentNumber.Text = Generic.CurrentStudent.Get_studentID;
            txt_StudentPassword.Text = Generic.CurrentStudent.Get_password;


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

        private void tvw_Grades_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            txt_Student_Readonly();
        }

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

            
            if(txt_StudentAddress.Text != Generic.CurrentStudent.Get_Address)
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
            //ADICIONAR REALMENTE O SALDO AO USER
            if (txt_QuantityDeposit.Text != "")
            {
                lbl_QuantityDepositError.Text = "";

                string aux = "Deposito no valor de " + txt_QuantityDeposit.Text + "€";

                Generic.CurrentStudent.Get_History.Add(aux);

                lb_History.Items.Clear();
                lb_History.Items.AddRange(Generic.CurrentStudent.Get_History.ToArray());

            }
            else
            {
                lbl_QuantityDepositError.Text = "Campo obrigatório";
            }
        }

        private void cbb_SelectUserChat_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshChat();
        }

        private void btn_SendMsg_Click(object sender, EventArgs e)
        {
            string mensagem = txt_MsgContent.Text;

            Chat NewChatMsg = new Chat()
            {
                Set_isRead = false,
                Set_destinatary = cbb_SelectUserChat.SelectedItem.ToString().Trim().Split('-')[1],
                Set_origin = Generic.CurrentStudent.Get_studentID,
                Set_Message = mensagem,
            };

            Generic._List_Of_Chats.Add(NewChatMsg);

            refreshChat();
        }

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
                }
            }
        }
    }
}
