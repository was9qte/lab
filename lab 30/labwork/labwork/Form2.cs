using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labwork
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void HelloButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Здравствуйте");
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IconCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (IconCheckBox.Checked)
            {
                IconCheckBox.ImageIndex = 0;
            }
            else
            {
                IconCheckBox.ImageIndex = 1;
            }
        }
    }
}
