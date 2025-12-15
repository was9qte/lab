using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab28
{
    using System;
    using System.Windows.Forms;
    public partial class DataGridForm2 : Form
    {
        public DataGridForm2()
        {
            InitializeComponent();
            SetupDataGridView();
            FillDataGrid();
        }

        private void SetupDataGridView()
        {
            // Запретить добавление, правку и удаление
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ReadOnly = true;

            // Белый фон
            dataGridView2.BackgroundColor = System.Drawing.Color.White;

            // Автоматическое заполнение ширины столбцов
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FillDataGrid()
        {
            // Очищаем существующие столбцы и строки
            dataGridView2.Columns.Clear();
            dataGridView2.Rows.Clear();

            // Добавляем 4 столбца с заголовками
            string[] columnHeaders = { "Выражение", "Квадратный корень", "Процент", "Степень" };
            for (int i = 0; i < columnHeaders.Length; i++)
            {
                dataGridView2.Columns.Add($"col{i}", columnHeaders[i]);
                dataGridView2.Columns[i].HeaderText = columnHeaders[i];
            }

            // Добавляем 5 строк с заголовками
            string[] rowHeaders = { "Тест 1", "Тест 2", "Тест 3", "Тест 4", "Тест 5" };
            for (int i = 0; i < rowHeaders.Length; i++)
            {
                dataGridView2.Rows.Add();
                dataGridView2.Rows[i].HeaderCell.Value = rowHeaders[i];
            }

            // Заполняем ячейки данными
            dataGridView2.Rows[0].Cells[0].Value = "2^3";
            dataGridView2.Rows[0].Cells[1].Value = "√16";
            dataGridView2.Rows[0].Cells[2].Value = "10% от 200";
            dataGridView2.Rows[0].Cells[3].Value = "5!";

            dataGridView2.Rows[1].Cells[0].Value = "3^2";
            dataGridView2.Rows[1].Cells[1].Value = "√25";
            dataGridView2.Rows[1].Cells[2].Value = "15% от 300";
            dataGridView2.Rows[1].Cells[3].Value = "4!";

            dataGridView2.Rows[2].Cells[0].Value = "4^2";
            dataGridView2.Rows[2].Cells[1].Value = "√36";
            dataGridView2.Rows[2].Cells[2].Value = "20% от 400";
            dataGridView2.Rows[2].Cells[3].Value = "3!";

            dataGridView2.Rows[3].Cells[0].Value = "5^2";
            dataGridView2.Rows[3].Cells[1].Value = "√49";
            dataGridView2.Rows[3].Cells[2].Value = "25% от 500";
            dataGridView2.Rows[3].Cells[3].Value = "2!";

            dataGridView2.Rows[4].Cells[0].Value = "6^2";
            dataGridView2.Rows[4].Cells[1].Value = "√64";
            dataGridView2.Rows[4].Cells[2].Value = "30% от 600";
            dataGridView2.Rows[4].Cells[3].Value = "1!";
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string cellValue = dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString();

            if (string.IsNullOrEmpty(cellValue))
            {
                MessageBox.Show("Ячейка пуста", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                double result = CalculateExpression(cellValue);
                string message = $"Выражение: {cellValue}\n" +
                              $"Результат: {result}";
                MessageBox.Show(message, "Вычисление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка вычисления: {ex.Message}", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double CalculateExpression(string expression)
        {
            expression = expression.Trim();

            // Обработка степени (x^y)
            if (expression.Contains("^"))
            {
                var parts = expression.Split('^');
                double baseNum = double.Parse(parts[0]);
                double exponent = double.Parse(parts[1]);
                return Math.Pow(baseNum, exponent);
            }

            // Обработка квадратного корня (√x)
            else if (expression.StartsWith("√"))
            {
                double number = double.Parse(expression.Substring(1));
                if (number < 0) throw new ArgumentException("Корень из отрицательного числа");
                return Math.Sqrt(number);
            }

            // Обработка процентов (x% от y)
            else if (expression.Contains("% от"))
            {
                var parts = expression.Split(new string[] { "% от" }, StringSplitOptions.None);
                double percent = double.Parse(parts[0]);
                double total = double.Parse(parts[1]);
                return (percent / 100) * total;
            }

            // Если выражение не распознано — пытаемся просто преобразовать в число
            else
            {
                return double.Parse(expression);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
