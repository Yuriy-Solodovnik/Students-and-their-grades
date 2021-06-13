namespace SPZ5
{
    partial class markForm
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
            this.comboBoxStudents = new System.Windows.Forms.ComboBox();
            this.comboBoxSubjects = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownMark = new System.Windows.Forms.NumericUpDown();
            this.addMark = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMark)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxStudents
            // 
            this.comboBoxStudents.FormattingEnabled = true;
            this.comboBoxStudents.Location = new System.Drawing.Point(10, 43);
            this.comboBoxStudents.Name = "comboBoxStudents";
            this.comboBoxStudents.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStudents.TabIndex = 0;
            // 
            // comboBoxSubjects
            // 
            this.comboBoxSubjects.FormattingEnabled = true;
            this.comboBoxSubjects.Location = new System.Drawing.Point(271, 43);
            this.comboBoxSubjects.Name = "comboBoxSubjects";
            this.comboBoxSubjects.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSubjects.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выберите студента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ведите оценку";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Выберите предмет";
            // 
            // numericUpDownMark
            // 
            this.numericUpDownMark.Location = new System.Drawing.Point(141, 44);
            this.numericUpDownMark.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownMark.Name = "numericUpDownMark";
            this.numericUpDownMark.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMark.TabIndex = 6;
            this.numericUpDownMark.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // addMark
            // 
            this.addMark.Location = new System.Drawing.Point(141, 97);
            this.addMark.Name = "addMark";
            this.addMark.Size = new System.Drawing.Size(120, 35);
            this.addMark.TabIndex = 7;
            this.addMark.Text = "Поставить оценку";
            this.addMark.UseVisualStyleBackColor = true;
            this.addMark.Click += new System.EventHandler(this.addMark_Click);
            // 
            // markForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 137);
            this.Controls.Add(this.addMark);
            this.Controls.Add(this.numericUpDownMark);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSubjects);
            this.Controls.Add(this.comboBoxStudents);
            this.Name = "markForm";
            this.Text = "Оценка";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMark)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxStudents;
        private System.Windows.Forms.ComboBox comboBoxSubjects;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownMark;
        private System.Windows.Forms.Button addMark;
    }
}