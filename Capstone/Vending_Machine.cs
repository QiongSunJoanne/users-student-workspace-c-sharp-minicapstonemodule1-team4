using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    public class Vending_Machine 
    {

        public decimal Balance { get; set; } = 0.00M;
        //Cats cat = new Cats("Meow, Meow, Meow", "Black Cat", 2.5M, 5);
        //Ducks duck = new Ducks();
        //Ponies pony = new Ponies();
        //Penguin penguin = new Penguin();

        ////public int Rows { get; private set; }
        ////public List <Items> Display { get; set; }
        //List<Items> items = new List<Items>() {  };

         
        

        ////public Vending_Machine(int rows, List <Items> display)
        ////{
        ////    Rows = rows;
        ////    Display = display;
        ////}
        public void AddAnimalsToVending()
        {
            string directory = Environment.CurrentDirectory;
            string fileName = "vendingmachine.csv";
            string fullPath = Path.Combine(directory, fileName);
            int lineNumber = 1;

            using (StreamReader sr = new StreamReader(fullPath))
            {
                while (!sr.EndOfStream)
                {
                    string lineOfText = sr.ReadLine();
                    if (lineOfText.Contains("C1"))
                    {

                        Dictionary<string, Cats> Vending = new Dictionary<string, Cats>();

                    }
                   
                }
            }
  



    }
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
