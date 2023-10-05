using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    public class Items 
    {
        public string Name { get; private set; }

        public decimal Price { get; private set; }
        private string sound;

        public virtual string Sound
        {
            get
            {
                if (IsPurchased)
                {
                    return "Play sound";
                }
                return sound;
            }
            set
            {
                sound = value;
            }
        }
        public bool IsPurchased { get; set; }

        public Items(string name, decimal price)
        {
            Name = name;
            Price = price;

        }
        public Items(string sound, string name, decimal price)
        {
            Name = name;
            Price = price;
            Sound = sound;
        }

        








    }
}
