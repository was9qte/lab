using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
private void dtpBirthDate_ValueChanged(object sender, EventArgs e)
        {
            int age = DateTime.Today.Year - dtpBirthDate.Value.Year;
            if (dtpBirthDate.Value > DateTime.Today.AddYears(-age))
                age--;
            lblAge.Text = $"Возраст: {age} лет";
        }
        private void trackBarTemp_Scroll(object sender, EventArgs e)
        {
            txtTemp.Text = trackBarTemp.Value.ToString();
        }
        private void nudRadius_ValueChanged(object sender, EventArgs e)
        {
            double r = (double)nudRadius.Value;
            double area = 4 * Math.PI * r * r;
            double volume = (4.0 / 3.0) * Math.PI * r * r * r;

            lblSurfaceArea.Text = $"Площадь: {Math.Round(area, 2)} м²";
            lblVolume.Text = $"Объём: {Math.Round(volume, 2)} м³";
        }

    }
}

