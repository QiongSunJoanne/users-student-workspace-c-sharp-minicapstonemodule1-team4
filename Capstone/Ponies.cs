using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Capstone
{
    public class Ponies : StuffedAnimals
    {
        public override string Sound
        {
            get
            {
                if (IsPurchased)
                {
                    return "Neigh, Neigh, Yay!";
                }
                return Sound;
            }
        }
        public Ponies(string sound, string slot, string name, decimal price, int quantity) : base(sound, slot, name, price, quantity)
        {

            Slot = slot;
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public Ponies() : base("Neigh, Neigh, Yay!")
        {

        }
    }
}
