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
            this.tc_Teacher.SuspendLayout();
            this.tp_StudentActions.SuspendLayout();
            this.tp_StudentProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc_Teacher
            // 
            this.tc_Teacher.Controls.Add(this.tp_StudentActions);
            this.tc_Teacher.Controls.Add(this.tp_StudentProfile);
            this.tc_Teacher.Location = new System.Drawing.Point(12, 12);
            this.tc_Teacher.Name = "tc_Teacher";
            this.tc_Teacher.SelectedIndex = 0;
            this.tc_Teacher.Size = new System.Drawing.Size(543, 471);
            this.tc_Teacher.TabIndex = 29;
            // 
            // tp_StudentActions
            // 
            this.tp_StudentActions.Controls.Add(this.txt_GradeValue);
            this.tp_StudentActions.Controls.Add(this.btn_GradeLaunch);
            this.tp_StudentActions.Controls.Add(this.lbl_GradeLaunch);
            this.tp_StudentActions.Controls.Add(this.tvw_GradeLaunch);
            this.tp_StudentActions.Location = new System.Drawing.Point(4, 22);
            this.tp_StudentActions.Name = "tp_StudentActions";
            this.tp_StudentActions.Padding = new System.Windows.Forms.Padding(3);
            this.tp_StudentActions.Size = new System.Drawing.Size(535, 445);
            this.tp_StudentActions.TabIndex = 0;
            this.tp_StudentActions.Text = "Ações";
            this.tp_StudentActions.UseVisualStyleBackColor = true;
            // 
            // txt_GradeValue
            // 
            this.txt_GradeValue.Location = new System.Drawing.Point(8, 402);
            this.txt_GradeValue.MaxLength = 2;
            this.txt_GradeValue.Name = "txt_GradeValue";
            this.txt_GradeValue.Size = new System.Drawing.Size(75, 20);
            this.txt_GradeValue.TabIndex = 36;
            // 
            // btn_GradeLaunch
            // 
            this.btn_GradeLaunch.Location = new System.Drawing.Point(235, 402);
            this.btn_GradeLaunch.Margin = new System.Windows.Forms.Padding(2);
            this.btn_GradeLaunch.Name = "btn_GradeLaunch";
            this.btn_GradeLaunch.Size = new System.Drawing.Size(79, 19);
            this.btn_GradeLaunch.TabIndex = 35;
            this.btn_GradeLaunch.Text = "Confirmar";
            this.btn_GradeLaunch.UseVisualStyleBackColor = true;
            this.btn_GradeLaunch.Click += new System.EventHandler(this.btn_GradeLaunch_Click);
            // 
            // lbl_GradeLaunch
            // 
            this.lbl_GradeLaunch.AutoSize = true;
            this.lbl_GradeLaunch.Location = new System.Drawing.Point(5, 10);
            this.lbl_GradeLaunch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_GradeLaunch.Name = "lbl_GradeLaunch";
            this.lbl_GradeLaunch.Size = new System.Drawing.Size(110, 13);
            this.lbl_GradeLaunch.TabIndex = 34;
            this.lbl_GradeLaunch.Text = "Lançamento de notas";
            // 
            // tvw_GradeLaunch
            // 
            this.tvw_GradeLaunch.Location = new System.Drawing.Point(6, 26);
            this.tvw_GradeLaunch.Name = "tvw_GradeLaunch";
            this.tvw_GradeLaunch.Size = new System.Drawing.Size(308, 358);
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
            this.tp_StudentProfile.Location = new System.Drawing.Point(4, 22);
            this.tp_StudentProfile.Name = "tp_StudentProfile";
            this.tp_StudentProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tp_StudentProfile.Size = new System.Drawing.Size(535, 445);
            this.tp_StudentProfile.TabIndex = 1;
            this.tp_StudentProfile.Text = "Perfil";
            this.tp_StudentProfile.UseVisualStyleBackColor = true;
            // 
            // btn_TeacherSubmit
            // 
            this.btn_TeacherSubmit.Enabled = false;
            this.btn_TeacherSubmit.Location = new System.Drawing.Point(244, 416);
            this.btn_TeacherSubmit.Name = "btn_TeacherSubmit";
            this.btn_TeacherSubmit.Size = new System.Drawing.Size(75, 23);
            this.btn_TeacherSubmit.TabIndex = 46;
            this.btn_TeacherSubmit.Text = "Submeter";
            this.btn_TeacherSubmit.UseVisualStyleBackColor = true;
            this.btn_TeacherSubmit.Click += new System.EventHandler(this.btn_TeacherSubmit_Click);
            // 
            // btn_TeacherEdit
            // 
            this.btn_TeacherEdit.Location = new System.Drawing.Point(6, 416);
            this.btn_TeacherEdit.Name = "btn_TeacherEdit";
            this.btn_TeacherEdit.Size = new System.Drawing.Size(75, 23);
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
            this.chb_TeacherShowPassword.Location = new System.Drawing.Point(137, 229);
            this.chb_TeacherShowPassword.Name = "chb_TeacherShowPassword";
            this.chb_TeacherShowPassword.Size = new System.Drawing.Size(31, 19);
            this.chb_TeacherShowPassword.TabIndex = 44;
            this.chb_TeacherShowPassword.Text = "        ";
            this.chb_TeacherShowPassword.UseVisualStyleBackColor = true;
            // 
            // txt_TeacherPassword
            // 
            this.txt_TeacherPassword.Location = new System.Drawing.Point(6, 229);
            this.txt_TeacherPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TeacherPassword.MaxLength = 9;
            this.txt_TeacherPassword.Name = "txt_TeacherPassword";
            this.txt_TeacherPassword.PasswordChar = '*';
            this.txt_TeacherPassword.ReadOnly = true;
            this.txt_TeacherPassword.Size = new System.Drawing.Size(127, 20);
            this.txt_TeacherPassword.TabIndex = 43;
            // 
            // txt_TeacherNumber
            // 
            this.txt_TeacherNumber.Location = new System.Drawing.Point(5, 273);
            this.txt_TeacherNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TeacherNumber.Name = "txt_TeacherNumber";
            this.txt_TeacherNumber.ReadOnly = true;
            this.txt_TeacherNumber.Size = new System.Drawing.Size(101, 20);
            this.txt_TeacherNumber.TabIndex = 41;
            this.txt_TeacherNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_TeacherNIF
            // 
            this.txt_TeacherNIF.Location = new System.Drawing.Point(5, 179);
            this.txt_TeacherNIF.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TeacherNIF.MaxLength = 9;
            this.txt_TeacherNIF.Name = "txt_TeacherNIF";
            this.txt_TeacherNIF.ReadOnly = true;
            this.txt_TeacherNIF.Size = new System.Drawing.Size(127, 20);
            this.txt_TeacherNIF.TabIndex = 39;
            // 
            // txt_TeacherContact
            // 
            this.txt_TeacherContact.Location = new System.Drawing.Point(5, 134);
            this.txt_TeacherContact.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TeacherContact.Name = "txt_TeacherContact";
            this.txt_TeacherContact.ReadOnly = true;
            this.txt_TeacherContact.Size = new System.Drawing.Size(127, 20);
            this.txt_TeacherContact.TabIndex = 37;
            // 
            // txt_TeacherAddress
            // 
            this.txt_TeacherAddress.Location = new System.Drawing.Point(5, 89);
            this.txt_TeacherAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TeacherAddress.Name = "txt_TeacherAddress";
            this.txt_TeacherAddress.ReadOnly = true;
            this.txt_TeacherAddress.Size = new System.Drawing.Size(237, 20);
            this.txt_TeacherAddress.TabIndex = 35;
            // 
            // txt_TeacherName
            // 
            this.txt_TeacherName.Location = new System.Drawing.Point(5, 49);
            this.txt_TeacherName.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TeacherName.Name = "txt_TeacherName";
            this.txt_TeacherName.ReadOnly = true;
            this.txt_TeacherName.Size = new System.Drawing.Size(127, 20);
            this.txt_TeacherName.TabIndex = 33;
            // 
            // lbl_TeacherPassword
            // 
            this.lbl_TeacherPassword.AutoSize = true;
            this.lbl_TeacherPassword.Location = new System.Drawing.Point(3, 210);
            this.lbl_TeacherPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TeacherPassword.Name = "lbl_TeacherPassword";
            this.lbl_TeacherPassword.Size = new System.Drawing.Size(53, 13);
            this.lbl_TeacherPassword.TabIndex = 42;
            this.lbl_TeacherPassword.Text = "Password";
            // 
            // lbl_TeacherNumber
            // 
            this.lbl_TeacherNumber.AutoSize = true;
            this.lbl_TeacherNumber.Location = new System.Drawing.Point(3, 256);
            this.lbl_TeacherNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TeacherNumber.Name = "lbl_TeacherNumber";
            this.lbl_TeacherNumber.Size = new System.Drawing.Size(102, 13);
            this.lbl_TeacherNumber.TabIndex = 40;
            this.lbl_TeacherNumber.Text = "Numero Funcionário";
            // 
            // lbl_TeacherNIF
            // 
            this.lbl_TeacherNIF.AutoSize = true;
            this.lbl_TeacherNIF.Location = new System.Drawing.Point(3, 162);
            this.lbl_TeacherNIF.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TeacherNIF.Name = "lbl_TeacherNIF";
            this.lbl_TeacherNIF.Size = new System.Drawing.Size(24, 13);
            this.lbl_TeacherNIF.TabIndex = 38;
            this.lbl_TeacherNIF.Text = "NIF";
            // 
            // lbl_TeacherContact
            // 
            this.lbl_TeacherContact.AutoSize = true;
            this.lbl_TeacherContact.Location = new System.Drawing.Point(3, 117);
            this.lbl_TeacherContact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TeacherContact.Name = "lbl_TeacherContact";
            this.lbl_TeacherContact.Size = new System.Drawing.Size(50, 13);
            this.lbl_TeacherContact.TabIndex = 36;
            this.lbl_TeacherContact.Text = "Contacto";
            // 
            // lbl_TeacherAddress
            // 
            this.lbl_TeacherAddress.AutoSize = true;
            this.lbl_TeacherAddress.Location = new System.Drawing.Point(3, 73);
            this.lbl_TeacherAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TeacherAddress.Name = "lbl_TeacherAddress";
            this.lbl_TeacherAddress.Size = new System.Drawing.Size(43, 13);
            this.lbl_TeacherAddress.TabIndex = 34;
            this.lbl_TeacherAddress.Text = "Morada";
            // 
            // lbl_TeacherName
            // 
            this.lbl_TeacherName.AutoSize = true;
            this.lbl_TeacherName.Location = new System.Drawing.Point(3, 32);
            this.lbl_TeacherName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TeacherName.Name = "lbl_TeacherName";
            this.lbl_TeacherName.Size = new System.Drawing.Size(35, 13);
            this.lbl_TeacherName.TabIndex = 32;
            this.lbl_TeacherName.Text = "Nome";
            // 
            // Teacher_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 486);
            this.Controls.Add(this.tc_Teacher);
            this.Name = "Teacher_Panel";
            this.Text = "Teacher_Panel";
            this.Load += new System.EventHandler(this.Teacher_Panel_Load);
            this.tc_Teacher.ResumeLayout(false);
            this.tp_StudentActions.ResumeLayout(false);
            this.tp_StudentActions.PerformLayout();
            this.tp_StudentProfile.ResumeLayout(false);
            this.tp_StudentProfile.PerformLayout();
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
        private System.Windows.Forms.Button btn_TeacherSubmit;
        private System.Windows.Forms.Button btn_TeacherEdit;
    }
}