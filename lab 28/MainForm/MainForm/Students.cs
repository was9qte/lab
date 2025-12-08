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
    public partial class Students : Form
    {
        private List<Student> students;
        public Students()
        {
            InitializeComponent();
        }

        private void Students_Load(object sender, EventArgs e)
        {
            // Заполнение списка студентов
            students = new List<Student>
            {
                new Student("Иванов Иван Иванович", "Информатика", 1),
                new Student("Петрова Анна Сергеевна", "Математика", 2),
                new Student("Сидоров Алексей Петрович", "Физика", 3),
                new Student("Кузнецова Мария Владимировна", "Химия", 4),
                new Student("Смирнов Дмитрий Олегович", "Биология", 1)
            };
        }
    }
}
