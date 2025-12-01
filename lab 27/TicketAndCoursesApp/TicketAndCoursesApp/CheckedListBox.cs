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
    public partial class CheckedListBox : Form
    {
        public CheckedListBox()
        {
            InitializeComponent();
            this.Text = "Запись на курсы";
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void EnrollButton_Click(object sender, EventArgs e)
        {
            var selectedCourses = new List<string>();

            for (int i = 0; i < CoursesCheckedListBox.CheckedItems.Count; i++)
            {
                selectedCourses.Add(CoursesCheckedListBox.CheckedItems[i].ToString());
            }

            if (selectedCourses.Count > 0)
            {
                string message = "Вы выбрали следующие курсы:\n" +
                               string.Join("\n", selectedCourses.Select(c => $"- {c};"));
                MessageBox.Show(message, "Запись подтверждена", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    "Необходимо выбрать хотя бы один курс!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }
    }
}
