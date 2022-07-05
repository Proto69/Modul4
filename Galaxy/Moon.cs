using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Moon
    {
        private string name;

        public Moon(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return $"                      {name}";
        }

        public string Name { get => name; set => name = value; }
    }
}
