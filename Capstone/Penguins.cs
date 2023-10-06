using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Capstone
{
    public class Penguin : StuffedAnimal
    {
        public string Sound { get; private set; } = "Squawk, Squawk, Whee!";
        public Penguin(string name, string sound, string slot, decimal price) : base(name, sound, slot, price)
        {

        }
    }
}
