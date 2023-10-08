using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    public class Ducks : Items
    {
        public const string Sound = "Quack, Quack, Splash!";

        public Ducks(string itemName, decimal price, int quantity) : base(itemName, price, quantity, Sound)
        {

        }


    }
}