using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{
    public class Student
    {
        public string FullName { get; set; }
        public string Specialty { get; set; }
        public int Course { get; set; }

        public Student(string fullName, string specialty, int course)
        {
            FullName = fullName;
            Specialty = specialty;
            Course = course;
        }

        public Student() { }
    }
}
