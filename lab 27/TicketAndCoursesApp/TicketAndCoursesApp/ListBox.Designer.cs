namespace TicketAndCoursesApp
{
    partial class ListBox
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
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.ListBox2 = new System.Windows.Forms.ListBox();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.MoveSelectedButton = new System.Windows.Forms.Button();
            this.MoveAllButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListBox1
            // 
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.Location = new System.Drawing.Point(12, 12);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.Size = new System.Drawing.Size(120, 95);
            this.ListBox1.TabIndex = 0;
            // 
            // ListBox2
            // 
            this.ListBox2.FormattingEnabled = true;
            this.ListBox2.Location = new System.Drawing.Point(12, 113);
            this.ListBox2.Name = "ListBox2";
            this.ListBox2.Size = new System.Drawing.Size(120, 95);
            this.ListBox2.TabIndex = 1;
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(23, 226);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(100, 20);
            this.InputTextBox.TabIndex = 2;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(33, 252);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // MoveSelectedButton
            // 
            this.MoveSelectedButton.Location = new System.Drawing.Point(33, 302);
            this.MoveSelectedButton.Name = "MoveSelectedButton";
            this.MoveSelectedButton.Size = new System.Drawing.Size(75, 23);
            this.MoveSelectedButton.TabIndex = 4;
            this.MoveSelectedButton.Text = ">";
            this.MoveSelectedButton.UseVisualStyleBackColor = true;
            this.MoveSelectedButton.Click += new System.EventHandler(this.MoveSelectedButton_Click);
            // 
            // MoveAllButton
            // 
            this.MoveAllButton.Location = new System.Drawing.Point(33, 346);
            this.MoveAllButton.Name = "MoveAllButton";
            this.MoveAllButton.Size = new System.Drawing.Size(75, 23);
            this.MoveAllButton.TabIndex = 5;
            this.MoveAllButton.Text = ">>";
            this.MoveAllButton.UseVisualStyleBackColor = true;
            this.MoveAllButton.Click += new System.EventHandler(this.MoveAllButton_Click);
            // 
            // ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 386);
            this.Controls.Add(this.MoveAllButton);
            this.Controls.Add(this.MoveSelectedButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.ListBox2);
            this.Controls.Add(this.ListBox1);
            this.Name = "ListBox";
            this.Text = "ListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBox1;
        private System.Windows.Forms.ListBox ListBox2;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button MoveSelectedButton;
        private System.Windows.Forms.Button MoveAllButton;
    }
}