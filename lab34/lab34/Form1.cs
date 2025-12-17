using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab34
{
    public partial class Form1 : Form
    {
        private int seconds = 0;
        private int minutes = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;

            if (seconds == 60)
            {
                minutes++;
                seconds = 0;
            }

            lblTime.Text = $"{minutes:D2}:{seconds:D2}";
        }
    }
}

