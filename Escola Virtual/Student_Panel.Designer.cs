
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
            this.lb_History = new System.Windows.Forms.ListBox();
            this.lbl_History = new System.Windows.Forms.Label();
            this.tvw_Grades = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_History
            // 
            this.lb_History.FormattingEnabled = true;
            this.lb_History.Location = new System.Drawing.Point(176, 28);
            this.lb_History.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lb_History.Name = "lb_History";
            this.lb_History.Size = new System.Drawing.Size(279, 329);
            this.lb_History.TabIndex = 0;
            // 
            // lbl_History
            // 
            this.lbl_History.AutoSize = true;
            this.lbl_History.Location = new System.Drawing.Point(174, 12);
            this.lbl_History.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_History.Name = "lbl_History";
            this.lbl_History.Size = new System.Drawing.Size(64, 13);
            this.lbl_History.TabIndex = 1;
            this.lbl_History.Text = "Movimentos";
            // 
            // tvw_Grades
            // 
            this.tvw_Grades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tvw_Grades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvw_Grades.Location = new System.Drawing.Point(10, 28);
            this.tvw_Grades.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tvw_Grades.Name = "tvw_Grades";
            this.tvw_Grades.Size = new System.Drawing.Size(162, 328);
            this.tvw_Grades.TabIndex = 2;
            this.tvw_Grades.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvw_Grades_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Notas";
            // 
            // Student_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tvw_Grades);
            this.Controls.Add(this.lbl_History);
            this.Controls.Add(this.lb_History);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Student_Panel";
            this.Text = "Painel de Aluno";
            this.Load += new System.EventHandler(this.Student_Panel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_History;
        private System.Windows.Forms.Label lbl_History;
        private System.Windows.Forms.TreeView tvw_Grades;
        private System.Windows.Forms.Label label1;
    }
}