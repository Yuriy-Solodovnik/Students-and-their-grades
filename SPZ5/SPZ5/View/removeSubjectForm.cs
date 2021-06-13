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
    public partial class removeSubjectForm : Form
    {
        public removeSubjectForm()
        {
            InitializeComponent();
            for (int i = 0; i < Storage.subjects.Count; i++)
            {
                comboBoxSubjectsR.Items.Add(Storage.subjects[i].name);
            }
        }

        private void removeSuBtn_Click(object sender, EventArgs e)
        {
            if (comboBoxSubjectsR.SelectedIndex > -1)
            {
                Storage.marks.RemoveAll(x => x.subjectName == Storage.subjects[comboBoxSubjectsR.SelectedIndex].name);
                Storage.subjects.RemoveAt(comboBoxSubjectsR.SelectedIndex);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
                MessageBox.Show("Не выбран предмет");
        }
    }
}
