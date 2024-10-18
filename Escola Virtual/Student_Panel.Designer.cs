
namespace Escola_Virtual
{
    partial class Student_Panel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student_Panel));
            this.tc_Student = new System.Windows.Forms.TabControl();
            this.tp_Actions = new System.Windows.Forms.TabPage();
            this.lbl_QuantityDepositError = new System.Windows.Forms.Label();
            this.btn_Deposit = new System.Windows.Forms.Button();
            this.txt_QuantityDeposit = new System.Windows.Forms.TextBox();
            this.lbl_DepositQuantity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tvw_Grades = new System.Windows.Forms.TreeView();
            this.lbl_History = new System.Windows.Forms.Label();
            this.lb_History = new System.Windows.Forms.ListBox();
            this.tp_Profile = new System.Windows.Forms.TabPage();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.chb_show_Password = new System.Windows.Forms.CheckBox();
            this.txt_StudentPassword = new System.Windows.Forms.TextBox();
            this.txt_StudentNumber = new System.Windows.Forms.TextBox();
            this.txt_StudentNIF = new System.Windows.Forms.TextBox();
            this.txt_StudentContact = new System.Windows.Forms.TextBox();
            this.txt_StudentAddress = new System.Windows.Forms.TextBox();
            this.txt_StudentName = new System.Windows.Forms.TextBox();
            this.lbl_StudentPassword = new System.Windows.Forms.Label();
            this.lbl_StudentNumber = new System.Windows.Forms.Label();
            this.lbl_StudentNIF = new System.Windows.Forms.Label();
            this.lbl_StudentContact = new System.Windows.Forms.Label();
            this.lbl_StudentAddress = new System.Windows.Forms.Label();
            this.lbl_StudentName = new System.Windows.Forms.Label();
            this.tp_StudentChat = new System.Windows.Forms.TabPage();
            this.btn_SendMsg = new System.Windows.Forms.Button();
            this.txt_MsgContent = new System.Windows.Forms.TextBox();
            this.lb_Chat = new System.Windows.Forms.ListBox();
            this.cbb_SelectUserChat = new System.Windows.Forms.ComboBox();
            this.lbl_ShowBalance = new System.Windows.Forms.Label();
            this.tc_Student.SuspendLayout();
            this.tp_Actions.SuspendLayout();
            this.tp_Profile.SuspendLayout();
            this.tp_StudentChat.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc_Student
            // 
            this.tc_Student.Controls.Add(this.tp_Actions);
            this.tc_Student.Controls.Add(this.tp_Profile);
            this.tc_Student.Controls.Add(this.tp_StudentChat);
            this.tc_Student.Location = new System.Drawing.Point(3, 1);
            this.tc_Student.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tc_Student.Name = "tc_Student";
            this.tc_Student.SelectedIndex = 0;
            this.tc_Student.Size = new System.Drawing.Size(808, 561);
            this.tc_Student.TabIndex = 0;
            // 
            // tp_Actions
            // 
            this.tp_Actions.BackColor = System.Drawing.Color.White;
            this.tp_Actions.Controls.Add(this.lbl_ShowBalance);
            this.tp_Actions.Controls.Add(this.lbl_QuantityDepositError);
            this.tp_Actions.Controls.Add(this.btn_Deposit);
            this.tp_Actions.Controls.Add(this.txt_QuantityDeposit);
            this.tp_Actions.Controls.Add(this.lbl_DepositQuantity);
            this.tp_Actions.Controls.Add(this.label1);
            this.tp_Actions.Controls.Add(this.tvw_Grades);
            this.tp_Actions.Controls.Add(this.lbl_History);
            this.tp_Actions.Controls.Add(this.lb_History);
            this.tp_Actions.Location = new System.Drawing.Point(4, 25);
            this.tp_Actions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tp_Actions.Name = "tp_Actions";
            this.tp_Actions.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tp_Actions.Size = new System.Drawing.Size(800, 532);
            this.tp_Actions.TabIndex = 0;
            this.tp_Actions.Text = "Ações";
            // 
            // lbl_QuantityDepositError
            // 
            this.lbl_QuantityDepositError.AutoSize = true;
            this.lbl_QuantityDepositError.ForeColor = System.Drawing.Color.Red;
            this.lbl_QuantityDepositError.Location = new System.Drawing.Point(621, 79);
            this.lbl_QuantityDepositError.Name = "lbl_QuantityDepositError";
            this.lbl_QuantityDepositError.Size = new System.Drawing.Size(0, 17);
            this.lbl_QuantityDepositError.TabIndex = 15;
            // 
            // btn_Deposit
            // 
            this.btn_Deposit.Location = new System.Drawing.Point(621, 100);
            this.btn_Deposit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Deposit.Name = "btn_Deposit";
            this.btn_Deposit.Size = new System.Drawing.Size(171, 23);
            this.btn_Deposit.TabIndex = 14;
            this.btn_Deposit.Text = "Depositar";
            this.btn_Deposit.UseVisualStyleBackColor = true;
            this.btn_Deposit.Click += new System.EventHandler(this.btn_Deposit_Click);
            // 
            // txt_QuantityDeposit
            // 
            this.txt_QuantityDeposit.Location = new System.Drawing.Point(621, 52);
            this.txt_QuantityDeposit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_QuantityDeposit.Name = "txt_QuantityDeposit";
            this.txt_QuantityDeposit.Size = new System.Drawing.Size(169, 22);
            this.txt_QuantityDeposit.TabIndex = 13;
            this.txt_QuantityDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_DepositQuantity
            // 
            this.lbl_DepositQuantity.AutoSize = true;
            this.lbl_DepositQuantity.Location = new System.Drawing.Point(619, 31);
            this.lbl_DepositQuantity.Name = "lbl_DepositQuantity";
            this.lbl_DepositQuantity.Size = new System.Drawing.Size(157, 17);
            this.lbl_DepositQuantity.TabIndex = 12;
            this.lbl_DepositQuantity.Text = "Quantidade a depositar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Notas";
            // 
            // tvw_Grades
            // 
            this.tvw_Grades.BackColor = System.Drawing.Color.White;
            this.tvw_Grades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvw_Grades.Location = new System.Drawing.Point(19, 31);
            this.tvw_Grades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tvw_Grades.Name = "tvw_Grades";
            this.tvw_Grades.Size = new System.Drawing.Size(216, 500);
            this.tvw_Grades.TabIndex = 10;
            // 
            // lbl_History
            // 
            this.lbl_History.AutoSize = true;
            this.lbl_History.Location = new System.Drawing.Point(237, 11);
            this.lbl_History.Name = "lbl_History";
            this.lbl_History.Size = new System.Drawing.Size(83, 17);
            this.lbl_History.TabIndex = 9;
            this.lbl_History.Text = "Movimentos";
            // 
            // lb_History
            // 
            this.lb_History.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_History.FormattingEnabled = true;
            this.lb_History.ItemHeight = 16;
            this.lb_History.Location = new System.Drawing.Point(240, 31);
            this.lb_History.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lb_History.Name = "lb_History";
            this.lb_History.Size = new System.Drawing.Size(371, 496);
            this.lb_History.TabIndex = 8;
            // 
            // tp_Profile
            // 
            this.tp_Profile.Controls.Add(this.btn_Submit);
            this.tp_Profile.Controls.Add(this.btn_edit);
            this.tp_Profile.Controls.Add(this.chb_show_Password);
            this.tp_Profile.Controls.Add(this.txt_StudentPassword);
            this.tp_Profile.Controls.Add(this.txt_StudentNumber);
            this.tp_Profile.Controls.Add(this.txt_StudentNIF);
            this.tp_Profile.Controls.Add(this.txt_StudentContact);
            this.tp_Profile.Controls.Add(this.txt_StudentAddress);
            this.tp_Profile.Controls.Add(this.txt_StudentName);
            this.tp_Profile.Controls.Add(this.lbl_StudentPassword);
            this.tp_Profile.Controls.Add(this.lbl_StudentNumber);
            this.tp_Profile.Controls.Add(this.lbl_StudentNIF);
            this.tp_Profile.Controls.Add(this.lbl_StudentContact);
            this.tp_Profile.Controls.Add(this.lbl_StudentAddress);
            this.tp_Profile.Controls.Add(this.lbl_StudentName);
            this.tp_Profile.Location = new System.Drawing.Point(4, 25);
            this.tp_Profile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tp_Profile.Name = "tp_Profile";
            this.tp_Profile.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tp_Profile.Size = new System.Drawing.Size(800, 532);
            this.tp_Profile.TabIndex = 1;
            this.tp_Profile.Text = "Perfil";
            this.tp_Profile.UseVisualStyleBackColor = true;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Enabled = false;
            this.btn_Submit.Location = new System.Drawing.Point(332, 462);
            this.btn_Submit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(100, 28);
            this.btn_Submit.TabIndex = 43;
            this.btn_Submit.Text = "Submeter";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(19, 462);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(100, 28);
            this.btn_edit.TabIndex = 42;
            this.btn_edit.Text = "Editar";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // chb_show_Password
            // 
            this.chb_show_Password.Appearance = System.Windows.Forms.Appearance.Button;
            this.chb_show_Password.AutoSize = true;
            this.chb_show_Password.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chb_show_Password.BackgroundImage")));
            this.chb_show_Password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chb_show_Password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chb_show_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_show_Password.Location = new System.Drawing.Point(195, 250);
            this.chb_show_Password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chb_show_Password.Name = "chb_show_Password";
            this.chb_show_Password.Size = new System.Drawing.Size(41, 23);
            this.chb_show_Password.TabIndex = 41;
            this.chb_show_Password.Text = "        ";
            this.chb_show_Password.UseVisualStyleBackColor = true;
            // 
            // txt_StudentPassword
            // 
            this.txt_StudentPassword.Location = new System.Drawing.Point(20, 250);
            this.txt_StudentPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_StudentPassword.MaxLength = 9;
            this.txt_StudentPassword.Name = "txt_StudentPassword";
            this.txt_StudentPassword.PasswordChar = '*';
            this.txt_StudentPassword.ReadOnly = true;
            this.txt_StudentPassword.Size = new System.Drawing.Size(168, 22);
            this.txt_StudentPassword.TabIndex = 40;
            // 
            // txt_StudentNumber
            // 
            this.txt_StudentNumber.Location = new System.Drawing.Point(20, 313);
            this.txt_StudentNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_StudentNumber.Name = "txt_StudentNumber";
            this.txt_StudentNumber.ReadOnly = true;
            this.txt_StudentNumber.Size = new System.Drawing.Size(133, 22);
            this.txt_StudentNumber.TabIndex = 38;
            this.txt_StudentNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_StudentNIF
            // 
            this.txt_StudentNIF.Location = new System.Drawing.Point(19, 192);
            this.txt_StudentNIF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_StudentNIF.MaxLength = 9;
            this.txt_StudentNIF.Name = "txt_StudentNIF";
            this.txt_StudentNIF.ReadOnly = true;
            this.txt_StudentNIF.Size = new System.Drawing.Size(168, 22);
            this.txt_StudentNIF.TabIndex = 36;
            // 
            // txt_StudentContact
            // 
            this.txt_StudentContact.Location = new System.Drawing.Point(19, 137);
            this.txt_StudentContact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_StudentContact.Name = "txt_StudentContact";
            this.txt_StudentContact.ReadOnly = true;
            this.txt_StudentContact.Size = new System.Drawing.Size(168, 22);
            this.txt_StudentContact.TabIndex = 34;
            // 
            // txt_StudentAddress
            // 
            this.txt_StudentAddress.Location = new System.Drawing.Point(19, 81);
            this.txt_StudentAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_StudentAddress.Name = "txt_StudentAddress";
            this.txt_StudentAddress.ReadOnly = true;
            this.txt_StudentAddress.Size = new System.Drawing.Size(315, 22);
            this.txt_StudentAddress.TabIndex = 32;
            // 
            // txt_StudentName
            // 
            this.txt_StudentName.Location = new System.Drawing.Point(19, 32);
            this.txt_StudentName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_StudentName.Name = "txt_StudentName";
            this.txt_StudentName.ReadOnly = true;
            this.txt_StudentName.Size = new System.Drawing.Size(168, 22);
            this.txt_StudentName.TabIndex = 30;
            // 
            // lbl_StudentPassword
            // 
            this.lbl_StudentPassword.AutoSize = true;
            this.lbl_StudentPassword.Location = new System.Drawing.Point(16, 226);
            this.lbl_StudentPassword.Name = "lbl_StudentPassword";
            this.lbl_StudentPassword.Size = new System.Drawing.Size(69, 17);
            this.lbl_StudentPassword.TabIndex = 39;
            this.lbl_StudentPassword.Text = "Password";
            // 
            // lbl_StudentNumber
            // 
            this.lbl_StudentNumber.AutoSize = true;
            this.lbl_StudentNumber.Location = new System.Drawing.Point(16, 292);
            this.lbl_StudentNumber.Name = "lbl_StudentNumber";
            this.lbl_StudentNumber.Size = new System.Drawing.Size(98, 17);
            this.lbl_StudentNumber.TabIndex = 37;
            this.lbl_StudentNumber.Text = "Numero Aluno";
            // 
            // lbl_StudentNIF
            // 
            this.lbl_StudentNIF.AutoSize = true;
            this.lbl_StudentNIF.Location = new System.Drawing.Point(15, 170);
            this.lbl_StudentNIF.Name = "lbl_StudentNIF";
            this.lbl_StudentNIF.Size = new System.Drawing.Size(29, 17);
            this.lbl_StudentNIF.TabIndex = 35;
            this.lbl_StudentNIF.Text = "NIF";
            // 
            // lbl_StudentContact
            // 
            this.lbl_StudentContact.AutoSize = true;
            this.lbl_StudentContact.Location = new System.Drawing.Point(15, 116);
            this.lbl_StudentContact.Name = "lbl_StudentContact";
            this.lbl_StudentContact.Size = new System.Drawing.Size(64, 17);
            this.lbl_StudentContact.TabIndex = 33;
            this.lbl_StudentContact.Text = "Contacto";
            // 
            // lbl_StudentAddress
            // 
            this.lbl_StudentAddress.AutoSize = true;
            this.lbl_StudentAddress.Location = new System.Drawing.Point(15, 62);
            this.lbl_StudentAddress.Name = "lbl_StudentAddress";
            this.lbl_StudentAddress.Size = new System.Drawing.Size(56, 17);
            this.lbl_StudentAddress.TabIndex = 31;
            this.lbl_StudentAddress.Text = "Morada";
            // 
            // lbl_StudentName
            // 
            this.lbl_StudentName.AutoSize = true;
            this.lbl_StudentName.Location = new System.Drawing.Point(15, 10);
            this.lbl_StudentName.Name = "lbl_StudentName";
            this.lbl_StudentName.Size = new System.Drawing.Size(45, 17);
            this.lbl_StudentName.TabIndex = 29;
            this.lbl_StudentName.Text = "Nome";
            // 
            // tp_StudentChat
            // 
            this.tp_StudentChat.Controls.Add(this.btn_SendMsg);
            this.tp_StudentChat.Controls.Add(this.txt_MsgContent);
            this.tp_StudentChat.Controls.Add(this.lb_Chat);
            this.tp_StudentChat.Controls.Add(this.cbb_SelectUserChat);
            this.tp_StudentChat.Location = new System.Drawing.Point(4, 25);
            this.tp_StudentChat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tp_StudentChat.Name = "tp_StudentChat";
            this.tp_StudentChat.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tp_StudentChat.Size = new System.Drawing.Size(800, 532);
            this.tp_StudentChat.TabIndex = 2;
            this.tp_StudentChat.Text = "Chat";
            this.tp_StudentChat.UseVisualStyleBackColor = true;
            // 
            // btn_SendMsg
            // 
            this.btn_SendMsg.Location = new System.Drawing.Point(659, 475);
            this.btn_SendMsg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_SendMsg.Name = "btn_SendMsg";
            this.btn_SendMsg.Size = new System.Drawing.Size(131, 28);
            this.btn_SendMsg.TabIndex = 3;
            this.btn_SendMsg.Text = "Enviar";
            this.btn_SendMsg.UseVisualStyleBackColor = true;
            this.btn_SendMsg.Click += new System.EventHandler(this.btn_SendMsg_Click);
            // 
            // txt_MsgContent
            // 
            this.txt_MsgContent.Location = new System.Drawing.Point(364, 476);
            this.txt_MsgContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_MsgContent.Name = "txt_MsgContent";
            this.txt_MsgContent.Size = new System.Drawing.Size(284, 22);
            this.txt_MsgContent.TabIndex = 2;
            // 
            // lb_Chat
            // 
            this.lb_Chat.FormattingEnabled = true;
            this.lb_Chat.ItemHeight = 16;
            this.lb_Chat.Location = new System.Drawing.Point(364, 6);
            this.lb_Chat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lb_Chat.Name = "lb_Chat";
            this.lb_Chat.Size = new System.Drawing.Size(424, 468);
            this.lb_Chat.TabIndex = 1;
            // 
            // cbb_SelectUserChat
            // 
            this.cbb_SelectUserChat.FormattingEnabled = true;
            this.cbb_SelectUserChat.Location = new System.Drawing.Point(195, 7);
            this.cbb_SelectUserChat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbb_SelectUserChat.Name = "cbb_SelectUserChat";
            this.cbb_SelectUserChat.Size = new System.Drawing.Size(160, 24);
            this.cbb_SelectUserChat.TabIndex = 0;
            this.cbb_SelectUserChat.SelectedIndexChanged += new System.EventHandler(this.cbb_SelectUserChat_SelectedIndexChanged);
            // 
            // lbl_ShowBalance
            // 
            this.lbl_ShowBalance.AutoSize = true;
            this.lbl_ShowBalance.Location = new System.Drawing.Point(621, 147);
            this.lbl_ShowBalance.Name = "lbl_ShowBalance";
            this.lbl_ShowBalance.Size = new System.Drawing.Size(48, 17);
            this.lbl_ShowBalance.TabIndex = 16;
            this.lbl_ShowBalance.Text = "Saldo:";
            // 
            // Student_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 559);
            this.Controls.Add(this.tc_Student);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Student_Panel";
            this.Text = "Painel de Aluno";
            this.Load += new System.EventHandler(this.Student_Panel_Load);
            this.tc_Student.ResumeLayout(false);
            this.tp_Actions.ResumeLayout(false);
            this.tp_Actions.PerformLayout();
            this.tp_Profile.ResumeLayout(false);
            this.tp_Profile.PerformLayout();
            this.tp_StudentChat.ResumeLayout(false);
            this.tp_StudentChat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc_Student;
        private System.Windows.Forms.TabPage tp_Actions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView tvw_Grades;
        private System.Windows.Forms.Label lbl_History;
        private System.Windows.Forms.ListBox lb_History;
        private System.Windows.Forms.TabPage tp_Profile;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.CheckBox chb_show_Password;
        private System.Windows.Forms.TextBox txt_StudentPassword;
        private System.Windows.Forms.TextBox txt_StudentNumber;
        private System.Windows.Forms.TextBox txt_StudentNIF;
        private System.Windows.Forms.TextBox txt_StudentContact;
        private System.Windows.Forms.TextBox txt_StudentAddress;
        private System.Windows.Forms.TextBox txt_StudentName;
        private System.Windows.Forms.Label lbl_StudentPassword;
        private System.Windows.Forms.Label lbl_StudentNumber;
        private System.Windows.Forms.Label lbl_StudentNIF;
        private System.Windows.Forms.Label lbl_StudentContact;
        private System.Windows.Forms.Label lbl_StudentAddress;
        private System.Windows.Forms.Label lbl_StudentName;
        private System.Windows.Forms.Label lbl_QuantityDepositError;
        private System.Windows.Forms.Button btn_Deposit;
        private System.Windows.Forms.TextBox txt_QuantityDeposit;
        private System.Windows.Forms.Label lbl_DepositQuantity;
        private System.Windows.Forms.TabPage tp_StudentChat;
        private System.Windows.Forms.ListBox lb_Chat;
        private System.Windows.Forms.ComboBox cbb_SelectUserChat;
        private System.Windows.Forms.Button btn_SendMsg;
        private System.Windows.Forms.TextBox txt_MsgContent;
        private System.Windows.Forms.Label lbl_ShowBalance;
    }
}