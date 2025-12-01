using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labwork
{
    public partial class Project : Form
    {
        public Project()
        {
            InitializeComponent();
        }

       

        private void FontDialog_Apply(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                RichTextBox.SelectionFont = fontDialog.Font;
            }
        }
        private void SettingsColor_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                RichTextBox.SelectionColor = colorDialog.Color;
            }
        }
        private void FolderBrowserDialog_HelpRequest_1(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = folderBrowserDialog.SelectedPath;
                openFileDialog.InitialDirectory = selectedPath;
                saveFileDialog.InitialDirectory = selectedPath;
            }
        }

        private void SaveFileDialog_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                if (filePath.EndsWith(".rtf"))
                {
                    RichTextBox.SaveFile(filePath, RichTextBoxStreamType.RichText);
                }
                else
                {
                    RichTextBox.SaveFile(filePath, RichTextBoxStreamType.PlainText);
                }
            }
        }

        private void OpenFileDialog_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                if (filePath.EndsWith(".rtf"))
                {
                    RichTextBox.LoadFile(filePath, RichTextBoxStreamType.RichText);
                }
                else
                {
                    RichTextBox.LoadFile(filePath, RichTextBoxStreamType.PlainText);
                }
            }
        }
    }
}
