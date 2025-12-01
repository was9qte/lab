namespace TicketAndCoursesApp
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
            this.ComboBoxButton = new System.Windows.Forms.Button();
            this.CheckedListBoxButton = new System.Windows.Forms.Button();
            this.ListBoxButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ComboBoxButton
            // 
            this.ComboBoxButton.Location = new System.Drawing.Point(12, 12);
            this.ComboBoxButton.Name = "ComboBoxButton";
            this.ComboBoxButton.Size = new System.Drawing.Size(127, 23);
            this.ComboBoxButton.TabIndex = 0;
            this.ComboBoxButton.Text = "Заказ билетов";
            this.ComboBoxButton.UseVisualStyleBackColor = true;
            this.ComboBoxButton.Click += new System.EventHandler(this.ComboBoxButton_Click);
            // 
            // CheckedListBoxButton
            // 
            this.CheckedListBoxButton.Location = new System.Drawing.Point(12, 76);
            this.CheckedListBoxButton.Name = "CheckedListBoxButton";
            this.CheckedListBoxButton.Size = new System.Drawing.Size(127, 23);
            this.CheckedListBoxButton.TabIndex = 1;
            this.CheckedListBoxButton.Text = "Запись на курсы";
            this.CheckedListBoxButton.UseVisualStyleBackColor = true;
            this.CheckedListBoxButton.Click += new System.EventHandler(this.CheckedListBoxButton_Click);
            // 
            // ListBoxButton
            // 
            this.ListBoxButton.Location = new System.Drawing.Point(12, 143);
            this.ListBoxButton.Name = "ListBoxButton";
            this.ListBoxButton.Size = new System.Drawing.Size(127, 23);
            this.ListBoxButton.TabIndex = 2;
            this.ListBoxButton.Text = "Работа со списками";
            this.ListBoxButton.UseVisualStyleBackColor = true;
            this.ListBoxButton.Click += new System.EventHandler(this.ListBoxButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(166, 185);
            this.Controls.Add(this.ListBoxButton);
            this.Controls.Add(this.CheckedListBoxButton);
            this.Controls.Add(this.ComboBoxButton);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ComboBoxButton;
        private System.Windows.Forms.Button CheckedListBoxButton;
        private System.Windows.Forms.Button ListBoxButton;
    }
}

