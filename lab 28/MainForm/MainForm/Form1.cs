using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void TaskButton1_Click(object sender, EventArgs e)
        {
            var form1 = new Column();
            form1.Show();
        }

        private void TaskButton3_Click(object sender, EventArgs e)
        {
            var form3 = new Students();
            form3.Show();
        }

        private void TaskButton4_Click(object sender, EventArgs e)
        {
            var form4 = new Shop();
            form4.Show();
        }
    }
}
