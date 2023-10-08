using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Capstone
{
    public class Ponies : Items
    {
        public const string Sound = "Neigh, Neigh, Yay!";
        public Ponies(string itemName, decimal price, int quantity) : base(itemName, price, quantity, Sound)
        {

        }
    }
}
