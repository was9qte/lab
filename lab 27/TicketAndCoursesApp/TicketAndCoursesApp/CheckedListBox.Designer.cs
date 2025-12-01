namespace TicketAndCoursesApp
{
    partial class CheckedListBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CoursesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.EnrollButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CoursesCheckedListBox
            // 
            this.CoursesCheckedListBox.FormattingEnabled = true;
            this.CoursesCheckedListBox.Items.AddRange(new object[] {
            "Программирование на C#",
            "Веб-разработка",
            "Базы данных",
            "Алгоритмы и структуры данных",
            "Мобильная разработка",
            "Кибербезопасность",
            "Машинное обучение",
            "Графический дизайн",
            "Английский для IT",
            "Проектный менеджмент"});
            this.CoursesCheckedListBox.Location = new System.Drawing.Point(12, 12);
            this.CoursesCheckedListBox.Name = "CoursesCheckedListBox";
            this.CoursesCheckedListBox.Size = new System.Drawing.Size(186, 154);
            this.CoursesCheckedListBox.TabIndex = 0;
            // 
            // EnrollButton
            // 
            this.EnrollButton.Location = new System.Drawing.Point(12, 205);
            this.EnrollButton.Name = "EnrollButton";
            this.EnrollButton.Size = new System.Drawing.Size(75, 23);
            this.EnrollButton.TabIndex = 1;
            this.EnrollButton.Text = "Записаться";
            this.EnrollButton.UseVisualStyleBackColor = true;
            this.EnrollButton.Click += new System.EventHandler(this.EnrollButton_Click);
            // 
            // CheckedListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 262);
            this.Controls.Add(this.EnrollButton);
            this.Controls.Add(this.CoursesCheckedListBox);
            this.Name = "CheckedListBox";
            this.Text = "CheckedListBox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox CoursesCheckedListBox;
        private System.Windows.Forms.Button EnrollButton;
    }
}