using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    public class StuffedAnimals 
    {
        public string Name { get; set; }
        private string sound;
        public virtual string Sound
        {
            get
            {
                if (IsPurchased)
                {
                    return "sound";
                }
                return sound;
            }
            set
            {
                sound = value;
            }
        }

        public decimal Price { get; set; }
        public int Quantity { get; set; } = 5;

        public string Slot { get; set; }

        public bool IsPurchased { get; set; }

        public StuffedAnimals(string sound)
        {
            Sound = sound;
        }

        public StuffedAnimals(string slot, string name, string name1, decimal price, int quantity)
        {
            Slot = slot;
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public StuffedAnimals(string name, int quantity)
        {
            Name = name;
            Quantity = quantity;
        }

    }
}
