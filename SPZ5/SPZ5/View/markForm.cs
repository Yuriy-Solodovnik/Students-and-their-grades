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
    public partial class markForm : Form
    {
        bool update = false;
        int index;
        public markForm()
        {
            InitializeComponent();
            for(int i = 0 ; i < Storage.students.Count; i++)
            {
                comboBoxStudents.Items.Add(Storage.students[i].name);
            }
            for (int i = 0; i < Storage.subjects.Count; i++)
            {
                comboBoxSubjects.Items.Add(Storage.subjects[i].name);
            }
            comboBoxStudents.SelectedIndex = 0;
            comboBoxSubjects.SelectedIndex = 0;
        }
        public markForm(Mark mark, int index)
        {
            InitializeComponent();
            update = true;
            numericUpDownMark.Value = mark.mark;
            this.index = index;
            comboBoxStudents.Items.Add(Storage.students[index].name);
            comboBoxSubjects.Items.Add(Storage.subjects[index].name);
            comboBoxStudents.SelectedIndex = 0;
            comboBoxSubjects.SelectedIndex = 0;
        }
        private void addMark_Click(object sender, EventArgs e)
        {
            if (comboBoxStudents.SelectedIndex > -1 || comboBoxSubjects.SelectedIndex > -1)
            {
                Mark m = new Mark(comboBoxSubjects.SelectedItem.ToString(), comboBoxStudents.SelectedItem.ToString(), (int)numericUpDownMark.Value);
                if (update)
                {
                    m.id = Storage.marks[index].mark;
                    Storage.marks.RemoveAt(index);
                    Storage.marks.Insert(index, m);
                }
                else
                {
                    Storage.marks.Add(m);
                    m.id = Storage.marks.Count;
                }
                Storage.serializeMark();
                DialogResult = DialogResult.OK;
                update = false;
                Close();
            }
            else
                MessageBox.Show("Не выбран предмет или стедент");
        }
    }
}
