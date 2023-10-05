using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    public class Vending_Machine 
    {


        Cats cat = new Cats("Meow, Meow, Meow", "Black Cat", 2.5M, 5);
        Ducks duck = new Ducks();
        Ponies pony = new Ponies();
        Penguin penguin = new Penguin();

        //public int Rows { get; private set; }
        //public List <Items> Display { get; set; }
        List<Items> items = new List<Items>() {  };

         
        

        //public Vending_Machine(int rows, List <Items> display)
        //{
        //    Rows = rows;
        //    Display = display;
        //}

        public void DisplayItemsAndQuanity()
        {
            Console.WriteLine();
        }

        public void ReturnMainMenu()
        {

        }
        public void DisplayItemsCost()
        {

        }
        public void RefillRow()
        {

        }



    }
}
