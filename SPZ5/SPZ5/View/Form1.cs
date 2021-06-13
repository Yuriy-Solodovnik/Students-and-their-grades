using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPZ5
{
    public partial class Form1 : Form
    {
        private readonly BindingSource _bst;
        private readonly BindingSource _bsu;
        private readonly BindingSource _bm;
        public Form1()
        {
            InitializeComponent();
            _bst = new BindingSource();
            _bsu = new BindingSource();
            _bm = new BindingSource();
            _bst.DataSource = Storage.students;
            StudentsTable.DataSource = _bst;
            _bsu.DataSource = Storage.subjects;
            SubectsTable.DataSource = _bsu;
            _bm.DataSource = Storage.marks;
            MarksTable.DataSource = _bm;
        }
        private void addStudent_Click(object sender, EventArgs e)
        {
            Form form = new studentForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                _bst.DataSource = Storage.students;
                _bst.ResetBindings(false);
                removeStudent.Enabled = true;
            }
        }
        private void addSubject_Click(object sender, EventArgs e)
        {
            Form form = new subjectForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                _bsu.DataSource = Storage.subjects;
                _bsu.ResetBindings(false);
                removeSubject.Enabled = true;
                sortSubjectsBtn.Enabled = true;
            }
        }
        private void addMark_Click(object sender, EventArgs e)
        {
            if (Storage.students.Count != 0 && Storage.subjects.Count != 0)
            {
                Form form = new markForm();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _bm.DataSource = Storage.marks;
                    _bm.ResetBindings(false);
                }
            }
            else
            {
                MessageBox.Show("Отсутствует одно из значений студент/предмет");
                return;
            }
        }
        private void removeStudent_Click(object sender, EventArgs e)
        {
            restoreSubjectBtn.Enabled = false;
            Form form = new removeStudentForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                _bst.DataSource = Storage.students;
                _bst.ResetBindings(false);
                _bm.DataSource = Storage.marks;
                _bm.ResetBindings(false);
                restoreStudentBtn.Enabled = true;
            }
        }
        private void removeSubject_Click(object sender, EventArgs e)
        {
            restoreStudentBtn.Enabled = false;
            Form form = new removeSubjectForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                _bsu.DataSource = Storage.subjects;
                _bsu.ResetBindings(false);
                _bm.DataSource = Storage.marks;
                _bm.ResetBindings(false);
                restoreSubjectBtn.Enabled = true;
            }
        }
        private void restoreStudentBtn_Click(object sender, EventArgs e)
        {
            restoreSubjectBtn.Enabled = true;
            Storage.getFromFileToStudent();
            Storage.getFromFileToMark();
            _bst.DataSource = Storage.students;
            _bst.ResetBindings(false);
            _bm.DataSource = Storage.marks;
            _bm.ResetBindings(false);
        }
        private void restoreSubjectBtn_Click(object sender, EventArgs e)
        {
            restoreStudentBtn.Enabled = true;
            Storage.getFromFileToSubject();
            Storage.getFromFileToMark();
            _bsu.DataSource = Storage.subjects;
            _bsu.ResetBindings(false);
            _bm.DataSource = Storage.marks;
            _bm.ResetBindings(false);
        }

        private void StudentsTable_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            var student = Storage.students[index];
            var form = new studentForm(student, index);
            form.StartPosition = FormStartPosition.CenterParent;
            if (form.ShowDialog() == DialogResult.OK)
            {
                _bst.ResetBindings(false);
            }
        }

        private void MarksTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            var mark = Storage.marks[index];
            var form = new markForm(mark, index);
            form.StartPosition = FormStartPosition.CenterParent;
            if (form.ShowDialog() == DialogResult.OK)
            {
                _bm.ResetBindings(false);
            }
        }

        private void SubectsTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var index = e.RowIndex;
            var subject = Storage.subjects[index];
            var form = new subjectForm(subject, index);
            form.StartPosition = FormStartPosition.CenterParent;
            if (form.ShowDialog() == DialogResult.OK)
            {
                _bsu.ResetBindings(false);
            }
        }

        private void sortSubjectsBtn_Click(object sender, EventArgs e)
        {
            Storage.sortSubjects();
            _bsu.DataSource = Storage.subjects;
            _bsu.ResetBindings(false);
        }
        private void filterStudentsBtn_Click(object sender, EventArgs e)
        {
            Form form = new filterStudentsForm();
            if (form.ShowDialog() == DialogResult.OK)
                _bm.ResetBindings(false);
        }
    }
}
