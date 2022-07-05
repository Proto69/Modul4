using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Galaxy
    {
        private string name;
        private string type;
        private string age;
        private List<Star> stars = new List<Star>();

        public Galaxy(string name, string type, string age)
        {
            this.name = name;
            this.type = type;
            this.age = age;
        }

        public override string ToString()
        {
            string a = "";
            foreach (var star in stars)
            {
                a += "\n" + star.ToString();
            }
            return $"Type: {type} \nAge: {age} \nStars: {a}";
        }

        public List<Star> Stars { get => stars; set => stars = value; }
    }
}
