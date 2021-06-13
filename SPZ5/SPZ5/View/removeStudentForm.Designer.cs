namespace SPZ5
{
    partial class removeStudentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxStudents = new System.Windows.Forms.ComboBox();
            this.removeSuBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выберите студента";
            // 
            // comboBoxStudents
            // 
            this.comboBoxStudents.FormattingEnabled = true;
            this.comboBoxStudents.Location = new System.Drawing.Point(12, 26);
            this.comboBoxStudents.Name = "comboBoxStudents";
            this.comboBoxStudents.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStudents.TabIndex = 4;
            // 
            // removeSuBtn
            // 
            this.removeSuBtn.Location = new System.Drawing.Point(149, 26);
            this.removeSuBtn.Name = "removeSuBtn";
            this.removeSuBtn.Size = new System.Drawing.Size(75, 23);
            this.removeSuBtn.TabIndex = 6;
            this.removeSuBtn.Text = "Удалить";
            this.removeSuBtn.UseVisualStyleBackColor = true;
            this.removeSuBtn.Click += new System.EventHandler(this.removeStBtn_Click);
            // 
            // removeStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 164);
            this.Controls.Add(this.removeSuBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxStudents);
            this.Name = "removeStudentForm";
            this.Text = "removeStudent";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxStudents;
        private System.Windows.Forms.Button removeSuBtn;
    }
}