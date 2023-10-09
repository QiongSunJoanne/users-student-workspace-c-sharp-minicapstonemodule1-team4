using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Capstone
{
    public class Penguin : Items
    {
        //public const string Sound = "Squawk, Squawk, Whee!";
        public Penguin(string itemName, decimal price, int quantity, string slot, string animalType) : base(itemName, price, quantity, "Squawk, Squawk, Whee!", slot, animalType)
        {

        }
    }
}
