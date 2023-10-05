using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    public class Cats: Items
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
        public Cats(string sound, string name, decimal price, int quantity) : base(sound,name, price, quantity)
        {
            
        }

    






    }
}
