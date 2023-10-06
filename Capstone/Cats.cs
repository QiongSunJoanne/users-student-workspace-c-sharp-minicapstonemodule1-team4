using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    public class Cats : StuffedAnimal
    {
        public string Sound { get; private set; } = "Meow, Meow, Meow!";
        public Cats(string name, string sound, string slot, decimal price) : base(name, sound, slot, price)
        {

        }

    }
}
