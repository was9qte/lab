using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWork
{
    public partial class NotesForm : Form
    {
        public NotesForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string filePath = "Notes.txt";
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Файл Notes.txt не существует. Будет создан новый файл.",
                    "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            try
            {
                using (StreamWriter writer = File.AppendText(filePath))
                {
                    writer.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    writer.WriteLine(NotesTextBox.Text);
                    writer.WriteLine();
                }

                MessageBox.Show("Заметка успешно сохранена!", "Успех",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                NotesTextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при записи в файл: {ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
