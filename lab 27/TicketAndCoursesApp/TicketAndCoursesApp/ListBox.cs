using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketAndCoursesApp
{
    public partial class ListBox : Form
    {
        public ListBox()
        {
            InitializeComponent();
            this.Text = "Работа со списками";
            this.StartPosition = FormStartPosition.CenterParent;

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string text = InputTextBox.Text.Trim();
            if (!string.IsNullOrEmpty(text))
            {
                ListBox1.Items.Add(text);
                InputTextBox.Clear();
            }
            else
            {
                MessageBox.Show(
                    "Введите значение!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void MoveSelectedButton_Click(object sender, EventArgs e)
        {
            while (ListBox1.SelectedItems.Count > 0)
            {
                var item = ListBox1.SelectedItems[0];
                ListBox1.Items.Remove(item);
                ListBox2.Items.Add(item);
            }
        }

        private void MoveAllButton_Click(object sender, EventArgs e)
        {
            foreach (var item in ListBox1.Items)
            {
                ListBox2.Items.Add(item);
            }
            ListBox1.Items.Clear();
        }
    }
}
