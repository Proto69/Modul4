using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class School
    {
        private string name;
        private List<Student> students = new List<Student>();

        public School(string name)
        {
        }

        public string Name
        {
            get { return name; }
        }

        public List<Student> Students
        {
            get { return students; }
        }

        public void AddStudent(string name, double grade)
        {
            students.Add(new Student(name, grade));
        }

        public double AverageResultInRange(int start, int end)
        {
            double avrg = 0;
            int count = 0;
            for (int i = start; i <= end; i++)
            {
                avrg += students[i].Grades.Average();
                count++;
            }
            avrg /= count;
            return avrg;
        }


        public List<string> RemoveStudentsByGrade(double grade)
        {
            //предполагам че е включително оценката
            List<Student> students2 = students.Where(x => x.Grades.Average() < grade).ToList();
            students = students.Where(x => x.Grades.Average() => grade).ToList();
            List<string> result = new List<string>();
            foreach (var item in students2)
            {
                result.Add(item.Name);
            }
            return result;
        }

        public List<Student> SortAscendingByName()
        {
            students = students.OrderBy(x => x.Name).ToList();
            return students;
        }

        public List<Student> SortDescendingByGrade()
        {
            students = students.OrderByDescending(x => x.Grades.Average()).ToList();
            return students;
        }

        public bool CheckStudentIsInSchool(string name)
        {
            foreach (var item in students)
            {
                if (item.Name == name) return true;
            }
            return false;
        }

        public string[] ProvideInformationAboutAllStudents()
        {
            string[] arr = new string[students.Count];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = students[i].ToString();
            }
            return arr;
        }

    }
}
