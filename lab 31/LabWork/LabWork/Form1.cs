using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWork
{
    public partial class TextForm : Form
    {
        public TextForm()
        {
            InitializeComponent();
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox.Clear();
            this.Text = "Безымянный";
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                RichTextBox.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                this.Text = openFileDialog1.FileName;
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                RichTextBox.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void ColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                RichTextBox.SelectionColor = colorDialog1.Color;
            }
        }

        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                RichTextBox.SelectionFont = fontDialog1.Font;
            }
        }

        private void TextForm_Load(object sender, EventArgs e)
        {
            foreach (FontFamily font in FontFamily.Families)
            {
                FontComboBox.Items.Add(font.Name);
            }
            FontComboBox.Text = "Arial";
            DateLabel.Text = DateTime.Now.ToString("dd.MM.yyyy");
            Timer.Start();
        }

        private void FontComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(FontComboBox.Text))
            {
                RichTextBox.SelectionFont = new Font(FontComboBox.Text, RichTextBox.SelectionFont.Size);
            }
        }

        private void LeftAlignButton_Click(object sender, EventArgs e)
        {
            RichTextBox.SelectionAlignment = HorizontalAlignment.Left;
            CenterAlignButton.Checked = false;
            RightAlignButton.Checked = false;
        }

        private void CenterAlignButton_Click(object sender, EventArgs e)
        {
            RichTextBox.SelectionAlignment = HorizontalAlignment.Center;
            LeftAlignButton.Checked = false;
            RightAlignButton.Checked = false;
        }

        private void RightAlignButton_Click(object sender, EventArgs e)
        {
            RichTextBox.SelectionAlignment = HorizontalAlignment.Right;
            LeftAlignButton.Checked = false;
            CenterAlignButton.Checked = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateLabel.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }

        private void RichTextBox_TextChanged(object sender, EventArgs e)
        {
            int totalChars = RichTextBox.Text.Length;
            int noSpaceChars = RichTextBox.Text.Replace(" ", "").Length;

            CharCountLabel.Text = $"Символов: {totalChars}";
            NoSpaceCharCountLabel.Text = $"Без пробелов: {noSpaceChars}";
        }
    }
}
