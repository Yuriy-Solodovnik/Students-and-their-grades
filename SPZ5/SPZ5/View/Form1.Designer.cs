namespace SPZ5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.StudentsTable = new System.Windows.Forms.DataGridView();
            this.SubectsTable = new System.Windows.Forms.DataGridView();
            this.MarksTable = new System.Windows.Forms.DataGridView();
            this.addSubject = new System.Windows.Forms.Button();
            this.addStudent = new System.Windows.Forms.Button();
            this.addMark = new System.Windows.Forms.Button();
            this.removeStudent = new System.Windows.Forms.Button();
            this.removeSubject = new System.Windows.Forms.Button();
            this.restoreStudentBtn = new System.Windows.Forms.Button();
            this.restoreSubjectBtn = new System.Windows.Forms.Button();
            this.sortSubjectsBtn = new System.Windows.Forms.Button();
            this.filterStudentsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubectsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarksTable)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentsTable
            // 
            this.StudentsTable.AllowUserToAddRows = false;
            this.StudentsTable.AllowUserToDeleteRows = false;
            this.StudentsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StudentsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsTable.Location = new System.Drawing.Point(12, 12);
            this.StudentsTable.Name = "StudentsTable";
            this.StudentsTable.ReadOnly = true;
            this.StudentsTable.Size = new System.Drawing.Size(240, 426);
            this.StudentsTable.TabIndex = 0;
            this.StudentsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentsTable_CellContentClick_1);
            // 
            // SubectsTable
            // 
            this.SubectsTable.AllowUserToAddRows = false;
            this.SubectsTable.AllowUserToDeleteRows = false;
            this.SubectsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SubectsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubectsTable.Location = new System.Drawing.Point(724, 12);
            this.SubectsTable.Name = "SubectsTable";
            this.SubectsTable.ReadOnly = true;
            this.SubectsTable.Size = new System.Drawing.Size(240, 426);
            this.SubectsTable.TabIndex = 1;
            this.SubectsTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SubectsTable_CellContentClick);
            // 
            // MarksTable
            // 
            this.MarksTable.AllowUserToAddRows = false;
            this.MarksTable.AllowUserToDeleteRows = false;
            this.MarksTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MarksTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.MarksTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MarksTable.Location = new System.Drawing.Point(258, 12);
            this.MarksTable.Name = "MarksTable";
            this.MarksTable.ReadOnly = true;
            this.MarksTable.Size = new System.Drawing.Size(460, 426);
            this.MarksTable.TabIndex = 2;
            this.MarksTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MarksTable_CellContentClick);
            // 
            // addSubject
            // 
            this.addSubject.Location = new System.Drawing.Point(851, 444);
            this.addSubject.Name = "addSubject";
            this.addSubject.Size = new System.Drawing.Size(113, 23);
            this.addSubject.TabIndex = 3;
            this.addSubject.Text = "Добавить предмет";
            this.addSubject.UseVisualStyleBackColor = true;
            this.addSubject.Click += new System.EventHandler(this.addSubject_Click);
            // 
            // addStudent
            // 
            this.addStudent.Location = new System.Drawing.Point(12, 444);
            this.addStudent.Name = "addStudent";
            this.addStudent.Size = new System.Drawing.Size(115, 23);
            this.addStudent.TabIndex = 4;
            this.addStudent.Text = "Добавить студента";
            this.addStudent.UseVisualStyleBackColor = true;
            this.addStudent.Click += new System.EventHandler(this.addStudent_Click);
            // 
            // addMark
            // 
            this.addMark.Location = new System.Drawing.Point(438, 444);
            this.addMark.Name = "addMark";
            this.addMark.Size = new System.Drawing.Size(113, 23);
            this.addMark.TabIndex = 5;
            this.addMark.Text = "Добавить оценку";
            this.addMark.UseVisualStyleBackColor = true;
            this.addMark.Click += new System.EventHandler(this.addMark_Click);
            // 
            // removeStudent
            // 
            this.removeStudent.Enabled = false;
            this.removeStudent.Location = new System.Drawing.Point(133, 444);
            this.removeStudent.Name = "removeStudent";
            this.removeStudent.Size = new System.Drawing.Size(119, 23);
            this.removeStudent.TabIndex = 6;
            this.removeStudent.Text = "Удалить";
            this.removeStudent.UseVisualStyleBackColor = true;
            this.removeStudent.Click += new System.EventHandler(this.removeStudent_Click);
            // 
            // removeSubject
            // 
            this.removeSubject.Enabled = false;
            this.removeSubject.Location = new System.Drawing.Point(724, 444);
            this.removeSubject.Name = "removeSubject";
            this.removeSubject.Size = new System.Drawing.Size(119, 23);
            this.removeSubject.TabIndex = 7;
            this.removeSubject.Text = "Удалить";
            this.removeSubject.UseVisualStyleBackColor = true;
            this.removeSubject.Click += new System.EventHandler(this.removeSubject_Click);
            // 
            // restoreStudentBtn
            // 
            this.restoreStudentBtn.Enabled = false;
            this.restoreStudentBtn.Location = new System.Drawing.Point(13, 474);
            this.restoreStudentBtn.Name = "restoreStudentBtn";
            this.restoreStudentBtn.Size = new System.Drawing.Size(114, 23);
            this.restoreStudentBtn.TabIndex = 8;
            this.restoreStudentBtn.Text = "Восстановить";
            this.restoreStudentBtn.UseVisualStyleBackColor = true;
            this.restoreStudentBtn.Click += new System.EventHandler(this.restoreStudentBtn_Click);
            // 
            // restoreSubjectBtn
            // 
            this.restoreSubjectBtn.Enabled = false;
            this.restoreSubjectBtn.Location = new System.Drawing.Point(850, 474);
            this.restoreSubjectBtn.Name = "restoreSubjectBtn";
            this.restoreSubjectBtn.Size = new System.Drawing.Size(114, 23);
            this.restoreSubjectBtn.TabIndex = 9;
            this.restoreSubjectBtn.Text = "Восстановить";
            this.restoreSubjectBtn.UseVisualStyleBackColor = true;
            this.restoreSubjectBtn.Click += new System.EventHandler(this.restoreSubjectBtn_Click);
            // 
            // sortSubjectsBtn
            // 
            this.sortSubjectsBtn.Enabled = false;
            this.sortSubjectsBtn.Location = new System.Drawing.Point(724, 474);
            this.sortSubjectsBtn.Name = "sortSubjectsBtn";
            this.sortSubjectsBtn.Size = new System.Drawing.Size(119, 23);
            this.sortSubjectsBtn.TabIndex = 10;
            this.sortSubjectsBtn.Text = "Отсортировать";
            this.sortSubjectsBtn.UseVisualStyleBackColor = true;
            this.sortSubjectsBtn.Click += new System.EventHandler(this.sortSubjectsBtn_Click);
            // 
            // filterStudentsBtn
            // 
            this.filterStudentsBtn.Location = new System.Drawing.Point(438, 473);
            this.filterStudentsBtn.Name = "filterStudentsBtn";
            this.filterStudentsBtn.Size = new System.Drawing.Size(113, 23);
            this.filterStudentsBtn.TabIndex = 11;
            this.filterStudentsBtn.Text = "Поиск по студенту";
            this.filterStudentsBtn.UseVisualStyleBackColor = true;
            this.filterStudentsBtn.Click += new System.EventHandler(this.filterStudentsBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 529);
            this.Controls.Add(this.filterStudentsBtn);
            this.Controls.Add(this.sortSubjectsBtn);
            this.Controls.Add(this.restoreSubjectBtn);
            this.Controls.Add(this.restoreStudentBtn);
            this.Controls.Add(this.removeSubject);
            this.Controls.Add(this.removeStudent);
            this.Controls.Add(this.addMark);
            this.Controls.Add(this.addStudent);
            this.Controls.Add(this.addSubject);
            this.Controls.Add(this.MarksTable);
            this.Controls.Add(this.SubectsTable);
            this.Controls.Add(this.StudentsTable);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.StudentsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubectsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarksTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView StudentsTable;
        private System.Windows.Forms.DataGridView SubectsTable;
        private System.Windows.Forms.DataGridView MarksTable;
        private System.Windows.Forms.Button addSubject;
        private System.Windows.Forms.Button addStudent;
        private System.Windows.Forms.Button addMark;
        private System.Windows.Forms.Button removeStudent;
        private System.Windows.Forms.Button removeSubject;
        private System.Windows.Forms.Button restoreStudentBtn;
        private System.Windows.Forms.Button restoreSubjectBtn;
        private System.Windows.Forms.Button sortSubjectsBtn;
        private System.Windows.Forms.Button filterStudentsBtn;
    }
}

