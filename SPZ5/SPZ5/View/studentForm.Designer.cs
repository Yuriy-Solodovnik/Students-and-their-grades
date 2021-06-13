namespace SPZ5
{
    partial class studentForm
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
            this.studentName = new System.Windows.Forms.Label();
            this.addStudent = new System.Windows.Forms.Button();
            this.textBoxStudent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // studentName
            // 
            this.studentName.AutoSize = true;
            this.studentName.Location = new System.Drawing.Point(13, 13);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(120, 13);
            this.studentName.TabIndex = 0;
            this.studentName.Text = "Введите имя студента";
            // 
            // addStudent
            // 
            this.addStudent.Location = new System.Drawing.Point(16, 81);
            this.addStudent.Name = "addStudent";
            this.addStudent.Size = new System.Drawing.Size(81, 23);
            this.addStudent.TabIndex = 1;
            this.addStudent.Text = "Подтвердить";
            this.addStudent.UseVisualStyleBackColor = true;
            this.addStudent.Click += new System.EventHandler(this.addStudent_Click);
            // 
            // textBoxStudent
            // 
            this.textBoxStudent.Location = new System.Drawing.Point(16, 42);
            this.textBoxStudent.Name = "textBoxStudent";
            this.textBoxStudent.Size = new System.Drawing.Size(117, 20);
            this.textBoxStudent.TabIndex = 2;
            // 
            // studentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(146, 109);
            this.Controls.Add(this.textBoxStudent);
            this.Controls.Add(this.addStudent);
            this.Controls.Add(this.studentName);
            this.Name = "studentForm";
            this.Text = " Студент";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studentName;
        private System.Windows.Forms.Button addStudent;
        private System.Windows.Forms.TextBox textBoxStudent;
    }
}