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
    public partial class filterStudentsForm : Form
    {
        public filterStudentsForm()
        {
            InitializeComponent();
        }

        private void findStudentBtn_Click(object sender, EventArgs e)
        {
            var newList = Storage.marks.Where(x => x.studentName.Contains(textBox1.Text));
            listBoxStudentInfo.Text = string.Join(Environment.NewLine, newList.Select(x => x.ToString()));
        }
    }
}
