﻿
namespace Escola_Virtual
{
    partial class Admin_Panel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Panel));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tp_AdminCreateThings = new System.Windows.Forms.TabPage();
            this.tc_AdminCreateThings = new System.Windows.Forms.TabControl();
            this.tp_AdminCreateYears = new System.Windows.Forms.TabPage();
            this.tp_AdminCreateSubject = new System.Windows.Forms.TabPage();
            this.tvw_CreateSubject = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_SubjectName = new System.Windows.Forms.TextBox();
            this.lbl_SubjectName = new System.Windows.Forms.Label();
            this.lbl_SubjectAcronym = new System.Windows.Forms.Label();
            this.txt_SubjectAcronym = new System.Windows.Forms.TextBox();
            this.txt_SubjectAmmountOfClasses = new System.Windows.Forms.TextBox();
            this.lbl_SubjectAmmountOfClasses = new System.Windows.Forms.Label();
            this.btn_CreateSubject = new System.Windows.Forms.Button();
            this.tp_StudentsPage = new System.Windows.Forms.TabPage();
            this.lbl_StudentName = new System.Windows.Forms.Label();
            this.txt_StudentName = new System.Windows.Forms.TextBox();
            this.lbl_StudentAddress = new System.Windows.Forms.Label();
            this.txt_StudentAddress = new System.Windows.Forms.TextBox();
            this.lbl_StudentContact = new System.Windows.Forms.Label();
            this.txt_StudentContact = new System.Windows.Forms.TextBox();
            this.lbl_StudentNIF = new System.Windows.Forms.Label();
            this.txt_StudentNIF = new System.Windows.Forms.TextBox();
            this.lbl_StudentNumber = new System.Windows.Forms.Label();
            this.txt_StudentNumber = new System.Windows.Forms.TextBox();
            this.btn_StudentConfirm = new System.Windows.Forms.Button();
            this.lbl_StudentPassword = new System.Windows.Forms.Label();
            this.txt_StudentPassword = new System.Windows.Forms.TextBox();
            this.chb_show_Password = new System.Windows.Forms.CheckBox();
            this.tvw_Year_Class_Student = new System.Windows.Forms.TreeView();
            this.lbl_StudentChooseClass = new System.Windows.Forms.Label();
            this.tp_TeachersPage = new System.Windows.Forms.TabPage();
            this.lbl_TeacherName = new System.Windows.Forms.Label();
            this.txt_TeacherName = new System.Windows.Forms.TextBox();
            this.lbl_TeacherAddress = new System.Windows.Forms.Label();
            this.txt_TeacherAddress = new System.Windows.Forms.TextBox();
            this.lbl_TeacherContact = new System.Windows.Forms.Label();
            this.txt_TeacherContact = new System.Windows.Forms.TextBox();
            this.lbl_TeacherNIF = new System.Windows.Forms.Label();
            this.txt_TeacherNIF = new System.Windows.Forms.TextBox();
            this.lbl_TeacherYearsAndSubjects = new System.Windows.Forms.Label();
            this.tvw_TeacherYearsAndSubjects = new System.Windows.Forms.TreeView();
            this.lbl_TeacherNumber = new System.Windows.Forms.Label();
            this.txt_TeacherNumber = new System.Windows.Forms.TextBox();
            this.btn_TeacherConfirm = new System.Windows.Forms.Button();
            this.lbl_TeacherPassword = new System.Windows.Forms.Label();
            this.txt_TeacherPassword = new System.Windows.Forms.TextBox();
            this.chb_TeacherShowPassword = new System.Windows.Forms.CheckBox();
            this.tc_Choices = new System.Windows.Forms.TabControl();
            this.lbl_CreateSchoolYear = new System.Windows.Forms.Label();
            this.txt_CreateSchoolYear = new System.Windows.Forms.TextBox();
            this.btn_CreateSchoolYear = new System.Windows.Forms.Button();
            this.tp_AdminCreateThings.SuspendLayout();
            this.tc_AdminCreateThings.SuspendLayout();
            this.tp_AdminCreateYears.SuspendLayout();
            this.tp_AdminCreateSubject.SuspendLayout();
            this.tp_StudentsPage.SuspendLayout();
            this.tp_TeachersPage.SuspendLayout();
            this.tc_Choices.SuspendLayout();
            this.SuspendLayout();
            // 
            // tp_AdminCreateThings
            // 
            this.tp_AdminCreateThings.Controls.Add(this.tc_AdminCreateThings);
            this.tp_AdminCreateThings.Location = new System.Drawing.Point(4, 25);
            this.tp_AdminCreateThings.Name = "tp_AdminCreateThings";
            this.tp_AdminCreateThings.Size = new System.Drawing.Size(803, 420);
            this.tp_AdminCreateThings.TabIndex = 2;
            this.tp_AdminCreateThings.Text = "Outros";
            this.tp_AdminCreateThings.UseVisualStyleBackColor = true;
            // 
            // tc_AdminCreateThings
            // 
            this.tc_AdminCreateThings.Controls.Add(this.tp_AdminCreateSubject);
            this.tc_AdminCreateThings.Controls.Add(this.tp_AdminCreateYears);
            this.tc_AdminCreateThings.Location = new System.Drawing.Point(7, 3);
            this.tc_AdminCreateThings.Name = "tc_AdminCreateThings";
            this.tc_AdminCreateThings.SelectedIndex = 0;
            this.tc_AdminCreateThings.Size = new System.Drawing.Size(791, 414);
            this.tc_AdminCreateThings.TabIndex = 0;
            // 
            // tp_AdminCreateYears
            // 
            this.tp_AdminCreateYears.Controls.Add(this.btn_CreateSchoolYear);
            this.tp_AdminCreateYears.Controls.Add(this.txt_CreateSchoolYear);
            this.tp_AdminCreateYears.Controls.Add(this.lbl_CreateSchoolYear);
            this.tp_AdminCreateYears.Location = new System.Drawing.Point(4, 25);
            this.tp_AdminCreateYears.Name = "tp_AdminCreateYears";
            this.tp_AdminCreateYears.Padding = new System.Windows.Forms.Padding(3);
            this.tp_AdminCreateYears.Size = new System.Drawing.Size(783, 385);
            this.tp_AdminCreateYears.TabIndex = 1;
            this.tp_AdminCreateYears.Text = "Anos";
            this.tp_AdminCreateYears.UseVisualStyleBackColor = true;
            // 
            // tp_AdminCreateSubject
            // 
            this.tp_AdminCreateSubject.Controls.Add(this.btn_CreateSubject);
            this.tp_AdminCreateSubject.Controls.Add(this.lbl_SubjectAmmountOfClasses);
            this.tp_AdminCreateSubject.Controls.Add(this.txt_SubjectAmmountOfClasses);
            this.tp_AdminCreateSubject.Controls.Add(this.txt_SubjectAcronym);
            this.tp_AdminCreateSubject.Controls.Add(this.lbl_SubjectAcronym);
            this.tp_AdminCreateSubject.Controls.Add(this.lbl_SubjectName);
            this.tp_AdminCreateSubject.Controls.Add(this.txt_SubjectName);
            this.tp_AdminCreateSubject.Controls.Add(this.label1);
            this.tp_AdminCreateSubject.Controls.Add(this.tvw_CreateSubject);
            this.tp_AdminCreateSubject.Location = new System.Drawing.Point(4, 25);
            this.tp_AdminCreateSubject.Name = "tp_AdminCreateSubject";
            this.tp_AdminCreateSubject.Padding = new System.Windows.Forms.Padding(3);
            this.tp_AdminCreateSubject.Size = new System.Drawing.Size(783, 385);
            this.tp_AdminCreateSubject.TabIndex = 0;
            this.tp_AdminCreateSubject.Text = "Disciplinas";
            this.tp_AdminCreateSubject.UseVisualStyleBackColor = true;
            // 
            // tvw_CreateSubject
            // 
            this.tvw_CreateSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvw_CreateSubject.Location = new System.Drawing.Point(7, 26);
            this.tvw_CreateSubject.Name = "tvw_CreateSubject";
            this.tvw_CreateSubject.Size = new System.Drawing.Size(441, 353);
            this.tvw_CreateSubject.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecionar a turma";
            // 
            // txt_SubjectName
            // 
            this.txt_SubjectName.Location = new System.Drawing.Point(457, 27);
            this.txt_SubjectName.Name = "txt_SubjectName";
            this.txt_SubjectName.Size = new System.Drawing.Size(204, 22);
            this.txt_SubjectName.TabIndex = 2;
            // 
            // lbl_SubjectName
            // 
            this.lbl_SubjectName.AutoSize = true;
            this.lbl_SubjectName.Location = new System.Drawing.Point(454, 7);
            this.lbl_SubjectName.Name = "lbl_SubjectName";
            this.lbl_SubjectName.Size = new System.Drawing.Size(127, 17);
            this.lbl_SubjectName.TabIndex = 3;
            this.lbl_SubjectName.Text = "Nome da disciplina";
            // 
            // lbl_SubjectAcronym
            // 
            this.lbl_SubjectAcronym.AutoSize = true;
            this.lbl_SubjectAcronym.Location = new System.Drawing.Point(454, 64);
            this.lbl_SubjectAcronym.Name = "lbl_SubjectAcronym";
            this.lbl_SubjectAcronym.Size = new System.Drawing.Size(121, 17);
            this.lbl_SubjectAcronym.TabIndex = 4;
            this.lbl_SubjectAcronym.Text = "Sigla da disciplina";
            // 
            // txt_SubjectAcronym
            // 
            this.txt_SubjectAcronym.Location = new System.Drawing.Point(457, 84);
            this.txt_SubjectAcronym.Name = "txt_SubjectAcronym";
            this.txt_SubjectAcronym.Size = new System.Drawing.Size(131, 22);
            this.txt_SubjectAcronym.TabIndex = 5;
            // 
            // txt_SubjectAmmountOfClasses
            // 
            this.txt_SubjectAmmountOfClasses.Location = new System.Drawing.Point(457, 144);
            this.txt_SubjectAmmountOfClasses.Name = "txt_SubjectAmmountOfClasses";
            this.txt_SubjectAmmountOfClasses.Size = new System.Drawing.Size(100, 22);
            this.txt_SubjectAmmountOfClasses.TabIndex = 6;
            this.txt_SubjectAmmountOfClasses.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_SubjectAmmountOfClasses
            // 
            this.lbl_SubjectAmmountOfClasses.AutoSize = true;
            this.lbl_SubjectAmmountOfClasses.Location = new System.Drawing.Point(454, 124);
            this.lbl_SubjectAmmountOfClasses.Name = "lbl_SubjectAmmountOfClasses";
            this.lbl_SubjectAmmountOfClasses.Size = new System.Drawing.Size(141, 17);
            this.lbl_SubjectAmmountOfClasses.TabIndex = 7;
            this.lbl_SubjectAmmountOfClasses.Text = "Quantidade de Aulas";
            // 
            // btn_CreateSubject
            // 
            this.btn_CreateSubject.Location = new System.Drawing.Point(457, 197);
            this.btn_CreateSubject.Name = "btn_CreateSubject";
            this.btn_CreateSubject.Size = new System.Drawing.Size(320, 23);
            this.btn_CreateSubject.TabIndex = 8;
            this.btn_CreateSubject.Text = "Confirmar";
            this.btn_CreateSubject.UseVisualStyleBackColor = true;
            this.btn_CreateSubject.Click += new System.EventHandler(this.btn_CreateSubject_Click);
            // 
            // tp_StudentsPage
            // 
            this.tp_StudentsPage.BackColor = System.Drawing.Color.White;
            this.tp_StudentsPage.Controls.Add(this.lbl_StudentChooseClass);
            this.tp_StudentsPage.Controls.Add(this.tvw_Year_Class_Student);
            this.tp_StudentsPage.Controls.Add(this.chb_show_Password);
            this.tp_StudentsPage.Controls.Add(this.txt_StudentPassword);
            this.tp_StudentsPage.Controls.Add(this.txt_StudentNumber);
            this.tp_StudentsPage.Controls.Add(this.txt_StudentNIF);
            this.tp_StudentsPage.Controls.Add(this.txt_StudentContact);
            this.tp_StudentsPage.Controls.Add(this.txt_StudentAddress);
            this.tp_StudentsPage.Controls.Add(this.txt_StudentName);
            this.tp_StudentsPage.Controls.Add(this.lbl_StudentPassword);
            this.tp_StudentsPage.Controls.Add(this.btn_StudentConfirm);
            this.tp_StudentsPage.Controls.Add(this.lbl_StudentNumber);
            this.tp_StudentsPage.Controls.Add(this.lbl_StudentNIF);
            this.tp_StudentsPage.Controls.Add(this.lbl_StudentContact);
            this.tp_StudentsPage.Controls.Add(this.lbl_StudentAddress);
            this.tp_StudentsPage.Controls.Add(this.lbl_StudentName);
            this.tp_StudentsPage.Location = new System.Drawing.Point(4, 25);
            this.tp_StudentsPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tp_StudentsPage.Name = "tp_StudentsPage";
            this.tp_StudentsPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tp_StudentsPage.Size = new System.Drawing.Size(803, 420);
            this.tp_StudentsPage.TabIndex = 1;
            this.tp_StudentsPage.Text = "Alunos";
            // 
            // lbl_StudentName
            // 
            this.lbl_StudentName.AutoSize = true;
            this.lbl_StudentName.Location = new System.Drawing.Point(7, 2);
            this.lbl_StudentName.Name = "lbl_StudentName";
            this.lbl_StudentName.Size = new System.Drawing.Size(45, 17);
            this.lbl_StudentName.TabIndex = 15;
            this.lbl_StudentName.Text = "Nome";
            // 
            // txt_StudentName
            // 
            this.txt_StudentName.Location = new System.Drawing.Point(11, 25);
            this.txt_StudentName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_StudentName.Name = "txt_StudentName";
            this.txt_StudentName.Size = new System.Drawing.Size(168, 22);
            this.txt_StudentName.TabIndex = 16;
            // 
            // lbl_StudentAddress
            // 
            this.lbl_StudentAddress.AutoSize = true;
            this.lbl_StudentAddress.Location = new System.Drawing.Point(7, 54);
            this.lbl_StudentAddress.Name = "lbl_StudentAddress";
            this.lbl_StudentAddress.Size = new System.Drawing.Size(56, 17);
            this.lbl_StudentAddress.TabIndex = 17;
            this.lbl_StudentAddress.Text = "Morada";
            // 
            // txt_StudentAddress
            // 
            this.txt_StudentAddress.Location = new System.Drawing.Point(11, 74);
            this.txt_StudentAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_StudentAddress.Name = "txt_StudentAddress";
            this.txt_StudentAddress.Size = new System.Drawing.Size(315, 22);
            this.txt_StudentAddress.TabIndex = 18;
            // 
            // lbl_StudentContact
            // 
            this.lbl_StudentContact.AutoSize = true;
            this.lbl_StudentContact.Location = new System.Drawing.Point(7, 108);
            this.lbl_StudentContact.Name = "lbl_StudentContact";
            this.lbl_StudentContact.Size = new System.Drawing.Size(64, 17);
            this.lbl_StudentContact.TabIndex = 19;
            this.lbl_StudentContact.Text = "Contacto";
            // 
            // txt_StudentContact
            // 
            this.txt_StudentContact.Location = new System.Drawing.Point(11, 129);
            this.txt_StudentContact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_StudentContact.Name = "txt_StudentContact";
            this.txt_StudentContact.Size = new System.Drawing.Size(168, 22);
            this.txt_StudentContact.TabIndex = 20;
            // 
            // lbl_StudentNIF
            // 
            this.lbl_StudentNIF.AutoSize = true;
            this.lbl_StudentNIF.Location = new System.Drawing.Point(7, 162);
            this.lbl_StudentNIF.Name = "lbl_StudentNIF";
            this.lbl_StudentNIF.Size = new System.Drawing.Size(29, 17);
            this.lbl_StudentNIF.TabIndex = 21;
            this.lbl_StudentNIF.Text = "NIF";
            // 
            // txt_StudentNIF
            // 
            this.txt_StudentNIF.Location = new System.Drawing.Point(11, 185);
            this.txt_StudentNIF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_StudentNIF.MaxLength = 9;
            this.txt_StudentNIF.Name = "txt_StudentNIF";
            this.txt_StudentNIF.Size = new System.Drawing.Size(168, 22);
            this.txt_StudentNIF.TabIndex = 22;
            // 
            // lbl_StudentNumber
            // 
            this.lbl_StudentNumber.AutoSize = true;
            this.lbl_StudentNumber.Location = new System.Drawing.Point(8, 284);
            this.lbl_StudentNumber.Name = "lbl_StudentNumber";
            this.lbl_StudentNumber.Size = new System.Drawing.Size(98, 17);
            this.lbl_StudentNumber.TabIndex = 23;
            this.lbl_StudentNumber.Text = "Numero Aluno";
            // 
            // txt_StudentNumber
            // 
            this.txt_StudentNumber.Location = new System.Drawing.Point(12, 305);
            this.txt_StudentNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_StudentNumber.Name = "txt_StudentNumber";
            this.txt_StudentNumber.ReadOnly = true;
            this.txt_StudentNumber.Size = new System.Drawing.Size(133, 22);
            this.txt_StudentNumber.TabIndex = 24;
            this.txt_StudentNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_StudentConfirm
            // 
            this.btn_StudentConfirm.Location = new System.Drawing.Point(692, 391);
            this.btn_StudentConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_StudentConfirm.Name = "btn_StudentConfirm";
            this.btn_StudentConfirm.Size = new System.Drawing.Size(105, 23);
            this.btn_StudentConfirm.TabIndex = 25;
            this.btn_StudentConfirm.Text = "Confirmar";
            this.btn_StudentConfirm.UseVisualStyleBackColor = true;
            this.btn_StudentConfirm.Click += new System.EventHandler(this.btn_StudentConfirm_Click);
            // 
            // lbl_StudentPassword
            // 
            this.lbl_StudentPassword.AutoSize = true;
            this.lbl_StudentPassword.Location = new System.Drawing.Point(8, 219);
            this.lbl_StudentPassword.Name = "lbl_StudentPassword";
            this.lbl_StudentPassword.Size = new System.Drawing.Size(69, 17);
            this.lbl_StudentPassword.TabIndex = 26;
            this.lbl_StudentPassword.Text = "Password";
            // 
            // txt_StudentPassword
            // 
            this.txt_StudentPassword.Location = new System.Drawing.Point(12, 242);
            this.txt_StudentPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_StudentPassword.MaxLength = 9;
            this.txt_StudentPassword.Name = "txt_StudentPassword";
            this.txt_StudentPassword.PasswordChar = '*';
            this.txt_StudentPassword.Size = new System.Drawing.Size(168, 22);
            this.txt_StudentPassword.TabIndex = 27;
            // 
            // chb_show_Password
            // 
            this.chb_show_Password.Appearance = System.Windows.Forms.Appearance.Button;
            this.chb_show_Password.AutoSize = true;
            this.chb_show_Password.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chb_show_Password.BackgroundImage")));
            this.chb_show_Password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chb_show_Password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chb_show_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_show_Password.Location = new System.Drawing.Point(187, 242);
            this.chb_show_Password.Margin = new System.Windows.Forms.Padding(4);
            this.chb_show_Password.Name = "chb_show_Password";
            this.chb_show_Password.Size = new System.Drawing.Size(41, 23);
            this.chb_show_Password.TabIndex = 28;
            this.chb_show_Password.Text = "        ";
            this.chb_show_Password.UseVisualStyleBackColor = true;
            this.chb_show_Password.CheckedChanged += new System.EventHandler(this.chb_show_Password_CheckedChanged);
            // 
            // tvw_Year_Class_Student
            // 
            this.tvw_Year_Class_Student.BackColor = System.Drawing.Color.White;
            this.tvw_Year_Class_Student.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvw_Year_Class_Student.Location = new System.Drawing.Point(328, 18);
            this.tvw_Year_Class_Student.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tvw_Year_Class_Student.Name = "tvw_Year_Class_Student";
            this.tvw_Year_Class_Student.Size = new System.Drawing.Size(467, 368);
            this.tvw_Year_Class_Student.TabIndex = 29;
            // 
            // lbl_StudentChooseClass
            // 
            this.lbl_StudentChooseClass.AutoSize = true;
            this.lbl_StudentChooseClass.Location = new System.Drawing.Point(324, 2);
            this.lbl_StudentChooseClass.Name = "lbl_StudentChooseClass";
            this.lbl_StudentChooseClass.Size = new System.Drawing.Size(109, 17);
            this.lbl_StudentChooseClass.TabIndex = 30;
            this.lbl_StudentChooseClass.Text = "Turma do Aluno";
            // 
            // tp_TeachersPage
            // 
            this.tp_TeachersPage.BackColor = System.Drawing.Color.White;
            this.tp_TeachersPage.Controls.Add(this.chb_TeacherShowPassword);
            this.tp_TeachersPage.Controls.Add(this.txt_TeacherPassword);
            this.tp_TeachersPage.Controls.Add(this.txt_TeacherNumber);
            this.tp_TeachersPage.Controls.Add(this.txt_TeacherNIF);
            this.tp_TeachersPage.Controls.Add(this.txt_TeacherContact);
            this.tp_TeachersPage.Controls.Add(this.txt_TeacherAddress);
            this.tp_TeachersPage.Controls.Add(this.txt_TeacherName);
            this.tp_TeachersPage.Controls.Add(this.lbl_TeacherPassword);
            this.tp_TeachersPage.Controls.Add(this.btn_TeacherConfirm);
            this.tp_TeachersPage.Controls.Add(this.lbl_TeacherNumber);
            this.tp_TeachersPage.Controls.Add(this.tvw_TeacherYearsAndSubjects);
            this.tp_TeachersPage.Controls.Add(this.lbl_TeacherYearsAndSubjects);
            this.tp_TeachersPage.Controls.Add(this.lbl_TeacherNIF);
            this.tp_TeachersPage.Controls.Add(this.lbl_TeacherContact);
            this.tp_TeachersPage.Controls.Add(this.lbl_TeacherAddress);
            this.tp_TeachersPage.Controls.Add(this.lbl_TeacherName);
            this.tp_TeachersPage.Location = new System.Drawing.Point(4, 25);
            this.tp_TeachersPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tp_TeachersPage.Name = "tp_TeachersPage";
            this.tp_TeachersPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tp_TeachersPage.Size = new System.Drawing.Size(803, 420);
            this.tp_TeachersPage.TabIndex = 0;
            this.tp_TeachersPage.Text = "Professores";
            // 
            // lbl_TeacherName
            // 
            this.lbl_TeacherName.AutoSize = true;
            this.lbl_TeacherName.Location = new System.Drawing.Point(8, 7);
            this.lbl_TeacherName.Name = "lbl_TeacherName";
            this.lbl_TeacherName.Size = new System.Drawing.Size(45, 17);
            this.lbl_TeacherName.TabIndex = 0;
            this.lbl_TeacherName.Text = "Nome";
            // 
            // txt_TeacherName
            // 
            this.txt_TeacherName.Location = new System.Drawing.Point(11, 28);
            this.txt_TeacherName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TeacherName.Name = "txt_TeacherName";
            this.txt_TeacherName.Size = new System.Drawing.Size(168, 22);
            this.txt_TeacherName.TabIndex = 1;
            this.txt_TeacherName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TeacherName_KeyPress);
            // 
            // lbl_TeacherAddress
            // 
            this.lbl_TeacherAddress.AutoSize = true;
            this.lbl_TeacherAddress.Location = new System.Drawing.Point(8, 58);
            this.lbl_TeacherAddress.Name = "lbl_TeacherAddress";
            this.lbl_TeacherAddress.Size = new System.Drawing.Size(56, 17);
            this.lbl_TeacherAddress.TabIndex = 2;
            this.lbl_TeacherAddress.Text = "Morada";
            // 
            // txt_TeacherAddress
            // 
            this.txt_TeacherAddress.Location = new System.Drawing.Point(11, 78);
            this.txt_TeacherAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TeacherAddress.Name = "txt_TeacherAddress";
            this.txt_TeacherAddress.Size = new System.Drawing.Size(315, 22);
            this.txt_TeacherAddress.TabIndex = 3;
            // 
            // lbl_TeacherContact
            // 
            this.lbl_TeacherContact.AutoSize = true;
            this.lbl_TeacherContact.Location = new System.Drawing.Point(8, 112);
            this.lbl_TeacherContact.Name = "lbl_TeacherContact";
            this.lbl_TeacherContact.Size = new System.Drawing.Size(64, 17);
            this.lbl_TeacherContact.TabIndex = 4;
            this.lbl_TeacherContact.Text = "Contacto";
            // 
            // txt_TeacherContact
            // 
            this.txt_TeacherContact.Location = new System.Drawing.Point(11, 133);
            this.txt_TeacherContact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TeacherContact.Name = "txt_TeacherContact";
            this.txt_TeacherContact.Size = new System.Drawing.Size(168, 22);
            this.txt_TeacherContact.TabIndex = 5;
            this.txt_TeacherContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TeacherContact_KeyPress);
            // 
            // lbl_TeacherNIF
            // 
            this.lbl_TeacherNIF.AutoSize = true;
            this.lbl_TeacherNIF.Location = new System.Drawing.Point(8, 167);
            this.lbl_TeacherNIF.Name = "lbl_TeacherNIF";
            this.lbl_TeacherNIF.Size = new System.Drawing.Size(29, 17);
            this.lbl_TeacherNIF.TabIndex = 6;
            this.lbl_TeacherNIF.Text = "NIF";
            // 
            // txt_TeacherNIF
            // 
            this.txt_TeacherNIF.Location = new System.Drawing.Point(11, 188);
            this.txt_TeacherNIF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TeacherNIF.MaxLength = 9;
            this.txt_TeacherNIF.Name = "txt_TeacherNIF";
            this.txt_TeacherNIF.Size = new System.Drawing.Size(168, 22);
            this.txt_TeacherNIF.TabIndex = 7;
            this.txt_TeacherNIF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TeacherNIF_KeyPress);
            // 
            // lbl_TeacherYearsAndSubjects
            // 
            this.lbl_TeacherYearsAndSubjects.AutoSize = true;
            this.lbl_TeacherYearsAndSubjects.Location = new System.Drawing.Point(328, 7);
            this.lbl_TeacherYearsAndSubjects.Name = "lbl_TeacherYearsAndSubjects";
            this.lbl_TeacherYearsAndSubjects.Size = new System.Drawing.Size(211, 17);
            this.lbl_TeacherYearsAndSubjects.TabIndex = 8;
            this.lbl_TeacherYearsAndSubjects.Text = "Ano(s) e disciplina(s) a lecionar ";
            // 
            // tvw_TeacherYearsAndSubjects
            // 
            this.tvw_TeacherYearsAndSubjects.BackColor = System.Drawing.Color.White;
            this.tvw_TeacherYearsAndSubjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvw_TeacherYearsAndSubjects.CheckBoxes = true;
            this.tvw_TeacherYearsAndSubjects.Location = new System.Drawing.Point(331, 28);
            this.tvw_TeacherYearsAndSubjects.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tvw_TeacherYearsAndSubjects.Name = "tvw_TeacherYearsAndSubjects";
            this.tvw_TeacherYearsAndSubjects.Size = new System.Drawing.Size(467, 362);
            this.tvw_TeacherYearsAndSubjects.TabIndex = 12;
            this.tvw_TeacherYearsAndSubjects.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvw_TeacherYearsAndSubjects_AfterCheck);
            // 
            // lbl_TeacherNumber
            // 
            this.lbl_TeacherNumber.AutoSize = true;
            this.lbl_TeacherNumber.Location = new System.Drawing.Point(8, 283);
            this.lbl_TeacherNumber.Name = "lbl_TeacherNumber";
            this.lbl_TeacherNumber.Size = new System.Drawing.Size(136, 17);
            this.lbl_TeacherNumber.TabIndex = 13;
            this.lbl_TeacherNumber.Text = "Numero Funcionário";
            // 
            // txt_TeacherNumber
            // 
            this.txt_TeacherNumber.Location = new System.Drawing.Point(11, 304);
            this.txt_TeacherNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TeacherNumber.Name = "txt_TeacherNumber";
            this.txt_TeacherNumber.ReadOnly = true;
            this.txt_TeacherNumber.Size = new System.Drawing.Size(133, 22);
            this.txt_TeacherNumber.TabIndex = 14;
            this.txt_TeacherNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_TeacherConfirm
            // 
            this.btn_TeacherConfirm.Location = new System.Drawing.Point(692, 391);
            this.btn_TeacherConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_TeacherConfirm.Name = "btn_TeacherConfirm";
            this.btn_TeacherConfirm.Size = new System.Drawing.Size(105, 23);
            this.btn_TeacherConfirm.TabIndex = 26;
            this.btn_TeacherConfirm.Text = "Confirmar";
            this.btn_TeacherConfirm.UseVisualStyleBackColor = true;
            this.btn_TeacherConfirm.Click += new System.EventHandler(this.btn_TeacherConfirm_Click);
            // 
            // lbl_TeacherPassword
            // 
            this.lbl_TeacherPassword.AutoSize = true;
            this.lbl_TeacherPassword.Location = new System.Drawing.Point(8, 226);
            this.lbl_TeacherPassword.Name = "lbl_TeacherPassword";
            this.lbl_TeacherPassword.Size = new System.Drawing.Size(69, 17);
            this.lbl_TeacherPassword.TabIndex = 29;
            this.lbl_TeacherPassword.Text = "Password";
            // 
            // txt_TeacherPassword
            // 
            this.txt_TeacherPassword.Location = new System.Drawing.Point(12, 250);
            this.txt_TeacherPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TeacherPassword.MaxLength = 9;
            this.txt_TeacherPassword.Name = "txt_TeacherPassword";
            this.txt_TeacherPassword.PasswordChar = '*';
            this.txt_TeacherPassword.Size = new System.Drawing.Size(168, 22);
            this.txt_TeacherPassword.TabIndex = 30;
            // 
            // chb_TeacherShowPassword
            // 
            this.chb_TeacherShowPassword.Appearance = System.Windows.Forms.Appearance.Button;
            this.chb_TeacherShowPassword.AutoSize = true;
            this.chb_TeacherShowPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chb_TeacherShowPassword.BackgroundImage")));
            this.chb_TeacherShowPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chb_TeacherShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chb_TeacherShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_TeacherShowPassword.Location = new System.Drawing.Point(187, 250);
            this.chb_TeacherShowPassword.Margin = new System.Windows.Forms.Padding(4);
            this.chb_TeacherShowPassword.Name = "chb_TeacherShowPassword";
            this.chb_TeacherShowPassword.Size = new System.Drawing.Size(41, 23);
            this.chb_TeacherShowPassword.TabIndex = 31;
            this.chb_TeacherShowPassword.Text = "        ";
            this.chb_TeacherShowPassword.UseVisualStyleBackColor = true;
            this.chb_TeacherShowPassword.CheckedChanged += new System.EventHandler(this.chb_TeacherShowPassword_CheckedChanged);
            // 
            // tc_Choices
            // 
            this.tc_Choices.Controls.Add(this.tp_TeachersPage);
            this.tc_Choices.Controls.Add(this.tp_StudentsPage);
            this.tc_Choices.Controls.Add(this.tp_AdminCreateThings);
            this.tc_Choices.Location = new System.Drawing.Point(1, 0);
            this.tc_Choices.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tc_Choices.Name = "tc_Choices";
            this.tc_Choices.SelectedIndex = 0;
            this.tc_Choices.Size = new System.Drawing.Size(811, 449);
            this.tc_Choices.TabIndex = 0;
            this.tc_Choices.SelectedIndexChanged += new System.EventHandler(this.tc_Choices_SelectedIndexChanged);
            // 
            // lbl_CreateSchoolYear
            // 
            this.lbl_CreateSchoolYear.AutoSize = true;
            this.lbl_CreateSchoolYear.Location = new System.Drawing.Point(7, 7);
            this.lbl_CreateSchoolYear.Name = "lbl_CreateSchoolYear";
            this.lbl_CreateSchoolYear.Size = new System.Drawing.Size(33, 17);
            this.lbl_CreateSchoolYear.TabIndex = 0;
            this.lbl_CreateSchoolYear.Text = "Ano";
            // 
            // txt_CreateSchoolYear
            // 
            this.txt_CreateSchoolYear.Location = new System.Drawing.Point(10, 27);
            this.txt_CreateSchoolYear.Name = "txt_CreateSchoolYear";
            this.txt_CreateSchoolYear.Size = new System.Drawing.Size(100, 22);
            this.txt_CreateSchoolYear.TabIndex = 1;
            // 
            // btn_CreateSchoolYear
            // 
            this.btn_CreateSchoolYear.Location = new System.Drawing.Point(10, 56);
            this.btn_CreateSchoolYear.Name = "btn_CreateSchoolYear";
            this.btn_CreateSchoolYear.Size = new System.Drawing.Size(100, 23);
            this.btn_CreateSchoolYear.TabIndex = 2;
            this.btn_CreateSchoolYear.Text = "Confirmar";
            this.btn_CreateSchoolYear.UseVisualStyleBackColor = true;
            // 
            // Admin_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 450);
            this.Controls.Add(this.tc_Choices);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Admin_Panel";
            this.Text = "Admin_Panel";
            this.Load += new System.EventHandler(this.Admin_Panel_Load);
            this.tp_AdminCreateThings.ResumeLayout(false);
            this.tc_AdminCreateThings.ResumeLayout(false);
            this.tp_AdminCreateYears.ResumeLayout(false);
            this.tp_AdminCreateYears.PerformLayout();
            this.tp_AdminCreateSubject.ResumeLayout(false);
            this.tp_AdminCreateSubject.PerformLayout();
            this.tp_StudentsPage.ResumeLayout(false);
            this.tp_StudentsPage.PerformLayout();
            this.tp_TeachersPage.ResumeLayout(false);
            this.tp_TeachersPage.PerformLayout();
            this.tc_Choices.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabPage tp_AdminCreateThings;
        private System.Windows.Forms.TabControl tc_AdminCreateThings;
        private System.Windows.Forms.TabPage tp_AdminCreateSubject;
        private System.Windows.Forms.Button btn_CreateSubject;
        private System.Windows.Forms.Label lbl_SubjectAmmountOfClasses;
        private System.Windows.Forms.TextBox txt_SubjectAmmountOfClasses;
        private System.Windows.Forms.TextBox txt_SubjectAcronym;
        private System.Windows.Forms.Label lbl_SubjectAcronym;
        private System.Windows.Forms.Label lbl_SubjectName;
        private System.Windows.Forms.TextBox txt_SubjectName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView tvw_CreateSubject;
        private System.Windows.Forms.TabPage tp_AdminCreateYears;
        private System.Windows.Forms.Button btn_CreateSchoolYear;
        private System.Windows.Forms.TextBox txt_CreateSchoolYear;
        private System.Windows.Forms.Label lbl_CreateSchoolYear;
        private System.Windows.Forms.TabPage tp_StudentsPage;
        private System.Windows.Forms.Label lbl_StudentChooseClass;
        private System.Windows.Forms.TreeView tvw_Year_Class_Student;
        private System.Windows.Forms.CheckBox chb_show_Password;
        private System.Windows.Forms.TextBox txt_StudentPassword;
        private System.Windows.Forms.TextBox txt_StudentNumber;
        private System.Windows.Forms.TextBox txt_StudentNIF;
        private System.Windows.Forms.TextBox txt_StudentContact;
        private System.Windows.Forms.TextBox txt_StudentAddress;
        private System.Windows.Forms.TextBox txt_StudentName;
        private System.Windows.Forms.Label lbl_StudentPassword;
        private System.Windows.Forms.Button btn_StudentConfirm;
        private System.Windows.Forms.Label lbl_StudentNumber;
        private System.Windows.Forms.Label lbl_StudentNIF;
        private System.Windows.Forms.Label lbl_StudentContact;
        private System.Windows.Forms.Label lbl_StudentAddress;
        private System.Windows.Forms.Label lbl_StudentName;
        private System.Windows.Forms.TabPage tp_TeachersPage;
        private System.Windows.Forms.CheckBox chb_TeacherShowPassword;
        private System.Windows.Forms.TextBox txt_TeacherPassword;
        private System.Windows.Forms.TextBox txt_TeacherNumber;
        private System.Windows.Forms.TextBox txt_TeacherNIF;
        private System.Windows.Forms.TextBox txt_TeacherContact;
        private System.Windows.Forms.TextBox txt_TeacherAddress;
        private System.Windows.Forms.TextBox txt_TeacherName;
        private System.Windows.Forms.Label lbl_TeacherPassword;
        private System.Windows.Forms.Button btn_TeacherConfirm;
        private System.Windows.Forms.Label lbl_TeacherNumber;
        private System.Windows.Forms.TreeView tvw_TeacherYearsAndSubjects;
        private System.Windows.Forms.Label lbl_TeacherYearsAndSubjects;
        private System.Windows.Forms.Label lbl_TeacherNIF;
        private System.Windows.Forms.Label lbl_TeacherContact;
        private System.Windows.Forms.Label lbl_TeacherAddress;
        private System.Windows.Forms.Label lbl_TeacherName;
        private System.Windows.Forms.TabControl tc_Choices;
    }
}