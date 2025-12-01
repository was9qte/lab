namespace labwork25
{
    partial class Project
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.DateTimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.LabelBirthDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelAge = new System.Windows.Forms.Label();
            this.TrackBarTemperature = new System.Windows.Forms.TrackBar();
            this.LabelTemperature = new System.Windows.Forms.Label();
            this.TextTemperature = new System.Windows.Forms.TextBox();
            this.LabelRadius = new System.Windows.Forms.Label();
            this.NumericUpDownRadius = new System.Windows.Forms.NumericUpDown();
            this.LabelSurfaceArea = new System.Windows.Forms.Label();
            this.LabelVolume = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownRadius)).BeginInit();
            this.SuspendLayout();
            // 
            // DateTimePickerBirthDate
            // 
            this.DateTimePickerBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerBirthDate.Location = new System.Drawing.Point(133, 6);
            this.DateTimePickerBirthDate.Name = "DateTimePickerBirthDate";
            this.DateTimePickerBirthDate.Size = new System.Drawing.Size(200, 20);
            this.DateTimePickerBirthDate.TabIndex = 0;
            this.DateTimePickerBirthDate.ValueChanged += new System.EventHandler(this.DateTimePickerBirthDate_ValueChanged);
            // 
            // LabelBirthDate
            // 
            this.LabelBirthDate.AutoSize = true;
            this.LabelBirthDate.Location = new System.Drawing.Point(1, 12);
            this.LabelBirthDate.Name = "LabelBirthDate";
            this.LabelBirthDate.Size = new System.Drawing.Size(89, 13);
            this.LabelBirthDate.TabIndex = 1;
            this.LabelBirthDate.Text = "Дата рождения:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(412, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // LabelAge
            // 
            this.LabelAge.AutoSize = true;
            this.LabelAge.Location = new System.Drawing.Point(358, 12);
            this.LabelAge.Name = "LabelAge";
            this.LabelAge.Size = new System.Drawing.Size(35, 13);
            this.LabelAge.TabIndex = 2;
            this.LabelAge.Text = "label2";
            // 
            // TrackBarTemperature
            // 
            this.TrackBarTemperature.Location = new System.Drawing.Point(154, 58);
            this.TrackBarTemperature.Maximum = 50;
            this.TrackBarTemperature.Minimum = 10;
            this.TrackBarTemperature.Name = "TrackBarTemperature";
            this.TrackBarTemperature.Size = new System.Drawing.Size(104, 45);
            this.TrackBarTemperature.TabIndex = 3;
            this.TrackBarTemperature.TickFrequency = 5;
            this.TrackBarTemperature.Value = 10;
            this.TrackBarTemperature.Scroll += new System.EventHandler(this.TrackBarTemperature_ValueChanged);
            this.TrackBarTemperature.ValueChanged += new System.EventHandler(this.TrackBarTemperature_ValueChanged);
            // 
            // LabelTemperature
            // 
            this.LabelTemperature.AutoSize = true;
            this.LabelTemperature.Location = new System.Drawing.Point(1, 70);
            this.LabelTemperature.Name = "LabelTemperature";
            this.LabelTemperature.Size = new System.Drawing.Size(97, 13);
            this.LabelTemperature.TabIndex = 4;
            this.LabelTemperature.Text = "Температура (°C):";
            // 
            // TextTemperature
            // 
            this.TextTemperature.Location = new System.Drawing.Point(308, 67);
            this.TextTemperature.Name = "TextTemperature";
            this.TextTemperature.ReadOnly = true;
            this.TextTemperature.Size = new System.Drawing.Size(100, 20);
            this.TextTemperature.TabIndex = 5;
            // 
            // LabelRadius
            // 
            this.LabelRadius.AutoSize = true;
            this.LabelRadius.Location = new System.Drawing.Point(1, 117);
            this.LabelRadius.Name = "LabelRadius";
            this.LabelRadius.Size = new System.Drawing.Size(100, 13);
            this.LabelRadius.TabIndex = 6;
            this.LabelRadius.Text = "Радиус сферы (м):";
            // 
            // NumericUpDownRadius
            // 
            this.NumericUpDownRadius.DecimalPlaces = 2;
            this.NumericUpDownRadius.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericUpDownRadius.Location = new System.Drawing.Point(154, 115);
            this.NumericUpDownRadius.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericUpDownRadius.Name = "NumericUpDownRadius";
            this.NumericUpDownRadius.Size = new System.Drawing.Size(120, 20);
            this.NumericUpDownRadius.TabIndex = 7;
            this.NumericUpDownRadius.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumericUpDownRadius.ValueChanged += new System.EventHandler(this.NumericUpDownRadius_ValueChanged);
            // 
            // LabelSurfaceArea
            // 
            this.LabelSurfaceArea.AutoSize = true;
            this.LabelSurfaceArea.Location = new System.Drawing.Point(337, 117);
            this.LabelSurfaceArea.Name = "LabelSurfaceArea";
            this.LabelSurfaceArea.Size = new System.Drawing.Size(127, 13);
            this.LabelSurfaceArea.TabIndex = 8;
            this.LabelSurfaceArea.Text = "Площадь поверхности: ";
            // 
            // LabelVolume
            // 
            this.LabelVolume.AutoSize = true;
            this.LabelVolume.Location = new System.Drawing.Point(529, 117);
            this.LabelVolume.Name = "LabelVolume";
            this.LabelVolume.Size = new System.Drawing.Size(48, 13);
            this.LabelVolume.TabIndex = 9;
            this.LabelVolume.Text = "Объём: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelVolume);
            this.Controls.Add(this.LabelSurfaceArea);
            this.Controls.Add(this.NumericUpDownRadius);
            this.Controls.Add(this.LabelRadius);
            this.Controls.Add(this.TextTemperature);
            this.Controls.Add(this.LabelTemperature);
            this.Controls.Add(this.TrackBarTemperature);
            this.Controls.Add(this.LabelAge);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelBirthDate);
            this.Controls.Add(this.DateTimePickerBirthDate);
            this.Name = "Form1";
            this.Text = "Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownRadius)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DateTimePickerBirthDate;
        private System.Windows.Forms.Label LabelBirthDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelAge;
        private System.Windows.Forms.TrackBar TrackBarTemperature;
        private System.Windows.Forms.Label LabelTemperature;
        private System.Windows.Forms.TextBox TextTemperature;
        private System.Windows.Forms.Label LabelRadius;
        private System.Windows.Forms.NumericUpDown NumericUpDownRadius;
        private System.Windows.Forms.Label LabelSurfaceArea;
        private System.Windows.Forms.Label LabelVolume;
    }
}

