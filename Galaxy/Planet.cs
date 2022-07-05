using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Planet
    {
        private string name;
        private string type;
        private string life;
        private List<Moon> moons = new List<Moon>();

        public Planet(string name, string type, string life)
        {
            this.name = name;
            this.type = type;
            this.life = life;
        }

        public override string ToString()
        {
            string a = "";
            foreach (var moon in moons)
            {
                a += "\n" + moon.ToString();
            }
            return $"            o  Name: {name} \n               Type: {type} \n               Support life: {life} \n               Moons: {a}";
        }

        public List<Moon> Moons { get => moons; set => moons = value; }
    }
}
