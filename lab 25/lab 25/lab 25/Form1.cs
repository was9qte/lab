using System;
using System.Windows.Forms;

namespace AgeAndSphereCalculator
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
            SetupUI();
        }
        private void SetupUI()
        {
            // 5.1 — Поле DateTimePicker для даты рождения
            var lblDOB = new Label
            {
                Text = "Дата рождения:",
                Location = new System.Drawing.Point(20, 20),
                AutoSize = true
            };
            this.Controls.Add(lblDOB);

            var dtpDOB = new DateTimePicker
            {
                Location = new System.Drawing.Point(120, 20),
                Width = 150,
                MaxDate = DateTime.Today  // текущая дата как максимум
            };
            dtpDOB.ValueChanged += DtpDOB_ValueChanged;
            this.Controls.Add(dtpDOB);

            var lblAge = new Label
            {
                Text = "Возраст: —",
                Location = new System.Drawing.Point(280, 20),
                AutoSize = true
            };
            this.Controls.Add(lblAge);
            // Сохраняем ссылку для обновления
            this.Tag = new { DOBPicker = dtpDOB, AgeLabel = lblAge };

            // 5.3 — Бегунок (TrackBar) для температуры
            var lblTemp = new Label
            {
                Text = "Температура (°C):",
                Location = new System.Drawing.Point(20, 70),
                AutoSize = true
            };
            this.Controls.Add(lblTemp);

            var trkTemp = new TrackBar
            {
                Location = new System.Drawing.Point(140, 70),
                Width = 200,
                Minimum = 10,
                Maximum = 50,
                TickFrequency = 5
            };
            trkTemp.ValueChanged += TrkTemp_ValueChanged;
            this.Controls.Add(trkTemp);

            var txtTemp = new TextBox
            {
                Text = trkTemp.Value.ToString(),
                Location = new System.Drawing.Point(350, 70),
                Width = 50,
                ReadOnly = true
            };
            this.Controls.Add(txtTemp);
            // Сохраняем ссылки
            var tempControls = new { TrackBar = trkTemp, TextBox = txtTemp };
            if (this.Tag is var tag && tag != null)
                this.Tag = new { ((dynamic)tag).DOBPicker, ((dynamic)tag).AgeLabel, TempControls = tempControls };

            // 5.4 — Ввод радиуса сферы
            var lblRadius = new Label
            {
                Text = "Радиус сферы (м):",
                Location = new System.Drawing.Point(20, 120),
                AutoSize = true
            };
            this.Controls.Add(lblRadius);

            var txtRadius = new NumericUpDown
            {
                Location = new System.Drawing.Point(140, 120),
                Width = 100,
                DecimalPlaces = 2,
                Increment = new decimal(0.1),
                Minimum = new decimal(0.1),
                Maximum = new decimal(100.0)
            };
            txtRadius.ValueChanged += TxtRadius_ValueChanged;
            this.Controls.Add(txtRadius);

            var lblResults = new Label
            {
                Text = "Площадь: — м²\nОбъём: — м³",
                Location = new System.Drawing.Point(260, 120),
                AutoSize = true,
                TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            };
            this.Controls.Add(lblResults);
            // Сохраняем ссылки
            var sphereControls = new { RadiusInput = txtRadius, ResultsLabel = lblResults };
            if (this.Tag is var tag2 && tag2 != null)
                this.Tag = new { ((dynamic)tag2).DOBPicker, ((dynamic)tag2).AgeLabel, ((dynamic)tag2).TempControls, SphereControls = sphereControls };
        }

        // 5.2 — Подсчёт возраста при изменении даты рождения
        private void DtpDOB_ValueChanged(object sender, EventArgs e)
        {
            if (this.Tag is var tag && tag != null)
            {
                var dtp = (DateTimePicker)((dynamic)tag).DOBPicker;
                var lbl = (Label)((dynamic)tag).AgeLabel;

                int age = DateTime.Today.Year - dtp.Value.Year;
                if (DateTime.Today < dtp.Value.AddYears(age))
                    age--;

                lbl.Text = $"Возраст: {age}";
            }
        }

        // 5.3 — Отображение температуры при движении бегунка
        private void TrkTemp_ValueChanged(object sender, EventArgs e)
        {
            if (this.Tag is var tag && tag != null)
            {
                var trk = (TrackBar)((dynamic)tag).TempControls.TrackBar;
                var txt = (TextBox)((dynamic)tag).TempControls.TextBox;

                txt.Text = trk.Value.ToString();
            }
        }

        // 5.4 — Расчёт площади и объёма сферы при изменении радиуса
        private void TxtRadius_ValueChanged(object sender, EventArgs e)
        {
            if (this.Tag is var tag && tag != null)
            {
                var nud = (NumericUpDown)((dynamic)tag).SphereControls.RadiusInput;
                var lbl = (Label)((dynamic)tag).SphereControls.ResultsLabel;

                decimal r = nud.Value;
                double radius = (double)r;

                // Площадь сферы: $S = 4 \pi r^{2}$
                double area = 4 * Math.PI * Math.Pow(radius, 2);
                // Объём сферы: $V = \frac{4}{3} \pi r^{3}$
                double volume = (4.0 / 3.0) * Math.PI * Math.Pow(radius, 3);

                lbl.Text = $"Площадь: {area:F2} м²\nОбъём: {volume:F2} м³";
            }
        }
    }
}
