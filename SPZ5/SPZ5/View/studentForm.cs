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
    public partial class studentForm : Form
    {
        bool update = false;
        int index;
        public studentForm()
        {
            InitializeComponent();
        }
        public studentForm(Student student, int index)
        {
            InitializeComponent();
            update = true;
            textBoxStudent.Text = student.name;
            this.index = index;
        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            Student st = new Student();
            st.name = textBoxStudent.Text;
            if (update)
            {
                st.id = Storage.students[index].id;
                Storage.students.RemoveAt(index);
                Storage.students.Insert(index, st);
            }
            else
            {
                Storage.students.Add(st);
                st.id = Storage.students.Count;
            }
            Storage.serializeStudent();
            DialogResult = DialogResult.OK;
            update = false;
            Close();
        }
    }
}
