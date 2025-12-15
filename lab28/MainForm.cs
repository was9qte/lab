using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab28
{
    using System;
    using System.Windows.Forms;

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnForm1_Click(object sender, EventArgs e)
        {
            var form1 = new dataGridForm1();
            form1.Show();
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            var form2 = new DataGridForm2();
            form2.Show();
        }
    }
}

