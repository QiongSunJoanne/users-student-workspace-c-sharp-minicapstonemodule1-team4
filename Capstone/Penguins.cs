using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    public class Penguin : Items
    {
        public override string Sound
        {
            get
            {
                if (IsPurchased)
                {
                    return "Squawk, Squawk, Whee!";
                }
                return Sound;
            }
        }
        public Penguin(string sound, string name, decimal price, int quantity) : base(sound, name, price, quantity)
        {

        }
    }
}
