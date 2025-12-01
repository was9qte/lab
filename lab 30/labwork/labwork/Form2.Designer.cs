namespace labwork
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.HelloButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.IconCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // HelloButton
            // 
            this.HelloButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HelloButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HelloButton.Location = new System.Drawing.Point(12, 12);
            this.HelloButton.Name = "HelloButton";
            this.HelloButton.Size = new System.Drawing.Size(75, 23);
            this.HelloButton.TabIndex = 0;
            this.HelloButton.Text = "Привет";
            this.HelloButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HelloButton.UseVisualStyleBackColor = true;
            this.HelloButton.Click += new System.EventHandler(this.HelloButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CloseButton.Location = new System.Drawing.Point(12, 41);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Закрыть";
            this.CloseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "png-klev-club-z1wv-p-pivozavr-png-11.png");
            this.imageList1.Images.SetKeyName(1, "dota_icon_249739.ico");
            // 
            // IconCheckBox
            // 
            this.IconCheckBox.Appearance = System.Windows.Forms.Appearance.Button;
            this.IconCheckBox.AutoSize = true;
            this.IconCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconCheckBox.ImageIndex = 1;
            this.IconCheckBox.ImageList = this.imageList1;
            this.IconCheckBox.Location = new System.Drawing.Point(34, 70);
            this.IconCheckBox.Name = "IconCheckBox";
            this.IconCheckBox.Size = new System.Drawing.Size(22, 22);
            this.IconCheckBox.TabIndex = 2;
            this.IconCheckBox.UseVisualStyleBackColor = true;
            this.IconCheckBox.CheckedChanged += new System.EventHandler(this.IconCheckBox_CheckedChanged);
            // 
            // Form2
            // 
            this.AcceptButton = this.HelloButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CloseButton;
            this.ClientSize = new System.Drawing.Size(215, 114);
            this.Controls.Add(this.IconCheckBox);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.HelloButton);
            this.Name = "Form2";
            this.Text = "HelloForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HelloButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.CheckBox IconCheckBox;
    }
}