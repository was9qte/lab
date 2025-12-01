using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labwork25
{
    public partial class Project : Form
    {
        public Project()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DateTimePickerBirthDate.MaxDate = DateTime.Today;
        }
        private void DateTimePickerBirthDate_ValueChanged(object sender, EventArgs e)
        {
                DateTime birthDate = DateTimePickerBirthDate.Value;
                int age = DateTime.Today.Year - birthDate.Year;
                if (birthDate > DateTime.Today.AddYears(-age))
                    age--;
                LabelAge.Text = $"Возраст: {age} лет";
        }
        private void TrackBarTemperature_ValueChanged(object sender, EventArgs e)
        {
            TextTemperature.Text = TrackBarTemperature.Value.ToString();
        }
        private void NumericUpDownRadius_ValueChanged(object sender, EventArgs e)
        {
            decimal radius = NumericUpDownRadius.Value;
            double surfaceArea = 4 * Math.PI * (double)(radius * radius);
            double volume = (4.0 / 3.0) * Math.PI * Math.Pow((double)radius, 3);
            LabelSurfaceArea.Text = $"Площадь поверхности: {Math.Round(surfaceArea, 2)} м²";
            LabelVolume.Text = $"Объём: {Math.Round(volume, 2)} м³";
        }
    }
}
