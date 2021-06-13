namespace SPZ5
{
    partial class removeSubjectForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSubjectsR = new System.Windows.Forms.ComboBox();
            this.removeStBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Выберите предмет";
            // 
            // comboBoxSubjectsR
            // 
            this.comboBoxSubjectsR.FormattingEnabled = true;
            this.comboBoxSubjectsR.Location = new System.Drawing.Point(12, 24);
            this.comboBoxSubjectsR.Name = "comboBoxSubjectsR";
            this.comboBoxSubjectsR.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSubjectsR.TabIndex = 6;
            // 
            // removeStBtn
            // 
            this.removeStBtn.Location = new System.Drawing.Point(149, 24);
            this.removeStBtn.Name = "removeStBtn";
            this.removeStBtn.Size = new System.Drawing.Size(75, 23);
            this.removeStBtn.TabIndex = 8;
            this.removeStBtn.Text = "Удалить";
            this.removeStBtn.UseVisualStyleBackColor = true;
            this.removeStBtn.Click += new System.EventHandler(this.removeSuBtn_Click);
            // 
            // removeSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 164);
            this.Controls.Add(this.removeStBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxSubjectsR);
            this.Name = "removeSubjectForm";
            this.Text = "removeSubjectForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxSubjectsR;
        private System.Windows.Forms.Button removeStBtn;
    }
}