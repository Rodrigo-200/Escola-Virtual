
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
            this.tc_Choices = new System.Windows.Forms.TabControl();
            this.tp_TeachersPage = new System.Windows.Forms.TabPage();
            this.btn_TeacherConfirm = new System.Windows.Forms.Button();
            this.txt_TeacherNumber = new System.Windows.Forms.TextBox();
            this.lbl_TeacherNumber = new System.Windows.Forms.Label();
            this.tvw_TeacherYearsAndSubjects = new System.Windows.Forms.TreeView();
            this.lbl_TeacherYearsAndSubjects = new System.Windows.Forms.Label();
            this.txt_TeacherNIF = new System.Windows.Forms.TextBox();
            this.lbl_TeacherNIF = new System.Windows.Forms.Label();
            this.txt_TeacherContact = new System.Windows.Forms.TextBox();
            this.lbl_TeacherContact = new System.Windows.Forms.Label();
            this.txt_TeacherAddress = new System.Windows.Forms.TextBox();
            this.lbl_TeacherAddress = new System.Windows.Forms.Label();
            this.txt_TeacherName = new System.Windows.Forms.TextBox();
            this.lbl_TeacherName = new System.Windows.Forms.Label();
            this.tp_StudentsPage = new System.Windows.Forms.TabPage();
            this.chb_show_Password = new System.Windows.Forms.CheckBox();
            this.txt_StudentPassword = new System.Windows.Forms.TextBox();
            this.lbl_StudentPassword = new System.Windows.Forms.Label();
            this.btn_StudentConfirm = new System.Windows.Forms.Button();
            this.txt_StudentNumber = new System.Windows.Forms.TextBox();
            this.lbl_StudentNumber = new System.Windows.Forms.Label();
            this.txt_StudentNIF = new System.Windows.Forms.TextBox();
            this.lbl_StudentNIF = new System.Windows.Forms.Label();
            this.txt_StudentContact = new System.Windows.Forms.TextBox();
            this.lbl_StudentContact = new System.Windows.Forms.Label();
            this.txt_StudentAddress = new System.Windows.Forms.TextBox();
            this.lbl_StudentAddress = new System.Windows.Forms.Label();
            this.txt_StudentName = new System.Windows.Forms.TextBox();
            this.lbl_StudentName = new System.Windows.Forms.Label();
            this.chb_TeacherShowPassword = new System.Windows.Forms.CheckBox();
            this.txt_TeacherPassword = new System.Windows.Forms.TextBox();
            this.lbl_TeacherPassword = new System.Windows.Forms.Label();
            this.tvw_Year_Class_Student = new System.Windows.Forms.TreeView();
            this.lbl_StudentChooseClass = new System.Windows.Forms.Label();
            this.tc_Choices.SuspendLayout();
            this.tp_TeachersPage.SuspendLayout();
            this.tp_StudentsPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc_Choices
            // 
            this.tc_Choices.Controls.Add(this.tp_TeachersPage);
            this.tc_Choices.Controls.Add(this.tp_StudentsPage);
            this.tc_Choices.Location = new System.Drawing.Point(1, 0);
            this.tc_Choices.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tc_Choices.Name = "tc_Choices";
            this.tc_Choices.SelectedIndex = 0;
            this.tc_Choices.Size = new System.Drawing.Size(608, 365);
            this.tc_Choices.TabIndex = 0;
            // 
            // tp_TeachersPage
            // 
            this.tp_TeachersPage.BackColor = System.Drawing.Color.White;
            this.tp_TeachersPage.Controls.Add(this.chb_TeacherShowPassword);
            this.tp_TeachersPage.Controls.Add(this.txt_TeacherPassword);
            this.tp_TeachersPage.Controls.Add(this.lbl_TeacherPassword);
            this.tp_TeachersPage.Controls.Add(this.btn_TeacherConfirm);
            this.tp_TeachersPage.Controls.Add(this.txt_TeacherNumber);
            this.tp_TeachersPage.Controls.Add(this.lbl_TeacherNumber);
            this.tp_TeachersPage.Controls.Add(this.tvw_TeacherYearsAndSubjects);
            this.tp_TeachersPage.Controls.Add(this.lbl_TeacherYearsAndSubjects);
            this.tp_TeachersPage.Controls.Add(this.txt_TeacherNIF);
            this.tp_TeachersPage.Controls.Add(this.lbl_TeacherNIF);
            this.tp_TeachersPage.Controls.Add(this.txt_TeacherContact);
            this.tp_TeachersPage.Controls.Add(this.lbl_TeacherContact);
            this.tp_TeachersPage.Controls.Add(this.txt_TeacherAddress);
            this.tp_TeachersPage.Controls.Add(this.lbl_TeacherAddress);
            this.tp_TeachersPage.Controls.Add(this.txt_TeacherName);
            this.tp_TeachersPage.Controls.Add(this.lbl_TeacherName);
            this.tp_TeachersPage.Location = new System.Drawing.Point(4, 22);
            this.tp_TeachersPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tp_TeachersPage.Name = "tp_TeachersPage";
            this.tp_TeachersPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tp_TeachersPage.Size = new System.Drawing.Size(600, 339);
            this.tp_TeachersPage.TabIndex = 0;
            this.tp_TeachersPage.Text = "Professores";
            // 
            // btn_TeacherConfirm
            // 
            this.btn_TeacherConfirm.Location = new System.Drawing.Point(519, 318);
            this.btn_TeacherConfirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_TeacherConfirm.Name = "btn_TeacherConfirm";
            this.btn_TeacherConfirm.Size = new System.Drawing.Size(79, 19);
            this.btn_TeacherConfirm.TabIndex = 26;
            this.btn_TeacherConfirm.Text = "Confirmar";
            this.btn_TeacherConfirm.UseVisualStyleBackColor = true;
            this.btn_TeacherConfirm.Click += new System.EventHandler(this.btn_TeacherConfirm_Click);
            // 
            // txt_TeacherNumber
            // 
            this.txt_TeacherNumber.Location = new System.Drawing.Point(8, 247);
            this.txt_TeacherNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_TeacherNumber.Name = "txt_TeacherNumber";
            this.txt_TeacherNumber.ReadOnly = true;
            this.txt_TeacherNumber.Size = new System.Drawing.Size(101, 20);
            this.txt_TeacherNumber.TabIndex = 14;
            this.txt_TeacherNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_TeacherNumber
            // 
            this.lbl_TeacherNumber.AutoSize = true;
            this.lbl_TeacherNumber.Location = new System.Drawing.Point(6, 230);
            this.lbl_TeacherNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TeacherNumber.Name = "lbl_TeacherNumber";
            this.lbl_TeacherNumber.Size = new System.Drawing.Size(102, 13);
            this.lbl_TeacherNumber.TabIndex = 13;
            this.lbl_TeacherNumber.Text = "Numero Funcionário";
            // 
            // tvw_TeacherYearsAndSubjects
            // 
            this.tvw_TeacherYearsAndSubjects.BackColor = System.Drawing.Color.White;
            this.tvw_TeacherYearsAndSubjects.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvw_TeacherYearsAndSubjects.CheckBoxes = true;
            this.tvw_TeacherYearsAndSubjects.Location = new System.Drawing.Point(248, 22);
            this.tvw_TeacherYearsAndSubjects.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tvw_TeacherYearsAndSubjects.Name = "tvw_TeacherYearsAndSubjects";
            this.tvw_TeacherYearsAndSubjects.Size = new System.Drawing.Size(350, 294);
            this.tvw_TeacherYearsAndSubjects.TabIndex = 12;
            // 
            // lbl_TeacherYearsAndSubjects
            // 
            this.lbl_TeacherYearsAndSubjects.AutoSize = true;
            this.lbl_TeacherYearsAndSubjects.Location = new System.Drawing.Point(246, 6);
            this.lbl_TeacherYearsAndSubjects.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TeacherYearsAndSubjects.Name = "lbl_TeacherYearsAndSubjects";
            this.lbl_TeacherYearsAndSubjects.Size = new System.Drawing.Size(155, 13);
            this.lbl_TeacherYearsAndSubjects.TabIndex = 8;
            this.lbl_TeacherYearsAndSubjects.Text = "Ano(s) e disciplina(s) a lecionar ";
            // 
            // txt_TeacherNIF
            // 
            this.txt_TeacherNIF.Location = new System.Drawing.Point(8, 153);
            this.txt_TeacherNIF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_TeacherNIF.MaxLength = 9;
            this.txt_TeacherNIF.Name = "txt_TeacherNIF";
            this.txt_TeacherNIF.Size = new System.Drawing.Size(127, 20);
            this.txt_TeacherNIF.TabIndex = 7;
            this.txt_TeacherNIF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TeacherNIF_KeyPress);
            // 
            // lbl_TeacherNIF
            // 
            this.lbl_TeacherNIF.AutoSize = true;
            this.lbl_TeacherNIF.Location = new System.Drawing.Point(6, 136);
            this.lbl_TeacherNIF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TeacherNIF.Name = "lbl_TeacherNIF";
            this.lbl_TeacherNIF.Size = new System.Drawing.Size(24, 13);
            this.lbl_TeacherNIF.TabIndex = 6;
            this.lbl_TeacherNIF.Text = "NIF";
            // 
            // txt_TeacherContact
            // 
            this.txt_TeacherContact.Location = new System.Drawing.Point(8, 108);
            this.txt_TeacherContact.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_TeacherContact.Name = "txt_TeacherContact";
            this.txt_TeacherContact.Size = new System.Drawing.Size(127, 20);
            this.txt_TeacherContact.TabIndex = 5;
            this.txt_TeacherContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TeacherContact_KeyPress);
            // 
            // lbl_TeacherContact
            // 
            this.lbl_TeacherContact.AutoSize = true;
            this.lbl_TeacherContact.Location = new System.Drawing.Point(6, 91);
            this.lbl_TeacherContact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TeacherContact.Name = "lbl_TeacherContact";
            this.lbl_TeacherContact.Size = new System.Drawing.Size(50, 13);
            this.lbl_TeacherContact.TabIndex = 4;
            this.lbl_TeacherContact.Text = "Contacto";
            // 
            // txt_TeacherAddress
            // 
            this.txt_TeacherAddress.Location = new System.Drawing.Point(8, 63);
            this.txt_TeacherAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_TeacherAddress.Name = "txt_TeacherAddress";
            this.txt_TeacherAddress.Size = new System.Drawing.Size(237, 20);
            this.txt_TeacherAddress.TabIndex = 3;
            // 
            // lbl_TeacherAddress
            // 
            this.lbl_TeacherAddress.AutoSize = true;
            this.lbl_TeacherAddress.Location = new System.Drawing.Point(6, 47);
            this.lbl_TeacherAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TeacherAddress.Name = "lbl_TeacherAddress";
            this.lbl_TeacherAddress.Size = new System.Drawing.Size(43, 13);
            this.lbl_TeacherAddress.TabIndex = 2;
            this.lbl_TeacherAddress.Text = "Morada";
            // 
            // txt_TeacherName
            // 
            this.txt_TeacherName.Location = new System.Drawing.Point(8, 23);
            this.txt_TeacherName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_TeacherName.Name = "txt_TeacherName";
            this.txt_TeacherName.Size = new System.Drawing.Size(127, 20);
            this.txt_TeacherName.TabIndex = 1;
            this.txt_TeacherName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TeacherName_KeyPress);
            // 
            // lbl_TeacherName
            // 
            this.lbl_TeacherName.AutoSize = true;
            this.lbl_TeacherName.Location = new System.Drawing.Point(6, 6);
            this.lbl_TeacherName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TeacherName.Name = "lbl_TeacherName";
            this.lbl_TeacherName.Size = new System.Drawing.Size(35, 13);
            this.lbl_TeacherName.TabIndex = 0;
            this.lbl_TeacherName.Text = "Nome";
            // 
            // tp_StudentsPage
            // 
            this.tp_StudentsPage.BackColor = System.Drawing.Color.White;
            this.tp_StudentsPage.Controls.Add(this.lbl_StudentChooseClass);
            this.tp_StudentsPage.Controls.Add(this.tvw_Year_Class_Student);
            this.tp_StudentsPage.Controls.Add(this.chb_show_Password);
            this.tp_StudentsPage.Controls.Add(this.txt_StudentPassword);
            this.tp_StudentsPage.Controls.Add(this.lbl_StudentPassword);
            this.tp_StudentsPage.Controls.Add(this.btn_StudentConfirm);
            this.tp_StudentsPage.Controls.Add(this.txt_StudentNumber);
            this.tp_StudentsPage.Controls.Add(this.lbl_StudentNumber);
            this.tp_StudentsPage.Controls.Add(this.txt_StudentNIF);
            this.tp_StudentsPage.Controls.Add(this.lbl_StudentNIF);
            this.tp_StudentsPage.Controls.Add(this.txt_StudentContact);
            this.tp_StudentsPage.Controls.Add(this.lbl_StudentContact);
            this.tp_StudentsPage.Controls.Add(this.txt_StudentAddress);
            this.tp_StudentsPage.Controls.Add(this.lbl_StudentAddress);
            this.tp_StudentsPage.Controls.Add(this.txt_StudentName);
            this.tp_StudentsPage.Controls.Add(this.lbl_StudentName);
            this.tp_StudentsPage.Location = new System.Drawing.Point(4, 22);
            this.tp_StudentsPage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tp_StudentsPage.Name = "tp_StudentsPage";
            this.tp_StudentsPage.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tp_StudentsPage.Size = new System.Drawing.Size(600, 339);
            this.tp_StudentsPage.TabIndex = 1;
            this.tp_StudentsPage.Text = "Alunos";
            // 
            // chb_show_Password
            // 
            this.chb_show_Password.Appearance = System.Windows.Forms.Appearance.Button;
            this.chb_show_Password.AutoSize = true;
            this.chb_show_Password.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chb_show_Password.BackgroundImage")));
            this.chb_show_Password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chb_show_Password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chb_show_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_show_Password.Location = new System.Drawing.Point(140, 197);
            this.chb_show_Password.Name = "chb_show_Password";
            this.chb_show_Password.Size = new System.Drawing.Size(31, 19);
            this.chb_show_Password.TabIndex = 28;
            this.chb_show_Password.Text = "        ";
            this.chb_show_Password.UseVisualStyleBackColor = true;
            this.chb_show_Password.CheckedChanged += new System.EventHandler(this.chb_show_Password_CheckedChanged);
            // 
            // txt_StudentPassword
            // 
            this.txt_StudentPassword.Location = new System.Drawing.Point(9, 197);
            this.txt_StudentPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_StudentPassword.MaxLength = 9;
            this.txt_StudentPassword.Name = "txt_StudentPassword";
            this.txt_StudentPassword.PasswordChar = '*';
            this.txt_StudentPassword.Size = new System.Drawing.Size(127, 20);
            this.txt_StudentPassword.TabIndex = 27;
            // 
            // lbl_StudentPassword
            // 
            this.lbl_StudentPassword.AutoSize = true;
            this.lbl_StudentPassword.Location = new System.Drawing.Point(6, 178);
            this.lbl_StudentPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_StudentPassword.Name = "lbl_StudentPassword";
            this.lbl_StudentPassword.Size = new System.Drawing.Size(53, 13);
            this.lbl_StudentPassword.TabIndex = 26;
            this.lbl_StudentPassword.Text = "Password";
            // 
            // btn_StudentConfirm
            // 
            this.btn_StudentConfirm.Location = new System.Drawing.Point(16, 288);
            this.btn_StudentConfirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_StudentConfirm.Name = "btn_StudentConfirm";
            this.btn_StudentConfirm.Size = new System.Drawing.Size(79, 19);
            this.btn_StudentConfirm.TabIndex = 25;
            this.btn_StudentConfirm.Text = "Confirmar";
            this.btn_StudentConfirm.UseVisualStyleBackColor = true;
            this.btn_StudentConfirm.Click += new System.EventHandler(this.btn_StudentConfirm_Click);
            // 
            // txt_StudentNumber
            // 
            this.txt_StudentNumber.Location = new System.Drawing.Point(9, 248);
            this.txt_StudentNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_StudentNumber.Name = "txt_StudentNumber";
            this.txt_StudentNumber.ReadOnly = true;
            this.txt_StudentNumber.Size = new System.Drawing.Size(101, 20);
            this.txt_StudentNumber.TabIndex = 24;
            this.txt_StudentNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_StudentNumber
            // 
            this.lbl_StudentNumber.AutoSize = true;
            this.lbl_StudentNumber.Location = new System.Drawing.Point(6, 231);
            this.lbl_StudentNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_StudentNumber.Name = "lbl_StudentNumber";
            this.lbl_StudentNumber.Size = new System.Drawing.Size(74, 13);
            this.lbl_StudentNumber.TabIndex = 23;
            this.lbl_StudentNumber.Text = "Numero Aluno";
            // 
            // txt_StudentNIF
            // 
            this.txt_StudentNIF.Location = new System.Drawing.Point(8, 150);
            this.txt_StudentNIF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_StudentNIF.MaxLength = 9;
            this.txt_StudentNIF.Name = "txt_StudentNIF";
            this.txt_StudentNIF.Size = new System.Drawing.Size(127, 20);
            this.txt_StudentNIF.TabIndex = 22;
            // 
            // lbl_StudentNIF
            // 
            this.lbl_StudentNIF.AutoSize = true;
            this.lbl_StudentNIF.Location = new System.Drawing.Point(5, 132);
            this.lbl_StudentNIF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_StudentNIF.Name = "lbl_StudentNIF";
            this.lbl_StudentNIF.Size = new System.Drawing.Size(24, 13);
            this.lbl_StudentNIF.TabIndex = 21;
            this.lbl_StudentNIF.Text = "NIF";
            // 
            // txt_StudentContact
            // 
            this.txt_StudentContact.Location = new System.Drawing.Point(8, 105);
            this.txt_StudentContact.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_StudentContact.Name = "txt_StudentContact";
            this.txt_StudentContact.Size = new System.Drawing.Size(127, 20);
            this.txt_StudentContact.TabIndex = 20;
            // 
            // lbl_StudentContact
            // 
            this.lbl_StudentContact.AutoSize = true;
            this.lbl_StudentContact.Location = new System.Drawing.Point(5, 88);
            this.lbl_StudentContact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_StudentContact.Name = "lbl_StudentContact";
            this.lbl_StudentContact.Size = new System.Drawing.Size(50, 13);
            this.lbl_StudentContact.TabIndex = 19;
            this.lbl_StudentContact.Text = "Contacto";
            // 
            // txt_StudentAddress
            // 
            this.txt_StudentAddress.Location = new System.Drawing.Point(8, 60);
            this.txt_StudentAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_StudentAddress.Name = "txt_StudentAddress";
            this.txt_StudentAddress.Size = new System.Drawing.Size(237, 20);
            this.txt_StudentAddress.TabIndex = 18;
            // 
            // lbl_StudentAddress
            // 
            this.lbl_StudentAddress.AutoSize = true;
            this.lbl_StudentAddress.Location = new System.Drawing.Point(5, 44);
            this.lbl_StudentAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_StudentAddress.Name = "lbl_StudentAddress";
            this.lbl_StudentAddress.Size = new System.Drawing.Size(43, 13);
            this.lbl_StudentAddress.TabIndex = 17;
            this.lbl_StudentAddress.Text = "Morada";
            // 
            // txt_StudentName
            // 
            this.txt_StudentName.Location = new System.Drawing.Point(8, 20);
            this.txt_StudentName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_StudentName.Name = "txt_StudentName";
            this.txt_StudentName.Size = new System.Drawing.Size(127, 20);
            this.txt_StudentName.TabIndex = 16;
            // 
            // lbl_StudentName
            // 
            this.lbl_StudentName.AutoSize = true;
            this.lbl_StudentName.Location = new System.Drawing.Point(5, 2);
            this.lbl_StudentName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_StudentName.Name = "lbl_StudentName";
            this.lbl_StudentName.Size = new System.Drawing.Size(35, 13);
            this.lbl_StudentName.TabIndex = 15;
            this.lbl_StudentName.Text = "Nome";
            // 
            // chb_TeacherShowPassword
            // 
            this.chb_TeacherShowPassword.Appearance = System.Windows.Forms.Appearance.Button;
            this.chb_TeacherShowPassword.AutoSize = true;
            this.chb_TeacherShowPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chb_TeacherShowPassword.BackgroundImage")));
            this.chb_TeacherShowPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chb_TeacherShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chb_TeacherShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_TeacherShowPassword.Location = new System.Drawing.Point(140, 203);
            this.chb_TeacherShowPassword.Name = "chb_TeacherShowPassword";
            this.chb_TeacherShowPassword.Size = new System.Drawing.Size(31, 19);
            this.chb_TeacherShowPassword.TabIndex = 31;
            this.chb_TeacherShowPassword.Text = "        ";
            this.chb_TeacherShowPassword.UseVisualStyleBackColor = true;
            this.chb_TeacherShowPassword.CheckedChanged += new System.EventHandler(this.chb_TeacherShowPassword_CheckedChanged);
            // 
            // txt_TeacherPassword
            // 
            this.txt_TeacherPassword.Location = new System.Drawing.Point(9, 203);
            this.txt_TeacherPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TeacherPassword.MaxLength = 9;
            this.txt_TeacherPassword.Name = "txt_TeacherPassword";
            this.txt_TeacherPassword.PasswordChar = '*';
            this.txt_TeacherPassword.Size = new System.Drawing.Size(127, 20);
            this.txt_TeacherPassword.TabIndex = 30;
            // 
            // lbl_TeacherPassword
            // 
            this.lbl_TeacherPassword.AutoSize = true;
            this.lbl_TeacherPassword.Location = new System.Drawing.Point(6, 184);
            this.lbl_TeacherPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TeacherPassword.Name = "lbl_TeacherPassword";
            this.lbl_TeacherPassword.Size = new System.Drawing.Size(53, 13);
            this.lbl_TeacherPassword.TabIndex = 29;
            this.lbl_TeacherPassword.Text = "Password";
            // 
            // tvw_Year_Class_Student
            // 
            this.tvw_Year_Class_Student.BackColor = System.Drawing.Color.White;
            this.tvw_Year_Class_Student.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvw_Year_Class_Student.Location = new System.Drawing.Point(246, 15);
            this.tvw_Year_Class_Student.Margin = new System.Windows.Forms.Padding(2);
            this.tvw_Year_Class_Student.Name = "tvw_Year_Class_Student";
            this.tvw_Year_Class_Student.Size = new System.Drawing.Size(350, 318);
            this.tvw_Year_Class_Student.TabIndex = 29;
            // 
            // lbl_StudentChooseClass
            // 
            this.lbl_StudentChooseClass.AutoSize = true;
            this.lbl_StudentChooseClass.Location = new System.Drawing.Point(243, 2);
            this.lbl_StudentChooseClass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_StudentChooseClass.Name = "lbl_StudentChooseClass";
            this.lbl_StudentChooseClass.Size = new System.Drawing.Size(82, 13);
            this.lbl_StudentChooseClass.TabIndex = 30;
            this.lbl_StudentChooseClass.Text = "Turma do Aluno";
            // 
            // Admin_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 366);
            this.Controls.Add(this.tc_Choices);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Admin_Panel";
            this.Text = "Admin_Panel";
            this.Load += new System.EventHandler(this.Admin_Panel_Load);
            this.tc_Choices.ResumeLayout(false);
            this.tp_TeachersPage.ResumeLayout(false);
            this.tp_TeachersPage.PerformLayout();
            this.tp_StudentsPage.ResumeLayout(false);
            this.tp_StudentsPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabControl tc_Choices;
        private System.Windows.Forms.TabPage tp_TeachersPage;
        private System.Windows.Forms.TabPage tp_StudentsPage;
        private System.Windows.Forms.TextBox txt_TeacherName;
        private System.Windows.Forms.Label lbl_TeacherName;
        private System.Windows.Forms.TextBox txt_TeacherAddress;
        private System.Windows.Forms.Label lbl_TeacherAddress;
        private System.Windows.Forms.TextBox txt_TeacherContact;
        private System.Windows.Forms.Label lbl_TeacherContact;
        private System.Windows.Forms.TextBox txt_TeacherNIF;
        private System.Windows.Forms.Label lbl_TeacherNIF;
        private System.Windows.Forms.Label lbl_TeacherYearsAndSubjects;
        private System.Windows.Forms.TreeView tvw_TeacherYearsAndSubjects;
        private System.Windows.Forms.TextBox txt_TeacherNumber;
        private System.Windows.Forms.Label lbl_TeacherNumber;
        private System.Windows.Forms.TextBox txt_StudentNumber;
        private System.Windows.Forms.Label lbl_StudentNumber;
        private System.Windows.Forms.TextBox txt_StudentNIF;
        private System.Windows.Forms.Label lbl_StudentNIF;
        private System.Windows.Forms.TextBox txt_StudentContact;
        private System.Windows.Forms.Label lbl_StudentContact;
        private System.Windows.Forms.TextBox txt_StudentAddress;
        private System.Windows.Forms.Label lbl_StudentAddress;
        private System.Windows.Forms.TextBox txt_StudentName;
        private System.Windows.Forms.Label lbl_StudentName;
        private System.Windows.Forms.Button btn_StudentConfirm;
        private System.Windows.Forms.Button btn_TeacherConfirm;
        private System.Windows.Forms.TextBox txt_StudentPassword;
        private System.Windows.Forms.Label lbl_StudentPassword;
        private System.Windows.Forms.CheckBox chb_show_Password;
        private System.Windows.Forms.CheckBox chb_TeacherShowPassword;
        private System.Windows.Forms.TextBox txt_TeacherPassword;
        private System.Windows.Forms.Label lbl_TeacherPassword;
        private System.Windows.Forms.Label lbl_StudentChooseClass;
        private System.Windows.Forms.TreeView tvw_Year_Class_Student;
    }
}