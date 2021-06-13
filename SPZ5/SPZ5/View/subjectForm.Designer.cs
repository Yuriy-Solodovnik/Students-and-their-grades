namespace SPZ5
{
    partial class subjectForm
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
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.addSubject = new System.Windows.Forms.Button();
            this.subjectName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(15, 38);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(117, 20);
            this.textBoxSubject.TabIndex = 5;
            // 
            // addSubject
            // 
            this.addSubject.Location = new System.Drawing.Point(15, 77);
            this.addSubject.Name = "addSubject";
            this.addSubject.Size = new System.Drawing.Size(81, 23);
            this.addSubject.TabIndex = 4;
            this.addSubject.Text = "Подтвердить";
            this.addSubject.UseVisualStyleBackColor = true;
            this.addSubject.Click += new System.EventHandler(this.addSubject_Click);
            // 
            // subjectName
            // 
            this.subjectName.AutoSize = true;
            this.subjectName.Location = new System.Drawing.Point(12, 9);
            this.subjectName.Name = "subjectName";
            this.subjectName.Size = new System.Drawing.Size(152, 13);
            this.subjectName.TabIndex = 3;
            this.subjectName.Text = "Введите название предмета";
            // 
            // subjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(175, 106);
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.addSubject);
            this.Controls.Add(this.subjectName);
            this.Name = "subjectForm";
            this.Text = "Предмет";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.Button addSubject;
        private System.Windows.Forms.Label subjectName;
    }
}