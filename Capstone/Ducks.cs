using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    public class Ducks : StuffedAnimal
    {
        public string Sound { get; private set; } = "Quack, Quack, Splash!";
        public Ducks(string name, string sound, string slot, decimal price) : base(name, sound, slot, price)
        {

        }

    }
}