using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static lab28.MainForm;

namespace lab28
{
    using System;
    using System.Windows.Forms;

    public partial class dataGridForm1 : Form
    {
        public dataGridForm1()
        {
            InitializeComponent();
            SetupDataGridView();
            FillDataGrid();
        }

        private void SetupDataGridView()
        {
            // Запретить добавление, правку и удаление
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;

            // Белый фон
            dataGridView1.BackgroundColor = System.Drawing.Color.White;

            // Автоматическое заполнение ширины столбцов
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FillDataGrid()
        {
            // Добавляем столбцы (пример для 3 столбцов)
            for (int i = 0; i < 3; i++)
            {
                dataGridView1.Columns.Add($"col{i}", $"Столбец {i + 1}");
            }

            // Добавляем строки (пример для 4 строк)
            for (int i = 0; i < 4; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].HeaderCell.Value = $"Строка {i + 1}";
            }

            // Заполняем ячейки данными
            dataGridView1.Rows[0].Cells[0].Value = "5 + 3";
            dataGridView1.Rows[0].Cells[1].Value = "10 - 2";
            dataGridView1.Rows[0].Cells[2].Value = "4 * 2";

            dataGridView1.Rows[1].Cells[0].Value = "15 / 3";
            dataGridView1.Rows[1].Cells[1].Value = "7 + 8";
            dataGridView1.Rows[1].Cells[2].Value = "20 - 5";

            dataGridView1.Rows[2].Cells[0].Value = "6 * 4";
            dataGridView1.Rows[2].Cells[1].Value = "30 / 5";
            dataGridView1.Rows[2].Cells[2].Value = "9 + 6";

            dataGridView1.Rows[3].Cells[0].Value = "12 - 7";
            dataGridView1.Rows[3].Cells[1].Value = "8 * 3";
            dataGridView1.Rows[3].Cells[2].Value = "45 / 9";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string cellValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();

                if (!string.IsNullOrEmpty(cellValue))
                {
                    try
                    {
                        // Вычисляем выражение
                        var result = EvaluateExpression(cellValue);
                        MessageBox.Show($"Выражение: {cellValue}\nРезультат: {result}", "Результат вычисления");
                    }
                    catch
                    {
                        MessageBox.Show("Не удалось вычислить выражение", "Ошибка");
                    }
                }
            }
        }

        // Метод для вычисления арифметических выражений
        private double EvaluateExpression(string expression)
        {
            expression = expression.Replace(" ", "");

            if (expression.Contains("+"))
            {
                var parts = expression.Split('+');
                return double.Parse(parts[0]) + double.Parse(parts[1]);
            }
            else if (expression.Contains("-"))
            {
                var parts = expression.Split('-');
                return double.Parse(parts[0]) - double.Parse(parts[1]);
            }
            else if (expression.Contains("*"))
            {
                var parts = expression.Split('*');
                return double.Parse(parts[0]) * double.Parse(parts[1]);
            }
            else if (expression.Contains("/"))
            {
                var parts = expression.Split('/');
                return double.Parse(parts[0]) / double.Parse(parts[1]);
            }

            return double.Parse(expression);
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
