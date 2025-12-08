using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class Shop : Form
    {
        public Shop()
        {
            InitializeComponent();
        }

        private void Shop_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Code", "Код");
            dataGridView1.Columns.Add("Name", "Название");
            dataGridView1.Columns.Add("Price", "Цена");
            dataGridView1.Columns.Add(new DataGridViewCheckBoxColumn() { DataPropertyName = "InCart", HeaderText = "В корзину" });
            dataGridView1.Columns["Code"].ValueType = typeof(int);
            dataGridView1.Columns["Name"].ValueType = typeof(string);
            dataGridView1.Columns["Price"].ValueType = typeof(decimal);
            dataGridView1.Columns["InCart"].ValueType = typeof(bool);

            // Настройка формата цены
            dataGridView1.Columns["Price"].DefaultCellStyle.Format = "C2";
            dataGridView1.Columns["Price"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleRight;

            // Скрытие столбца с кодом
            dataGridView1.Columns["Code"].Visible = false;

            // Настройка чередования цветов строк
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor =
                System.Drawing.Color.LightGray;

            // Заполнение данными
            string[] products = {
                "Ноутбук", "Мышь компьютерная", "Клавиатура", "Монитор",
                "Наушники", "Веб-камера", "Флеш-накопитель", "Принтер",
                "Сканер", "Колонки"
            };

            decimal[] prices = {
                45000, 1200, 2500, 15000, 3500, 2000, 800, 9000, 7000, 4000
            };

            for (int i = 0; i < 10; i++)
            {
                dataGridView1.Rows.Add(i + 1, products[i], prices[i], false);
            }

            // Настройка ширины столбцов
            dataGridView1.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["Price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns["InCart"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
           
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            StringBuilder orderSummary = new StringBuilder();
            decimal total = 0;
            bool hasItems = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["InCart"].Value != null &&
                    (bool)row.Cells["InCart"].Value)
                {
                    string productName = row.Cells["Name"].Value?.ToString() ?? "";
                    decimal price = Convert.ToDecimal(row.Cells["Price"].Value);

                    orderSummary.AppendLine($"{productName} - {price:C2}");
                    total += price;
                    hasItems = true;
                }
            }

            if (hasItems)
            {
                orderSummary.AppendLine($"\nОбщая стоимость: {total:C2}");
                TotalLabel.Text = orderSummary.ToString();
            }
            else
            {
                MessageBox.Show("Пожалуйста, отметьте товары для заказа.", "Внимание",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TotalLabel.Text = "Итог";
            }
        }
    }
}
