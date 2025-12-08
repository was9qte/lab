namespace MainForm
{
    partial class MainForm
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
            this.TaskButton1 = new System.Windows.Forms.Button();
            this.TaskButton3 = new System.Windows.Forms.Button();
            this.TaskButton4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TaskButton1
            // 
            this.TaskButton1.Location = new System.Drawing.Point(13, 13);
            this.TaskButton1.Name = "TaskButton1";
            this.TaskButton1.Size = new System.Drawing.Size(176, 23);
            this.TaskButton1.TabIndex = 0;
            this.TaskButton1.Text = "Таблица квадратов/умножения";
            this.TaskButton1.UseVisualStyleBackColor = true;
            this.TaskButton1.Click += new System.EventHandler(this.TaskButton1_Click);
            // 
            // TaskButton3
            // 
            this.TaskButton3.Location = new System.Drawing.Point(13, 42);
            this.TaskButton3.Name = "TaskButton3";
            this.TaskButton3.Size = new System.Drawing.Size(175, 23);
            this.TaskButton3.TabIndex = 4;
            this.TaskButton3.Text = "Настройка столбцов";
            this.TaskButton3.Click += new System.EventHandler(this.TaskButton3_Click);
            // 
            // TaskButton4
            // 
            this.TaskButton4.Location = new System.Drawing.Point(12, 71);
            this.TaskButton4.Name = "TaskButton4";
            this.TaskButton4.Size = new System.Drawing.Size(176, 23);
            this.TaskButton4.TabIndex = 3;
            this.TaskButton4.Text = "Анализ заказа";
            this.TaskButton4.UseVisualStyleBackColor = true;
            this.TaskButton4.Click += new System.EventHandler(this.TaskButton4_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TaskButton4);
            this.Controls.Add(this.TaskButton3);
            this.Controls.Add(this.TaskButton1);
            this.Name = "MainForm";
            this.Text = "Главное меню";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button TaskButton1;
        private System.Windows.Forms.Button TaskButton3;
        private System.Windows.Forms.Button TaskButton4;
    }
}

