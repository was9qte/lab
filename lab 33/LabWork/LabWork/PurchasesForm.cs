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
    public partial class PurchasesForm : Form
    {
        public PurchasesForm()
        {
            InitializeComponent();
            PurchasesDataGridView.AllowUserToAddRows = true;
            PurchasesDataGridView.AllowUserToDeleteRows = true;
        }

        private void SaveCsvBsvutton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "CSV файлы (*.csv)|*.csv|Текстовые файлы (*.txt)|*.txt";
            saveDialog.DefaultExt = "csv";
            saveDialog.AddExtension = true;

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(saveDialog.FileName, false, System.Text.Encoding.UTF8))
                    {
                        writer.WriteLine("Товар;Цена;Количество");
                        foreach (DataGridViewRow row in PurchasesDataGridView.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                string product = row.Cells["Product"].Value?.ToString() ?? "";
                                string price = row.Cells["Price"].Value?.ToString() ?? "";
                                string quantity = row.Cells["Quantity"].Value?.ToString() ?? "";

                                writer.WriteLine($"{product};{price};{quantity}");
                            }
                        }
                    }
                    MessageBox.Show("Данные успешно сохранены!", "Успех",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}",
                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

}
