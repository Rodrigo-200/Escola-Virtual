namespace Escola_Virtual
{
    partial class Teacher_Panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teacher_Panel));
            this.tc_Teacher = new System.Windows.Forms.TabControl();
            this.tp_StudentActions = new System.Windows.Forms.TabPage();
            this.txt_GradeValue = new System.Windows.Forms.TextBox();
            this.btn_GradeLaunch = new System.Windows.Forms.Button();
            this.lbl_GradeLaunch = new System.Windows.Forms.Label();
            this.tvw_GradeLaunch = new System.Windows.Forms.TreeView();
            this.tp_StudentProfile = new System.Windows.Forms.TabPage();
            this.btn_TeacherSubmit = new System.Windows.Forms.Button();
            this.btn_TeacherEdit = new System.Windows.Forms.Button();
            this.chb_TeacherShowPassword = new System.Windows.Forms.CheckBox();
            this.txt_TeacherPassword = new System.Windows.Forms.TextBox();
            this.txt_TeacherNumber = new System.Windows.Forms.TextBox();
            this.txt_TeacherNIF = new System.Windows.Forms.TextBox();
            this.txt_TeacherContact = new System.Windows.Forms.TextBox();
            this.txt_TeacherAddress = new System.Windows.Forms.TextBox();
            this.txt_TeacherName = new System.Windows.Forms.TextBox();
            this.lbl_TeacherPassword = new System.Windows.Forms.Label();
            this.lbl_TeacherNumber = new System.Windows.Forms.Label();
            this.lbl_TeacherNIF = new System.Windows.Forms.Label();
            this.lbl_TeacherContact = new System.Windows.Forms.Label();
            this.lbl_TeacherAddress = new System.Windows.Forms.Label();
            this.lbl_TeacherName = new System.Windows.Forms.Label();
            this.tp_TeacherChat = new System.Windows.Forms.TabPage();
            this.btn_SendMsg = new System.Windows.Forms.Button();
            this.txt_MsgContent = new System.Windows.Forms.TextBox();
            this.lb_Chat = new System.Windows.Forms.ListBox();
            this.cbb_SelectUserChat = new System.Windows.Forms.ComboBox();
            this.tc_Teacher.SuspendLayout();
            this.tp_StudentActions.SuspendLayout();
            this.tp_StudentProfile.SuspendLayout();
            this.tp_TeacherChat.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc_Teacher
            // 
            this.tc_Teacher.Controls.Add(this.tp_StudentActions);
            this.tc_Teacher.Controls.Add(this.tp_StudentProfile);
            this.tc_Teacher.Controls.Add(this.tp_TeacherChat);
            this.tc_Teacher.Location = new System.Drawing.Point(16, 15);
            this.tc_Teacher.Margin = new System.Windows.Forms.Padding(4);
            this.tc_Teacher.Name = "tc_Teacher";
            this.tc_Teacher.SelectedIndex = 0;
            this.tc_Teacher.Size = new System.Drawing.Size(724, 580);
            this.tc_Teacher.TabIndex = 29;
            // 
            // tp_StudentActions
            // 
            this.tp_StudentActions.Controls.Add(this.txt_GradeValue);
            this.tp_StudentActions.Controls.Add(this.btn_GradeLaunch);
            this.tp_StudentActions.Controls.Add(this.lbl_GradeLaunch);
            this.tp_StudentActions.Controls.Add(this.tvw_GradeLaunch);
            this.tp_StudentActions.Location = new System.Drawing.Point(4, 25);
            this.tp_StudentActions.Margin = new System.Windows.Forms.Padding(4);
            this.tp_StudentActions.Name = "tp_StudentActions";
            this.tp_StudentActions.Padding = new System.Windows.Forms.Padding(4);
            this.tp_StudentActions.Size = new System.Drawing.Size(716, 551);
            this.tp_StudentActions.TabIndex = 0;
            this.tp_StudentActions.Text = "Ações";
            this.tp_StudentActions.UseVisualStyleBackColor = true;
            // 
            // txt_GradeValue
            // 
            this.txt_GradeValue.Location = new System.Drawing.Point(11, 495);
            this.txt_GradeValue.Margin = new System.Windows.Forms.Padding(4);
            this.txt_GradeValue.MaxLength = 2;
            this.txt_GradeValue.Name = "txt_GradeValue";
            this.txt_GradeValue.Size = new System.Drawing.Size(99, 22);
            this.txt_GradeValue.TabIndex = 36;
            // 
            // btn_GradeLaunch
            // 
            this.btn_GradeLaunch.Location = new System.Drawing.Point(313, 495);
            this.btn_GradeLaunch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_GradeLaunch.Name = "btn_GradeLaunch";
            this.btn_GradeLaunch.Size = new System.Drawing.Size(105, 23);
            this.btn_GradeLaunch.TabIndex = 35;
            this.btn_GradeLaunch.Text = "Confirmar";
            this.btn_GradeLaunch.UseVisualStyleBackColor = true;
            this.btn_GradeLaunch.Click += new System.EventHandler(this.btn_GradeLaunch_Click);
            // 
            // lbl_GradeLaunch
            // 
            this.lbl_GradeLaunch.AutoSize = true;
            this.lbl_GradeLaunch.Location = new System.Drawing.Point(7, 12);
            this.lbl_GradeLaunch.Name = "lbl_GradeLaunch";
            this.lbl_GradeLaunch.Size = new System.Drawing.Size(145, 17);
            this.lbl_GradeLaunch.TabIndex = 34;
            this.lbl_GradeLaunch.Text = "Lançamento de notas";
            // 
            // tvw_GradeLaunch
            // 
            this.tvw_GradeLaunch.Location = new System.Drawing.Point(8, 32);
            this.tvw_GradeLaunch.Margin = new System.Windows.Forms.Padding(4);
            this.tvw_GradeLaunch.Name = "tvw_GradeLaunch";
            this.tvw_GradeLaunch.Size = new System.Drawing.Size(409, 440);
            this.tvw_GradeLaunch.TabIndex = 33;
            // 
            // tp_StudentProfile
            // 
            this.tp_StudentProfile.Controls.Add(this.btn_TeacherSubmit);
            this.tp_StudentProfile.Controls.Add(this.btn_TeacherEdit);
            this.tp_StudentProfile.Controls.Add(this.chb_TeacherShowPassword);
            this.tp_StudentProfile.Controls.Add(this.txt_TeacherPassword);
            this.tp_StudentProfile.Controls.Add(this.txt_TeacherNumber);
            this.tp_StudentProfile.Controls.Add(this.txt_TeacherNIF);
            this.tp_StudentProfile.Controls.Add(this.txt_TeacherContact);
            this.tp_StudentProfile.Controls.Add(this.txt_TeacherAddress);
            this.tp_StudentProfile.Controls.Add(this.txt_TeacherName);
            this.tp_StudentProfile.Controls.Add(this.lbl_TeacherPassword);
            this.tp_StudentProfile.Controls.Add(this.lbl_TeacherNumber);
            this.tp_StudentProfile.Controls.Add(this.lbl_TeacherNIF);
            this.tp_StudentProfile.Controls.Add(this.lbl_TeacherContact);
            this.tp_StudentProfile.Controls.Add(this.lbl_TeacherAddress);
            this.tp_StudentProfile.Controls.Add(this.lbl_TeacherName);
            this.tp_StudentProfile.Location = new System.Drawing.Point(4, 25);
            this.tp_StudentProfile.Margin = new System.Windows.Forms.Padding(4);
            this.tp_StudentProfile.Name = "tp_StudentProfile";
            this.tp_StudentProfile.Padding = new System.Windows.Forms.Padding(4);
            this.tp_StudentProfile.Size = new System.Drawing.Size(716, 551);
            this.tp_StudentProfile.TabIndex = 1;
            this.tp_StudentProfile.Text = "Perfil";
            this.tp_StudentProfile.UseVisualStyleBackColor = true;
            // 
            // btn_TeacherSubmit
            // 
            this.btn_TeacherSubmit.Enabled = false;
            this.btn_TeacherSubmit.Location = new System.Drawing.Point(325, 512);
            this.btn_TeacherSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TeacherSubmit.Name = "btn_TeacherSubmit";
            this.btn_TeacherSubmit.Size = new System.Drawing.Size(100, 28);
            this.btn_TeacherSubmit.TabIndex = 46;
            this.btn_TeacherSubmit.Text = "Submeter";
            this.btn_TeacherSubmit.UseVisualStyleBackColor = true;
            this.btn_TeacherSubmit.Click += new System.EventHandler(this.btn_TeacherSubmit_Click);
            // 
            // btn_TeacherEdit
            // 
            this.btn_TeacherEdit.Location = new System.Drawing.Point(8, 512);
            this.btn_TeacherEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TeacherEdit.Name = "btn_TeacherEdit";
            this.btn_TeacherEdit.Size = new System.Drawing.Size(100, 28);
            this.btn_TeacherEdit.TabIndex = 45;
            this.btn_TeacherEdit.Text = "Editar";
            this.btn_TeacherEdit.UseVisualStyleBackColor = true;
            this.btn_TeacherEdit.Click += new System.EventHandler(this.btn_TeacherEdit_Click);
            // 
            // chb_TeacherShowPassword
            // 
            this.chb_TeacherShowPassword.Appearance = System.Windows.Forms.Appearance.Button;
            this.chb_TeacherShowPassword.AutoSize = true;
            this.chb_TeacherShowPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chb_TeacherShowPassword.BackgroundImage")));
            this.chb_TeacherShowPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chb_TeacherShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chb_TeacherShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_TeacherShowPassword.Location = new System.Drawing.Point(183, 282);
            this.chb_TeacherShowPassword.Margin = new System.Windows.Forms.Padding(4);
            this.chb_TeacherShowPassword.Name = "chb_TeacherShowPassword";
            this.chb_TeacherShowPassword.Size = new System.Drawing.Size(41, 23);
            this.chb_TeacherShowPassword.TabIndex = 44;
            this.chb_TeacherShowPassword.Text = "        ";
            this.chb_TeacherShowPassword.UseVisualStyleBackColor = true;
            // 
            // txt_TeacherPassword
            // 
            this.txt_TeacherPassword.Location = new System.Drawing.Point(8, 282);
            this.txt_TeacherPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TeacherPassword.MaxLength = 9;
            this.txt_TeacherPassword.Name = "txt_TeacherPassword";
            this.txt_TeacherPassword.PasswordChar = '*';
            this.txt_TeacherPassword.ReadOnly = true;
            this.txt_TeacherPassword.Size = new System.Drawing.Size(168, 22);
            this.txt_TeacherPassword.TabIndex = 43;
            // 
            // txt_TeacherNumber
            // 
            this.txt_TeacherNumber.Location = new System.Drawing.Point(7, 336);
            this.txt_TeacherNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TeacherNumber.Name = "txt_TeacherNumber";
            this.txt_TeacherNumber.ReadOnly = true;
            this.txt_TeacherNumber.Size = new System.Drawing.Size(133, 22);
            this.txt_TeacherNumber.TabIndex = 41;
            this.txt_TeacherNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_TeacherNIF
            // 
            this.txt_TeacherNIF.Location = new System.Drawing.Point(7, 220);
            this.txt_TeacherNIF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TeacherNIF.MaxLength = 9;
            this.txt_TeacherNIF.Name = "txt_TeacherNIF";
            this.txt_TeacherNIF.ReadOnly = true;
            this.txt_TeacherNIF.Size = new System.Drawing.Size(168, 22);
            this.txt_TeacherNIF.TabIndex = 39;
            // 
            // txt_TeacherContact
            // 
            this.txt_TeacherContact.Location = new System.Drawing.Point(7, 165);
            this.txt_TeacherContact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TeacherContact.Name = "txt_TeacherContact";
            this.txt_TeacherContact.ReadOnly = true;
            this.txt_TeacherContact.Size = new System.Drawing.Size(168, 22);
            this.txt_TeacherContact.TabIndex = 37;
            // 
            // txt_TeacherAddress
            // 
            this.txt_TeacherAddress.Location = new System.Drawing.Point(7, 110);
            this.txt_TeacherAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TeacherAddress.Name = "txt_TeacherAddress";
            this.txt_TeacherAddress.ReadOnly = true;
            this.txt_TeacherAddress.Size = new System.Drawing.Size(315, 22);
            this.txt_TeacherAddress.TabIndex = 35;
            // 
            // txt_TeacherName
            // 
            this.txt_TeacherName.Location = new System.Drawing.Point(7, 60);
            this.txt_TeacherName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TeacherName.Name = "txt_TeacherName";
            this.txt_TeacherName.ReadOnly = true;
            this.txt_TeacherName.Size = new System.Drawing.Size(168, 22);
            this.txt_TeacherName.TabIndex = 33;
            // 
            // lbl_TeacherPassword
            // 
            this.lbl_TeacherPassword.AutoSize = true;
            this.lbl_TeacherPassword.Location = new System.Drawing.Point(4, 258);
            this.lbl_TeacherPassword.Name = "lbl_TeacherPassword";
            this.lbl_TeacherPassword.Size = new System.Drawing.Size(69, 17);
            this.lbl_TeacherPassword.TabIndex = 42;
            this.lbl_TeacherPassword.Text = "Password";
            // 
            // lbl_TeacherNumber
            // 
            this.lbl_TeacherNumber.AutoSize = true;
            this.lbl_TeacherNumber.Location = new System.Drawing.Point(4, 315);
            this.lbl_TeacherNumber.Name = "lbl_TeacherNumber";
            this.lbl_TeacherNumber.Size = new System.Drawing.Size(136, 17);
            this.lbl_TeacherNumber.TabIndex = 40;
            this.lbl_TeacherNumber.Text = "Numero Funcionário";
            // 
            // lbl_TeacherNIF
            // 
            this.lbl_TeacherNIF.AutoSize = true;
            this.lbl_TeacherNIF.Location = new System.Drawing.Point(4, 199);
            this.lbl_TeacherNIF.Name = "lbl_TeacherNIF";
            this.lbl_TeacherNIF.Size = new System.Drawing.Size(29, 17);
            this.lbl_TeacherNIF.TabIndex = 38;
            this.lbl_TeacherNIF.Text = "NIF";
            // 
            // lbl_TeacherContact
            // 
            this.lbl_TeacherContact.AutoSize = true;
            this.lbl_TeacherContact.Location = new System.Drawing.Point(4, 144);
            this.lbl_TeacherContact.Name = "lbl_TeacherContact";
            this.lbl_TeacherContact.Size = new System.Drawing.Size(64, 17);
            this.lbl_TeacherContact.TabIndex = 36;
            this.lbl_TeacherContact.Text = "Contacto";
            // 
            // lbl_TeacherAddress
            // 
            this.lbl_TeacherAddress.AutoSize = true;
            this.lbl_TeacherAddress.Location = new System.Drawing.Point(4, 90);
            this.lbl_TeacherAddress.Name = "lbl_TeacherAddress";
            this.lbl_TeacherAddress.Size = new System.Drawing.Size(56, 17);
            this.lbl_TeacherAddress.TabIndex = 34;
            this.lbl_TeacherAddress.Text = "Morada";
            // 
            // lbl_TeacherName
            // 
            this.lbl_TeacherName.AutoSize = true;
            this.lbl_TeacherName.Location = new System.Drawing.Point(4, 39);
            this.lbl_TeacherName.Name = "lbl_TeacherName";
            this.lbl_TeacherName.Size = new System.Drawing.Size(45, 17);
            this.lbl_TeacherName.TabIndex = 32;
            this.lbl_TeacherName.Text = "Nome";
            // 
            // tp_TeacherChat
            // 
            this.tp_TeacherChat.Controls.Add(this.btn_SendMsg);
            this.tp_TeacherChat.Controls.Add(this.txt_MsgContent);
            this.tp_TeacherChat.Controls.Add(this.lb_Chat);
            this.tp_TeacherChat.Controls.Add(this.cbb_SelectUserChat);
            this.tp_TeacherChat.Location = new System.Drawing.Point(4, 25);
            this.tp_TeacherChat.Margin = new System.Windows.Forms.Padding(4);
            this.tp_TeacherChat.Name = "tp_TeacherChat";
            this.tp_TeacherChat.Padding = new System.Windows.Forms.Padding(4);
            this.tp_TeacherChat.Size = new System.Drawing.Size(716, 551);
            this.tp_TeacherChat.TabIndex = 2;
            this.tp_TeacherChat.Text = "Chat";
            this.tp_TeacherChat.UseVisualStyleBackColor = true;
            // 
            // btn_SendMsg
            // 
            this.btn_SendMsg.Location = new System.Drawing.Point(585, 464);
            this.btn_SendMsg.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SendMsg.Name = "btn_SendMsg";
            this.btn_SendMsg.Size = new System.Drawing.Size(131, 28);
            this.btn_SendMsg.TabIndex = 7;
            this.btn_SendMsg.Text = "Enviar";
            this.btn_SendMsg.UseVisualStyleBackColor = true;
            this.btn_SendMsg.Click += new System.EventHandler(this.btn_SendMsg_Click);
            // 
            // txt_MsgContent
            // 
            this.txt_MsgContent.Location = new System.Drawing.Point(288, 465);
            this.txt_MsgContent.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MsgContent.Name = "txt_MsgContent";
            this.txt_MsgContent.Size = new System.Drawing.Size(284, 22);
            this.txt_MsgContent.TabIndex = 6;
            // 
            // lb_Chat
            // 
            this.lb_Chat.FormattingEnabled = true;
            this.lb_Chat.ItemHeight = 16;
            this.lb_Chat.Location = new System.Drawing.Point(288, 9);
            this.lb_Chat.Margin = new System.Windows.Forms.Padding(4);
            this.lb_Chat.Name = "lb_Chat";
            this.lb_Chat.Size = new System.Drawing.Size(424, 452);
            this.lb_Chat.TabIndex = 5;
            // 
            // cbb_SelectUserChat
            // 
            this.cbb_SelectUserChat.FormattingEnabled = true;
            this.cbb_SelectUserChat.Location = new System.Drawing.Point(120, 9);
            this.cbb_SelectUserChat.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_SelectUserChat.Name = "cbb_SelectUserChat";
            this.cbb_SelectUserChat.Size = new System.Drawing.Size(160, 24);
            this.cbb_SelectUserChat.TabIndex = 4;
            this.cbb_SelectUserChat.SelectedIndexChanged += new System.EventHandler(this.cbb_SelectUserChat_SelectedIndexChanged);
            // 
            // Teacher_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 598);
            this.Controls.Add(this.tc_Teacher);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Teacher_Panel";
            this.Text = "Teacher_Panel";
            this.Load += new System.EventHandler(this.Teacher_Panel_Load);
            this.tc_Teacher.ResumeLayout(false);
            this.tp_StudentActions.ResumeLayout(false);
            this.tp_StudentActions.PerformLayout();
            this.tp_StudentProfile.ResumeLayout(false);
            this.tp_StudentProfile.PerformLayout();
            this.tp_TeacherChat.ResumeLayout(false);
            this.tp_TeacherChat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc_Teacher;
        private System.Windows.Forms.TabPage tp_StudentActions;
        private System.Windows.Forms.TextBox txt_GradeValue;
        private System.Windows.Forms.Button btn_GradeLaunch;
        private System.Windows.Forms.Label lbl_GradeLaunch;
        private System.Windows.Forms.TreeView tvw_GradeLaunch;
        private System.Windows.Forms.TabPage tp_StudentProfile;
        private System.Windows.Forms.Button btn_TeacherSubmit;
        private System.Windows.Forms.Button btn_TeacherEdit;
        private System.Windows.Forms.CheckBox chb_TeacherShowPassword;
        private System.Windows.Forms.TextBox txt_TeacherPassword;
        private System.Windows.Forms.TextBox txt_TeacherNumber;
        private System.Windows.Forms.TextBox txt_TeacherNIF;
        private System.Windows.Forms.TextBox txt_TeacherContact;
        private System.Windows.Forms.TextBox txt_TeacherAddress;
        private System.Windows.Forms.TextBox txt_TeacherName;
        private System.Windows.Forms.Label lbl_TeacherPassword;
        private System.Windows.Forms.Label lbl_TeacherNumber;
        private System.Windows.Forms.Label lbl_TeacherNIF;
        private System.Windows.Forms.Label lbl_TeacherContact;
        private System.Windows.Forms.Label lbl_TeacherAddress;
        private System.Windows.Forms.Label lbl_TeacherName;
        private System.Windows.Forms.TabPage tp_TeacherChat;
        private System.Windows.Forms.Button btn_SendMsg;
        private System.Windows.Forms.TextBox txt_MsgContent;
        private System.Windows.Forms.ListBox lb_Chat;
        private System.Windows.Forms.ComboBox cbb_SelectUserChat;
    }
}