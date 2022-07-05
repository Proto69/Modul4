using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Star
    {
        private string name;
        private string clas;
        private double mass;
        private double size;
        private int temp;
        private double luminosity;
        private List<Planet> planets = new List<Planet>();

        public Star(string name, double size, double mass, int temp, double luminosity)
        {
            this.name = name;
            this.mass = mass;
            this.size = size;
            this.temp = temp;
            this.luminosity = luminosity;
            if (temp >= 30000 && luminosity >= 30000 && mass >= 16 && size >= 6.6)
            {
                clas = "O";
            }
            else if (temp > 10000 && temp < 30000 && luminosity < 30000 && luminosity > 25 && mass < 16 && mass > 2.1 && size < 6.6 && size > 2)
            {
                clas = "B";
            }
            else if (temp > 7500 && temp < 10000 && luminosity < 25 && luminosity > 5 && mass < 2.1 && mass > 1.4 && size < 2 && size > 1.4)
            {
                clas = "A";
            }
            else if (temp > 6000 && temp < 7500 && luminosity < 5 && luminosity > 1.5 && mass < 1.4 && mass > 1.04 && size < 1.4 && size > 1.15)
            {
                clas = "F";
            }
            else if (temp > 5200 && temp < 6000 && luminosity < 1.5 && luminosity > 0.6 && mass < 1.04 && mass > 0.8 && size < 1.15 && size > 0.96)
            {
                clas = "G";
            }
            else if (temp > 3700 && temp < 5200 && luminosity < 0.6 && luminosity > 0.08 && mass < 0.8 && mass > 0.45 && size < 0.96 && size > 0.7)
            {
                clas = "F";
            }
            else if (temp > 2400 && temp < 3700 && luminosity <= 0.08 && mass < 0.45 && mass > 0.08 && size <= 0.7)
            {
                clas = "M";
            }
            else
            {
                clas = "Unknown";
            }
        }

        public override string ToString()
        {
            string a = "";
            foreach (var planet in planets)
            {
                a += "\n" + planet.ToString();
            }
            return $"    -  Name: {name} \n       Class: {clas} ({mass}, {size}, {temp}, {luminosity}) \n       Planets: {a}";
        }

        public List<Planet> Planets { get => planets; set => planets = value; }
    }
}
