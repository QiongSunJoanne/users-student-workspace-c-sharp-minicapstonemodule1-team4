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
        //commented out by jordan
        //public const string Sound = "Neigh, Neigh, Yay!";
        public Ponies(string itemName, decimal price, int quantity, string slot, string animalType) : base(itemName, price, quantity, "Neigh, Neigh, Yay!", slot, animalType)
        {

        }
    }
}
