using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Student
    {
        private string name;
        private List<double> grades = new List<double>();

        public Student(string name, double grade)
        {
            Name = name;
            Grades.Add(grade);
        }

        public override string ToString()
        {
            return $"Student {name} has {grades.Average():F2}.";
        }

        public string Name { get => name; set => name = value; }
        public List<double> Grades { get => grades; set => grades = value; }
    }
}
