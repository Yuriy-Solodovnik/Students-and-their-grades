using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPZ5
{
    public partial class removeStudentForm : Form
    {
        public removeStudentForm()
        {
            InitializeComponent();
            for (int i = 0; i < Storage.students.Count; i++)
            {
                comboBoxStudents.Items.Add(Storage.students[i].name);
            }
        }

        private void removeStBtn_Click(object sender, EventArgs e)
        {
            if (comboBoxStudents.SelectedIndex > -1)
            {
            Storage.marks.RemoveAll(x => x.studentName == Storage.students[comboBoxStudents.SelectedIndex].name);
            Storage.students.RemoveAt(comboBoxStudents.SelectedIndex);
            DialogResult = DialogResult.OK;
            Close();
            }
            else
                MessageBox.Show("Не выбран студент");
        }
    }
}
