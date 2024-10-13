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
            this.tvw_GradeLaunch = new System.Windows.Forms.TreeView();
            this.lbl_GradeLaunch = new System.Windows.Forms.Label();
            this.btn_GradeLaunch = new System.Windows.Forms.Button();
            this.txt_GradeValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tvw_GradeLaunch
            // 
            this.tvw_GradeLaunch.Location = new System.Drawing.Point(12, 31);
            this.tvw_GradeLaunch.Name = "tvw_GradeLaunch";
            this.tvw_GradeLaunch.Size = new System.Drawing.Size(308, 358);
            this.tvw_GradeLaunch.TabIndex = 0;
            // 
            // lbl_GradeLaunch
            // 
            this.lbl_GradeLaunch.AutoSize = true;
            this.lbl_GradeLaunch.Location = new System.Drawing.Point(11, 15);
            this.lbl_GradeLaunch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_GradeLaunch.Name = "lbl_GradeLaunch";
            this.lbl_GradeLaunch.Size = new System.Drawing.Size(110, 13);
            this.lbl_GradeLaunch.TabIndex = 9;
            this.lbl_GradeLaunch.Text = "Lançamento de notas";
            // 
            // btn_GradeLaunch
            // 
            this.btn_GradeLaunch.Location = new System.Drawing.Point(241, 407);
            this.btn_GradeLaunch.Margin = new System.Windows.Forms.Padding(2);
            this.btn_GradeLaunch.Name = "btn_GradeLaunch";
            this.btn_GradeLaunch.Size = new System.Drawing.Size(79, 19);
            this.btn_GradeLaunch.TabIndex = 27;
            this.btn_GradeLaunch.Text = "Confirmar";
            this.btn_GradeLaunch.UseVisualStyleBackColor = true;
            this.btn_GradeLaunch.Click += new System.EventHandler(this.btn_GradeLaunch_Click);
            // 
            // txt_GradeValue
            // 
            this.txt_GradeValue.Location = new System.Drawing.Point(14, 407);
            this.txt_GradeValue.MaxLength = 2;
            this.txt_GradeValue.Name = "txt_GradeValue";
            this.txt_GradeValue.Size = new System.Drawing.Size(75, 20);
            this.txt_GradeValue.TabIndex = 28;
            this.txt_GradeValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_GradeValue_KeyPress);
            // 
            // Teacher_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_GradeValue);
            this.Controls.Add(this.btn_GradeLaunch);
            this.Controls.Add(this.lbl_GradeLaunch);
            this.Controls.Add(this.tvw_GradeLaunch);
            this.Name = "Teacher_Panel";
            this.Text = "Teacher_Panel";
            this.Load += new System.EventHandler(this.Teacher_Panel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvw_GradeLaunch;
        private System.Windows.Forms.Label lbl_GradeLaunch;
        private System.Windows.Forms.Button btn_GradeLaunch;
        private System.Windows.Forms.TextBox txt_GradeValue;
    }
}