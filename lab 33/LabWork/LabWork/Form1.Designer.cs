namespace LabWork
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
            this.NotesButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.PurchasesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NotesButton
            // 
            this.NotesButton.Location = new System.Drawing.Point(61, 14);
            this.NotesButton.Name = "NotesButton";
            this.NotesButton.Size = new System.Drawing.Size(87, 23);
            this.NotesButton.TabIndex = 0;
            this.NotesButton.Text = "Заметки";
            this.NotesButton.UseVisualStyleBackColor = true;
            this.NotesButton.Click += new System.EventHandler(this.NotesButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(61, 44);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(87, 23);
            this.LoginButton.TabIndex = 1;
            this.LoginButton.Text = "Авторизация";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // PurchasesButton
            // 
            this.PurchasesButton.Location = new System.Drawing.Point(61, 73);
            this.PurchasesButton.Name = "PurchasesButton";
            this.PurchasesButton.Size = new System.Drawing.Size(87, 23);
            this.PurchasesButton.TabIndex = 2;
            this.PurchasesButton.Text = "Покупки";
            this.PurchasesButton.UseVisualStyleBackColor = true;
            this.PurchasesButton.Click += new System.EventHandler(this.PurchasesButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 114);
            this.Controls.Add(this.PurchasesButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.NotesButton);
            this.Name = "Form1";
            this.Text = "Главная";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NotesButton;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button PurchasesButton;
    }
}

