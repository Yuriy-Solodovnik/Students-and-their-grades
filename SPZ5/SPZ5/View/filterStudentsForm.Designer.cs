namespace SPZ5
{
    partial class filterStudentsForm
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
            this.labelStudent = new System.Windows.Forms.Label();
            this.findStudentBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBoxStudentInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelStudent
            // 
            this.labelStudent.AutoSize = true;
            this.labelStudent.Location = new System.Drawing.Point(458, 14);
            this.labelStudent.Name = "labelStudent";
            this.labelStudent.Size = new System.Drawing.Size(100, 13);
            this.labelStudent.TabIndex = 1;
            this.labelStudent.Text = "Введите фамилию";
            // 
            // findStudentBtn
            // 
            this.findStudentBtn.Location = new System.Drawing.Point(461, 66);
            this.findStudentBtn.Name = "findStudentBtn";
            this.findStudentBtn.Size = new System.Drawing.Size(100, 23);
            this.findStudentBtn.TabIndex = 2;
            this.findStudentBtn.Text = "Найти";
            this.findStudentBtn.UseVisualStyleBackColor = true;
            this.findStudentBtn.Click += new System.EventHandler(this.findStudentBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(461, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // listBoxStudentInfo
            // 
            this.listBoxStudentInfo.Location = new System.Drawing.Point(13, 14);
            this.listBoxStudentInfo.Name = "listBoxStudentInfo";
            this.listBoxStudentInfo.Size = new System.Drawing.Size(439, 277);
            this.listBoxStudentInfo.TabIndex = 4;
            // 
            // filterStudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 300);
            this.Controls.Add(this.listBoxStudentInfo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.findStudentBtn);
            this.Controls.Add(this.labelStudent);
            this.Name = "filterStudentsForm";
            this.Text = "filterStudentsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelStudent;
        private System.Windows.Forms.Button findStudentBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label listBoxStudentInfo;
    }
}