using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    public class Ducks : Items
    {
        //commented out by Jordan
        //public const string Sound = "Quack, Quack, Splash!";

        public Ducks(string itemName, decimal price, int quantity, string slot, string animalType) : base(itemName, price, quantity, "Quack, Quack, Splash!", slot, animalType)
        {

        }


    }
}