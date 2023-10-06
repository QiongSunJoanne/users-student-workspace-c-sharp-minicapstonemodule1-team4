using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    public class Ducks : StuffedAnimals
    {
        public override string Sound
        {
            get
            {
                if (IsPurchased)
                {
                    return "Quack, Quack, Splash!";
                }
                return Sound;
            }
        }
        public Ducks(string sound, string slot, string name, decimal price, int quantity) : base(sound, slot, name, price, quantity)
        {

            Slot = slot;
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public Ducks() : base("Quack, Quack, Splash!")
        {

        }

    }
}