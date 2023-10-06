using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    public class Cats : StuffedAnimals
    {
        public override string Sound
        {
            get
            {
                if (IsPurchased)
                {
                    return "Meow, Meow, Meow!";
                }
                return Sound;
            }
        }
        public Cats(string sound, string slot, string name, decimal price, int quantity) : base(sound,slot,name,price,quantity)
        {

            Slot = slot;
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public Cats():base("Meow, Meow, Meow!")
        {

        }

    }
}
