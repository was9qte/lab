namespace lab35
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
            this.btnOpenMDI = new System.Windows.Forms.Button();
            this.btnOpenDialog = new System.Windows.Forms.Button();
            this.btnOpenNormal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenMDI
            // 
            this.btnOpenMDI.Location = new System.Drawing.Point(509, 50);
            this.btnOpenMDI.Name = "btnOpenMDI";
            this.btnOpenMDI.Size = new System.Drawing.Size(166, 23);
            this.btnOpenMDI.TabIndex = 5;
            this.btnOpenMDI.Text = "Открыть MDI-форму";
            this.btnOpenMDI.UseVisualStyleBackColor = true;
            this.btnOpenMDI.Click += new System.EventHandler(this.btnOpenMDI_Click);
            // 
            // btnOpenDialog
            // 
            this.btnOpenDialog.Location = new System.Drawing.Point(279, 50);
            this.btnOpenDialog.Name = "btnOpenDialog";
            this.btnOpenDialog.Size = new System.Drawing.Size(224, 23);
            this.btnOpenDialog.TabIndex = 4;
            this.btnOpenDialog.Text = "Открыть форму в диалоговом режиме";
            this.btnOpenDialog.UseVisualStyleBackColor = true;
            this.btnOpenDialog.Click += new System.EventHandler(this.btnOpenDialog_Click);
            // 
            // btnOpenNormal
            // 
            this.btnOpenNormal.Location = new System.Drawing.Point(90, 50);
            this.btnOpenNormal.Name = "btnOpenNormal";
            this.btnOpenNormal.Size = new System.Drawing.Size(183, 23);
            this.btnOpenNormal.TabIndex = 3;
            this.btnOpenNormal.Text = "Открыть форму";
            this.btnOpenNormal.UseVisualStyleBackColor = true;
            this.btnOpenNormal.Click += new System.EventHandler(this.btnOpenNormal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpenMDI);
            this.Controls.Add(this.btnOpenDialog);
            this.Controls.Add(this.btnOpenNormal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenMDI;
        private System.Windows.Forms.Button btnOpenDialog;
        private System.Windows.Forms.Button btnOpenNormal;
    }
}

