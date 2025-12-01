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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Text = "Главное меню";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void ComboBoxButton_Click(object sender, EventArgs e)
        {
            var comboForm = new ComboBox();
            comboForm.ShowDialog();
        }

        private void CheckedListBoxButton_Click(object sender, EventArgs e)
        {
            var coursesForm = new CheckedListBox();
            coursesForm.ShowDialog();
        }

        private void ListBoxButton_Click(object sender, EventArgs e)
        {
            var listBoxForm = new ListBox();
            listBoxForm.ShowDialog();
        }
    }
}
