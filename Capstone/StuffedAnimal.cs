using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    public class StuffedAnimal 
    {
        public string Name { get; private set; }
        public string Sound { get; set; }
        public string Slot { get; private set; }
        public decimal Price { get; private set; }
        public int Quantity { get; set; } = 5;
        public bool IsPurchased { get; set; }

        public StuffedAnimal(string name, string sound, string slot, decimal price)
        {
            Name = name;
            Sound = sound;
            Slot = slot;
            Price = price;
        }


    }
}
