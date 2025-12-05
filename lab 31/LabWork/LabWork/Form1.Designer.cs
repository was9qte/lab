namespace LabWork
{
    partial class TextForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextForm));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FormattingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RichTextBox = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.FontComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.LeftAlignButton = new System.Windows.Forms.ToolStripButton();
            this.CenterAlignButton = new System.Windows.Forms.ToolStripButton();
            this.RightAlignButton = new System.Windows.Forms.ToolStripButton();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.DateLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.CharCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.NoSpaceCharCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.MenuStrip.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.ToolStrip.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.FormattingToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 25);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(800, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateToolStripMenuItem,
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.toolStripSeparator1,
            this.CloseToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // CreateToolStripMenuItem
            // 
            this.CreateToolStripMenuItem.Name = "CreateToolStripMenuItem";
            this.CreateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.CreateToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.CreateToolStripMenuItem.Text = "Создать";
            this.CreateToolStripMenuItem.Click += new System.EventHandler(this.CreateToolStripMenuItem_Click);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.OpenToolStripMenuItem.Text = "Открыть";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.SaveToolStripMenuItem.Text = "Сохранить";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(170, 6);
            // 
            // CloseToolStripMenuItem
            // 
            this.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem";
            this.CloseToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.CloseToolStripMenuItem.Text = "Закрыть";
            this.CloseToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // FormattingToolStripMenuItem
            // 
            this.FormattingToolStripMenuItem.DropDown = this.contextMenuStrip1;
            this.FormattingToolStripMenuItem.Name = "FormattingToolStripMenuItem";
            this.FormattingToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.FormattingToolStripMenuItem.Text = "Форматирование";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ColorToolStripMenuItem,
            this.FontToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.OwnerItem = this.FormattingToolStripMenuItem;
            this.contextMenuStrip1.Size = new System.Drawing.Size(114, 48);
            // 
            // ColorToolStripMenuItem
            // 
            this.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem";
            this.ColorToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.ColorToolStripMenuItem.Text = "Цвет";
            this.ColorToolStripMenuItem.Click += new System.EventHandler(this.ColorToolStripMenuItem_Click);
            // 
            // FontToolStripMenuItem
            // 
            this.FontToolStripMenuItem.Name = "FontToolStripMenuItem";
            this.FontToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.FontToolStripMenuItem.Text = "Шрифт";
            this.FontToolStripMenuItem.Click += new System.EventHandler(this.FontToolStripMenuItem_Click);
            // 
            // RichTextBox
            // 
            this.RichTextBox.ContextMenuStrip = this.contextMenuStrip1;
            this.RichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTextBox.Location = new System.Drawing.Point(0, 49);
            this.RichTextBox.Name = "RichTextBox";
            this.RichTextBox.Size = new System.Drawing.Size(800, 380);
            this.RichTextBox.TabIndex = 1;
            this.RichTextBox.Text = "";
            this.RichTextBox.TextChanged += new System.EventHandler(this.RichTextBox_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|RTF-файлы (*.rtf)|*.rtf|Все файлы (*.*)|*.*";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|RTF-файлы (*.rtf)|*.rtf";
            // 
            // ToolStrip
            // 
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FontComboBox,
            this.LeftAlignButton,
            this.CenterAlignButton,
            this.RightAlignButton});
            this.ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(800, 25);
            this.ToolStrip.TabIndex = 3;
            this.ToolStrip.Text = "toolStrip1";
            // 
            // FontComboBox
            // 
            this.FontComboBox.Name = "FontComboBox";
            this.FontComboBox.Size = new System.Drawing.Size(121, 25);
            this.FontComboBox.SelectedIndexChanged += new System.EventHandler(this.FontComboBox_SelectedIndexChanged);
            // 
            // LeftAlignButton
            // 
            this.LeftAlignButton.Checked = true;
            this.LeftAlignButton.CheckOnClick = true;
            this.LeftAlignButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LeftAlignButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.LeftAlignButton.Image = ((System.Drawing.Image)(resources.GetObject("LeftAlignButton.Image")));
            this.LeftAlignButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LeftAlignButton.Name = "LeftAlignButton";
            this.LeftAlignButton.Size = new System.Drawing.Size(103, 22);
            this.LeftAlignButton.Text = "По левому краю";
            this.LeftAlignButton.Click += new System.EventHandler(this.LeftAlignButton_Click);
            // 
            // CenterAlignButton
            // 
            this.CenterAlignButton.CheckOnClick = true;
            this.CenterAlignButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CenterAlignButton.Image = ((System.Drawing.Image)(resources.GetObject("CenterAlignButton.Image")));
            this.CenterAlignButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CenterAlignButton.Name = "CenterAlignButton";
            this.CenterAlignButton.Size = new System.Drawing.Size(68, 22);
            this.CenterAlignButton.Text = "По центру";
            this.CenterAlignButton.Click += new System.EventHandler(this.CenterAlignButton_Click);
            // 
            // RightAlignButton
            // 
            this.RightAlignButton.CheckOnClick = true;
            this.RightAlignButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RightAlignButton.Image = ((System.Drawing.Image)(resources.GetObject("RightAlignButton.Image")));
            this.RightAlignButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RightAlignButton.Name = "RightAlignButton";
            this.RightAlignButton.Size = new System.Drawing.Size(110, 22);
            this.RightAlignButton.Text = "По правому краю";
            this.RightAlignButton.Click += new System.EventHandler(this.RightAlignButton_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DateLabel,
            this.CharCountLabel,
            this.NoSpaceCharCountLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 407);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(800, 22);
            this.StatusStrip.TabIndex = 4;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // DateLabel
            // 
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(57, 17);
            this.DateLabel.Text = "Для даты";
            // 
            // CharCountLabel
            // 
            this.CharCountLabel.Name = "CharCountLabel";
            this.CharCountLabel.Size = new System.Drawing.Size(130, 17);
            this.CharCountLabel.Text = "Количество символов";
            // 
            // NoSpaceCharCountLabel
            // 
            this.NoSpaceCharCountLabel.Name = "NoSpaceCharCountLabel";
            this.NoSpaceCharCountLabel.Size = new System.Drawing.Size(142, 17);
            this.NoSpaceCharCountLabel.Text = "Символов без пробелов";
            // 
            // Timer
            // 
            this.Timer.Interval = 1000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // TextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 429);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.RichTextBox);
            this.Controls.Add(this.MenuStrip);
            this.Controls.Add(this.ToolStrip);
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "TextForm";
            this.Text = "Текстовый документ";
            this.Load += new System.EventHandler(this.TextForm_Load);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CreateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem CloseToolStripMenuItem;
        private System.Windows.Forms.RichTextBox RichTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FontToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem FormattingToolStripMenuItem;
        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.ToolStripComboBox FontComboBox;
        private System.Windows.Forms.ToolStripButton LeftAlignButton;
        private System.Windows.Forms.ToolStripButton CenterAlignButton;
        private System.Windows.Forms.ToolStripButton RightAlignButton;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel DateLabel;
        private System.Windows.Forms.ToolStripStatusLabel CharCountLabel;
        private System.Windows.Forms.ToolStripStatusLabel NoSpaceCharCountLabel;
        private System.Windows.Forms.Timer Timer;
    }
}

