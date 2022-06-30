using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainTest
{
    class Train
    {
        private int number;
        private string name;
        private string type;
        private int cars;

        public Train(int number, string name, string type, int cars)
        {
            this.number = number;
            this.name = name;
            Type = type;
            Cars = cars;
        }

        public override string ToString()
        {
            return $"{number} {name} {Type} {Cars}";
        }

        public string Type { get; set; }

        public int Cars { get; set; }
    }
}
