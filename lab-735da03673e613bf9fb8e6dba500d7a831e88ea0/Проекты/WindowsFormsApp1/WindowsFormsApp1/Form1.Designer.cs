namespace WindowsFormsApp1
{
    partial class Form1
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
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.trackBarTemp = new System.Windows.Forms.TrackBar();
            this.lblTemp = new System.Windows.Forms.Label();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.nudRadius = new System.Windows.Forms.NumericUpDown();
            this.lblRadius = new System.Windows.Forms.Label();
            this.lblSurfaceArea = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRadius)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Location = new System.Drawing.Point(168, 12);
            this.dtpBirthDate.MaxDate = new System.DateTime(2025, 11, 19, 0, 0, 0, 0);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(200, 20);
            this.dtpBirthDate.TabIndex = 0;
            this.dtpBirthDate.Value = new System.DateTime(2025, 11, 19, 0, 0, 0, 0);
            this.dtpBirthDate.ValueChanged += new System.EventHandler(this.dtpBirthDate_ValueChanged);
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(52, 18);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(89, 13);
            this.lblBirthDate.TabIndex = 1;
            this.lblBirthDate.Text = "Дата рождения:";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(392, 18);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(81, 13);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Возраст: 0 лет";
            // 
            // trackBarTemp
            // 
            this.trackBarTemp.Location = new System.Drawing.Point(168, 77);
            this.trackBarTemp.Maximum = 50;
            this.trackBarTemp.Minimum = 10;
            this.trackBarTemp.Name = "trackBarTemp";
            this.trackBarTemp.Size = new System.Drawing.Size(104, 45);
            this.trackBarTemp.TabIndex = 3;
            this.trackBarTemp.Value = 20;
            this.trackBarTemp.Scroll += new System.EventHandler(this.trackBarTemp_Scroll);
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(52, 77);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(97, 13);
            this.lblTemp.TabIndex = 4;
            this.lblTemp.Text = "Температура (°C):";
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(395, 59);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.ReadOnly = true;
            this.txtTemp.Size = new System.Drawing.Size(100, 20);
            this.txtTemp.TabIndex = 5;
            // 
            // nudRadius
            // 
            this.nudRadius.DecimalPlaces = 2;
            this.nudRadius.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudRadius.Location = new System.Drawing.Point(168, 128);
            this.nudRadius.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudRadius.Name = "nudRadius";
            this.nudRadius.Size = new System.Drawing.Size(120, 20);
            this.nudRadius.TabIndex = 6;
            this.nudRadius.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRadius.ValueChanged += new System.EventHandler(this.nudRadius_ValueChanged);
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(52, 130);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(100, 13);
            this.lblRadius.TabIndex = 7;
            this.lblRadius.Text = "Радиус сферы (м):";
            // 
            // lblSurfaceArea
            // 
            this.lblSurfaceArea.AutoSize = true;
            this.lblSurfaceArea.Location = new System.Drawing.Point(177, 170);
            this.lblSurfaceArea.Name = "lblSurfaceArea";
            this.lblSurfaceArea.Size = new System.Drawing.Size(95, 13);
            this.lblSurfaceArea.TabIndex = 8;
            this.lblSurfaceArea.Text = "Площадь: 0.00 м²";
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(177, 201);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(83, 13);
            this.lblVolume.TabIndex = 9;
            this.lblVolume.Text = "Объём: 0.00 м³";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.lblSurfaceArea);
            this.Controls.Add(this.lblRadius);
            this.Controls.Add(this.nudRadius);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.trackBarTemp);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblBirthDate);
            this.Controls.Add(this.dtpBirthDate);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRadius)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TrackBar trackBarTemp;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.NumericUpDown nudRadius;
        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.Label lblSurfaceArea;
        private System.Windows.Forms.Label lblVolume;
    }
}

