
namespace Escola_Virtual
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chb_show_Password = new System.Windows.Forms.CheckBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lbl_LoginErrors = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_accnumber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 236);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 182);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Número de conta";
            // 
            // chb_show_Password
            // 
            this.chb_show_Password.Appearance = System.Windows.Forms.Appearance.Button;
            this.chb_show_Password.AutoSize = true;
            this.chb_show_Password.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("chb_show_Password.BackgroundImage")));
            this.chb_show_Password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chb_show_Password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chb_show_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_show_Password.ImageList = this.imageList1;
            this.chb_show_Password.Location = new System.Drawing.Point(446, 254);
            this.chb_show_Password.Margin = new System.Windows.Forms.Padding(4);
            this.chb_show_Password.Name = "chb_show_Password";
            this.chb_show_Password.Size = new System.Drawing.Size(41, 23);
            this.chb_show_Password.TabIndex = 21;
            this.chb_show_Password.Text = "        ";
            this.chb_show_Password.UseVisualStyleBackColor = true;
            this.chb_show_Password.CheckedChanged += new System.EventHandler(this.chb_show_Password_CheckedChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "eye-password-see-view.png");
            this.imageList1.Images.SetKeyName(1, "777494-200.png");
            // 
            // lbl_LoginErrors
            // 
            this.lbl_LoginErrors.AutoSize = true;
            this.lbl_LoginErrors.ForeColor = System.Drawing.Color.Red;
            this.lbl_LoginErrors.Location = new System.Drawing.Point(325, 326);
            this.lbl_LoginErrors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_LoginErrors.Name = "lbl_LoginErrors";
            this.lbl_LoginErrors.Size = new System.Drawing.Size(0, 17);
            this.lbl_LoginErrors.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 32);
            this.label1.TabIndex = 19;
            this.label1.Text = "Login";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(314, 300);
            this.btn_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(173, 23);
            this.btn_login.TabIndex = 18;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(314, 255);
            this.txt_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(124, 22);
            this.txt_password.TabIndex = 17;
            // 
            // txt_accnumber
            // 
            this.txt_accnumber.Location = new System.Drawing.Point(314, 204);
            this.txt_accnumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_accnumber.Name = "txt_accnumber";
            this.txt_accnumber.Size = new System.Drawing.Size(172, 22);
            this.txt_accnumber.TabIndex = 16;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chb_show_Password);
            this.Controls.Add(this.lbl_LoginErrors);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_accnumber);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chb_show_Password;
        private System.Windows.Forms.Label lbl_LoginErrors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_accnumber;
        private System.Windows.Forms.ImageList imageList1;
    }
}

