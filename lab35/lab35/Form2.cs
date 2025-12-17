using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab35
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide(); 
            }
        }
        private void tileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }
        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private Form2 form2;

        private void btnOpenDialog_Click(object sender, EventArgs e)
        {
            if (form2 == null || form2.IsDisposed)
            {
                form2 = new Form2();
                form2.FormClosing += (s, ev) =>
                {
                    if (ev.CloseReason == CloseReason.UserClosing)
                    {
                        ev.Cancel = true;
                        form2.Hide();
                    }
                };
            }

            this.Hide();
            form2.Show();
            form2.BringToFront();
        }

        private void D(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void открытьForm1ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void окнаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void открытьForm3ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void закрытьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void каскадомToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void горизонтальноToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void окнаToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }
        private void OpenForm1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f is Form1)
                {
                    f.Activate();
                    return;
                }
            }

            Form1 f1 = new Form1();
            f1.MdiParent = this;
            f1.Show();
        }

        private void OpenForm3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f is Form3)
                {
                    f.Activate();
                    return;
                }
            }

            Form3 f3 = new Form3();
            f3.MdiParent = this;
            f3.Show();
        }
        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }
        }


    }
}
