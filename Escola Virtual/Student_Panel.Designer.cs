﻿
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
            this.tp_Profile = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tvw_Grades = new System.Windows.Forms.TreeView();
            this.lbl_History = new System.Windows.Forms.Label();
            this.lb_History = new System.Windows.Forms.ListBox();
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
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.tc_Student.SuspendLayout();
            this.tp_Actions.SuspendLayout();
            this.tp_Profile.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc_Student
            // 
            this.tc_Student.Controls.Add(this.tp_Actions);
            this.tc_Student.Controls.Add(this.tp_Profile);
            this.tc_Student.Location = new System.Drawing.Point(12, 12);
            this.tc_Student.Name = "tc_Student";
            this.tc_Student.SelectedIndex = 0;
            this.tc_Student.Size = new System.Drawing.Size(588, 430);
            this.tc_Student.TabIndex = 0;
            // 
            // tp_Actions
            // 
            this.tp_Actions.Controls.Add(this.label1);
            this.tp_Actions.Controls.Add(this.tvw_Grades);
            this.tp_Actions.Controls.Add(this.lbl_History);
            this.tp_Actions.Controls.Add(this.lb_History);
            this.tp_Actions.Location = new System.Drawing.Point(4, 22);
            this.tp_Actions.Name = "tp_Actions";
            this.tp_Actions.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Actions.Size = new System.Drawing.Size(580, 404);
            this.tp_Actions.TabIndex = 0;
            this.tp_Actions.Text = "Ações";
            this.tp_Actions.UseVisualStyleBackColor = true;
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
            this.tp_Profile.Location = new System.Drawing.Point(4, 22);
            this.tp_Profile.Name = "tp_Profile";
            this.tp_Profile.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Profile.Size = new System.Drawing.Size(580, 404);
            this.tp_Profile.TabIndex = 1;
            this.tp_Profile.Text = "Perfil";
            this.tp_Profile.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Notas";
            // 
            // tvw_Grades
            // 
            this.tvw_Grades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tvw_Grades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvw_Grades.Location = new System.Drawing.Point(14, 25);
            this.tvw_Grades.Margin = new System.Windows.Forms.Padding(2);
            this.tvw_Grades.Name = "tvw_Grades";
            this.tvw_Grades.Size = new System.Drawing.Size(162, 328);
            this.tvw_Grades.TabIndex = 10;
            // 
            // lbl_History
            // 
            this.lbl_History.AutoSize = true;
            this.lbl_History.Location = new System.Drawing.Point(178, 9);
            this.lbl_History.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_History.Name = "lbl_History";
            this.lbl_History.Size = new System.Drawing.Size(64, 13);
            this.lbl_History.TabIndex = 9;
            this.lbl_History.Text = "Movimentos";
            // 
            // lb_History
            // 
            this.lb_History.FormattingEnabled = true;
            this.lb_History.Location = new System.Drawing.Point(180, 25);
            this.lb_History.Margin = new System.Windows.Forms.Padding(2);
            this.lb_History.Name = "lb_History";
            this.lb_History.Size = new System.Drawing.Size(279, 329);
            this.lb_History.TabIndex = 8;
            // 
            // chb_show_Password
            // 
            this.chb_show_Password.Appearance = System.Windows.Forms.Appearance.Button;
            this.chb_show_Password.AutoSize = true;
            this.chb_show_Password.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chb_show_Password.BackgroundImage")));
            this.chb_show_Password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chb_show_Password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chb_show_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_show_Password.Location = new System.Drawing.Point(146, 203);
            this.chb_show_Password.Name = "chb_show_Password";
            this.chb_show_Password.Size = new System.Drawing.Size(31, 19);
            this.chb_show_Password.TabIndex = 41;
            this.chb_show_Password.Text = "        ";
            this.chb_show_Password.UseVisualStyleBackColor = true;
            // 
            // txt_StudentPassword
            // 
            this.txt_StudentPassword.Location = new System.Drawing.Point(15, 203);
            this.txt_StudentPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txt_StudentPassword.MaxLength = 9;
            this.txt_StudentPassword.Name = "txt_StudentPassword";
            this.txt_StudentPassword.PasswordChar = '*';
            this.txt_StudentPassword.ReadOnly = true;
            this.txt_StudentPassword.Size = new System.Drawing.Size(127, 20);
            this.txt_StudentPassword.TabIndex = 40;
            // 
            // txt_StudentNumber
            // 
            this.txt_StudentNumber.Location = new System.Drawing.Point(15, 254);
            this.txt_StudentNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txt_StudentNumber.Name = "txt_StudentNumber";
            this.txt_StudentNumber.ReadOnly = true;
            this.txt_StudentNumber.Size = new System.Drawing.Size(101, 20);
            this.txt_StudentNumber.TabIndex = 38;
            this.txt_StudentNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_StudentNIF
            // 
            this.txt_StudentNIF.Location = new System.Drawing.Point(14, 156);
            this.txt_StudentNIF.Margin = new System.Windows.Forms.Padding(2);
            this.txt_StudentNIF.MaxLength = 9;
            this.txt_StudentNIF.Name = "txt_StudentNIF";
            this.txt_StudentNIF.ReadOnly = true;
            this.txt_StudentNIF.Size = new System.Drawing.Size(127, 20);
            this.txt_StudentNIF.TabIndex = 36;
            // 
            // txt_StudentContact
            // 
            this.txt_StudentContact.Location = new System.Drawing.Point(14, 111);
            this.txt_StudentContact.Margin = new System.Windows.Forms.Padding(2);
            this.txt_StudentContact.Name = "txt_StudentContact";
            this.txt_StudentContact.ReadOnly = true;
            this.txt_StudentContact.Size = new System.Drawing.Size(127, 20);
            this.txt_StudentContact.TabIndex = 34;
            // 
            // txt_StudentAddress
            // 
            this.txt_StudentAddress.Location = new System.Drawing.Point(14, 66);
            this.txt_StudentAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txt_StudentAddress.Name = "txt_StudentAddress";
            this.txt_StudentAddress.ReadOnly = true;
            this.txt_StudentAddress.Size = new System.Drawing.Size(237, 20);
            this.txt_StudentAddress.TabIndex = 32;
            // 
            // txt_StudentName
            // 
            this.txt_StudentName.Location = new System.Drawing.Point(14, 26);
            this.txt_StudentName.Margin = new System.Windows.Forms.Padding(2);
            this.txt_StudentName.Name = "txt_StudentName";
            this.txt_StudentName.ReadOnly = true;
            this.txt_StudentName.Size = new System.Drawing.Size(127, 20);
            this.txt_StudentName.TabIndex = 30;
            // 
            // lbl_StudentPassword
            // 
            this.lbl_StudentPassword.AutoSize = true;
            this.lbl_StudentPassword.Location = new System.Drawing.Point(12, 184);
            this.lbl_StudentPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_StudentPassword.Name = "lbl_StudentPassword";
            this.lbl_StudentPassword.Size = new System.Drawing.Size(53, 13);
            this.lbl_StudentPassword.TabIndex = 39;
            this.lbl_StudentPassword.Text = "Password";
            // 
            // lbl_StudentNumber
            // 
            this.lbl_StudentNumber.AutoSize = true;
            this.lbl_StudentNumber.Location = new System.Drawing.Point(12, 237);
            this.lbl_StudentNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_StudentNumber.Name = "lbl_StudentNumber";
            this.lbl_StudentNumber.Size = new System.Drawing.Size(74, 13);
            this.lbl_StudentNumber.TabIndex = 37;
            this.lbl_StudentNumber.Text = "Numero Aluno";
            // 
            // lbl_StudentNIF
            // 
            this.lbl_StudentNIF.AutoSize = true;
            this.lbl_StudentNIF.Location = new System.Drawing.Point(11, 138);
            this.lbl_StudentNIF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_StudentNIF.Name = "lbl_StudentNIF";
            this.lbl_StudentNIF.Size = new System.Drawing.Size(24, 13);
            this.lbl_StudentNIF.TabIndex = 35;
            this.lbl_StudentNIF.Text = "NIF";
            // 
            // lbl_StudentContact
            // 
            this.lbl_StudentContact.AutoSize = true;
            this.lbl_StudentContact.Location = new System.Drawing.Point(11, 94);
            this.lbl_StudentContact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_StudentContact.Name = "lbl_StudentContact";
            this.lbl_StudentContact.Size = new System.Drawing.Size(50, 13);
            this.lbl_StudentContact.TabIndex = 33;
            this.lbl_StudentContact.Text = "Contacto";
            // 
            // lbl_StudentAddress
            // 
            this.lbl_StudentAddress.AutoSize = true;
            this.lbl_StudentAddress.Location = new System.Drawing.Point(11, 50);
            this.lbl_StudentAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_StudentAddress.Name = "lbl_StudentAddress";
            this.lbl_StudentAddress.Size = new System.Drawing.Size(43, 13);
            this.lbl_StudentAddress.TabIndex = 31;
            this.lbl_StudentAddress.Text = "Morada";
            // 
            // lbl_StudentName
            // 
            this.lbl_StudentName.AutoSize = true;
            this.lbl_StudentName.Location = new System.Drawing.Point(11, 8);
            this.lbl_StudentName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_StudentName.Name = "lbl_StudentName";
            this.lbl_StudentName.Size = new System.Drawing.Size(35, 13);
            this.lbl_StudentName.TabIndex = 29;
            this.lbl_StudentName.Text = "Nome";
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(14, 375);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 42;
            this.btn_edit.Text = "Editar";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Enabled = false;
            this.btn_Submit.Location = new System.Drawing.Point(249, 375);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(75, 23);
            this.btn_Submit.TabIndex = 43;
            this.btn_Submit.Text = "Submeter";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // Student_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 454);
            this.Controls.Add(this.tc_Student);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Student_Panel";
            this.Text = "Painel de Aluno";
            this.Load += new System.EventHandler(this.Student_Panel_Load);
            this.tc_Student.ResumeLayout(false);
            this.tp_Actions.ResumeLayout(false);
            this.tp_Actions.PerformLayout();
            this.tp_Profile.ResumeLayout(false);
            this.tp_Profile.PerformLayout();
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
    }
}