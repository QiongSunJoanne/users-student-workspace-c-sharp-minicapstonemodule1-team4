using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    public class Cats : Items
    {
       
        public const string Sound = "Meow, Meow, Meow!";
       
      
        
        public Cats(string itemName, decimal price, int quantity) : base(itemName, price, quantity, Sound )
        {

        }

       

    }
}
