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
    public partial class Column : Form
    {
        public Column()
        {
            InitializeComponent();
        }
        private void FormTask1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                DataGridView.Columns.Add($"col{i}", i.ToString());
            }
            for (int row = 1; row <= 10; row++)
            {
                DataGridView.Rows.Add();
                DataGridView.Rows[row - 1].HeaderCell.Value = row.ToString();

                for (int col = 1; col <= 10; col++)
                {
                    DataGridView.Rows[row - 1].Cells[col - 1].Value = (row * col).ToString();
                }
            }
            DataGridView.Columns[0].HeaderText = "Первый множитель";
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int row = e.RowIndex + 1;
                int col = e.ColumnIndex + 1;
                int result = row * col;

                MessageBox.Show($"{row} × {col} = {result}", "Результат умножения");
            }
        }
    }
    
    
}
