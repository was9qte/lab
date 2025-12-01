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
    public partial class ComboBox : Form
    {
        public ComboBox()
        {
            InitializeComponent();
            this.Text = "Заказ билета";
            this.StartPosition = FormStartPosition.CenterParent;

        }
        private void OrderButton_Click(object sender, EventArgs e)
        {
            if (DestinationComboBox.SelectedIndex != -1)
            {
                string destination = DestinationComboBox.Text;
                MessageBox.Show(
                    $"Билет: Архангельск — {destination}",
                    "Заказ оформлен",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    "Пожалуйста, выберите пункт назначения!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }
    }
}
