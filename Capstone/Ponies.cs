using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    public class Ponies: Items
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
        public Ponies(string sound, string name, decimal price, int quantity) : base(sound, name, price, quantity)
        {

        }
    }
}
