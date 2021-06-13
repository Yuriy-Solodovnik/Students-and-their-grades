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
    public partial class subjectForm : Form
    {
        bool update = false;
        int index;
        public subjectForm()
        {
            InitializeComponent();
        }
        public subjectForm(Subject subject, int index)
        {
            InitializeComponent();
            update = true;
            textBoxSubject.Text = subject.name;
            this.index = index;
        }
        private void addSubject_Click(object sender, EventArgs e)
        {
            Subject su = new Subject();
            su.name = textBoxSubject.Text;
            if (update)
            {
                su.id = Storage.subjects[index].id;
                Storage.subjects.RemoveAt(index);
                Storage.subjects.Insert(index, su);
            }
            else
            {
                Storage.subjects.Add(su);
                su.id = Storage.subjects.Count;
            }
            Storage.serializeSubject();
            DialogResult = DialogResult.OK;
            Close();

        }
    }
}
