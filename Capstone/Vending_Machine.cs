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
        public int Rows { get; private set; }
        public List <Items> Display { get; set; }
        

        public Vending_Machine(int rows, List <Items> display)
        {
            Rows = rows;
            Display = display;
        }

        public void string DisplayItemsAndQuanity(List<Items>)
        {
            Console.WriteLine($"(1) {Cats} quantity {}");
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
