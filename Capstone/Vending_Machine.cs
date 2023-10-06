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

        Dictionary<string, StuffedAnimal> Inventory = new Dictionary<string, StuffedAnimal>();
        
        public void AddAnimalsToVending()
        {
            string directory = Environment.CurrentDirectory;
            string fileName = "../../../../vendingmachine.csv";
            string fullPath = Path.Combine(directory, fileName);

            using (StreamReader sr = new StreamReader(fullPath))
            {
                while (!sr.EndOfStream)
                {
                    string lineOfText = sr.ReadLine();
                    if (lineOfText.Contains("A1"))
                    {                       
                        string[] duckStringSplit = lineOfText.Split("|");
                        decimal duckPrice = Decimal.Parse(duckStringSplit[2]);
                        Ducks duckType = new Ducks(duckStringSplit[1], "Quack, Quack, Splash!", duckStringSplit[0], duckPrice);
                        Inventory["A1"] = duckType;
                    }
                    else if (lineOfText.Contains("A2"))
                    {
                        string[] duckStringSplit = lineOfText.Split("|");
                        decimal duckPrice = Decimal.Parse(duckStringSplit[2]);
                        Ducks duckType = new Ducks(duckStringSplit[1], "Quack, Quack, Splash!", duckStringSplit[0], duckPrice);
                        Inventory["A2"] = duckType;
                    }
                    else if (lineOfText.Contains("A3"))
                    {
                        string[] duckStringSplit = lineOfText.Split("|");
                        decimal duckPrice = Decimal.Parse(duckStringSplit[2]);
                        Ducks duckType = new Ducks(duckStringSplit[1], "Quack, Quack, Splash!", duckStringSplit[0], duckPrice);
                        Inventory["A3"] = duckType;
                    }
                    else if (lineOfText.Contains("A4"))
                    {
                        string[] duckStringSplit = lineOfText.Split("|");
                        decimal duckPrice = Decimal.Parse(duckStringSplit[2]);
                        Ducks duckType = new Ducks(duckStringSplit[1], "Quack, Quack, Splash!", duckStringSplit[0], duckPrice);
                        Inventory["A4"] = duckType;
                    }
                    else if (lineOfText.Contains("B1"))
                    {
                        string[] penStringSplit = lineOfText.Split("|");
                        decimal penguinPrice = Decimal.Parse(penStringSplit[2]);
                        Penguin penguinType = new Penguin(penStringSplit[1], "Squawk, Squawk, Whee!", penStringSplit[0], penguinPrice);
                        Inventory["B1"] = penguinType;
                    }
                    else if (lineOfText.Contains("B2"))
                    {
                        string[] penStringSplit = lineOfText.Split("|");
                        decimal penguinPrice = Decimal.Parse(penStringSplit[2]);
                        Penguin penguinType = new Penguin(penStringSplit[1], "Squawk, Squawk, Whee!", penStringSplit[0], penguinPrice);
                        Inventory["B2"] = penguinType;
                    }
                    else if (lineOfText.Contains("B3"))
                    {
                        string[] penStringSplit = lineOfText.Split("|");
                        decimal penguinPrice = Decimal.Parse(penStringSplit[2]);
                        Penguin penguinType = new Penguin(penStringSplit[1], "Squawk, Squawk, Whee!", penStringSplit[0], penguinPrice);
                        Inventory["B3"] = penguinType;
                    }
                    else if (lineOfText.Contains("B4"))
                    {
                        string[] penStringSplit = lineOfText.Split("|");
                        decimal penguinPrice = Decimal.Parse(penStringSplit[2]);
                        Penguin penguinType = new Penguin(penStringSplit[1], "Squawk, Squawk, Whee!", penStringSplit[0], penguinPrice);
                        Inventory["B4"] = penguinType;
                    }
                    else if (lineOfText.Contains("C1"))
                    {
                        string[] catStringSplit = lineOfText.Split("|");
                        decimal catPrice = Decimal.Parse(catStringSplit[2]);
                        Cats catType = new Cats(catStringSplit[1], "Meow, Meow, Meow!", catStringSplit[0], catPrice);
                        Inventory["C1"] = catType;
                    }
                    else if (lineOfText.Contains("C2"))
                    {
                        string[] catStringSplit = lineOfText.Split("|");
                        decimal catPrice = Decimal.Parse(catStringSplit[2]);
                        Cats catType = new Cats(catStringSplit[1], "Meow, Meow, Meow!", catStringSplit[0], catPrice);
                        Inventory["C2"] = catType;
                    }
                    else if (lineOfText.Contains("C3"))
                    {
                        string[] catStringSplit = lineOfText.Split("|");
                        decimal catPrice = Decimal.Parse(catStringSplit[2]);
                        Cats catType = new Cats(catStringSplit[1], "Meow, Meow, Meow!", catStringSplit[0], catPrice);
                        Inventory["C3"] = catType;
                    }
                    else if (lineOfText.Contains("C4"))
                    {
                        string[] catStringSplit = lineOfText.Split("|");
                        decimal catPrice = Decimal.Parse(catStringSplit[2]);
                        Cats catType = new Cats(catStringSplit[1], "Meow, Meow, Meow!", catStringSplit[0], catPrice);
                        Inventory["C4"] = catType;
                    }
                    else if (lineOfText.Contains("D1"))
                    {
                        string[] poniesStringSplit = lineOfText.Split("|");
                        decimal ponyPrice = Decimal.Parse(poniesStringSplit[2]);
                        Ponies ponyType = new Ponies(poniesStringSplit[1], "Neigh, Neigh, Yay!", poniesStringSplit[0], ponyPrice);
                        Inventory["D1"] = ponyType;
                    }
                    else if (lineOfText.Contains("D2"))
                    {
                        string[] poniesStringSplit = lineOfText.Split("|");
                        decimal ponyPrice = Decimal.Parse(poniesStringSplit[2]);
                        Ponies ponyType = new Ponies(poniesStringSplit[1], "Neigh, Neigh, Yay!", poniesStringSplit[0], ponyPrice);
                        Inventory["D2"] = ponyType;
                    }
                    else if (lineOfText.Contains("D3"))
                    {
                        string[] poniesStringSplit = lineOfText.Split("|");
                        decimal ponyPrice = Decimal.Parse(poniesStringSplit[2]);
                        Ponies ponyType = new Ponies(poniesStringSplit[1], "Neigh, Neigh, Yay!", poniesStringSplit[0], ponyPrice);
                        Inventory["D3"] = ponyType;
                    }
                    else if (lineOfText.Contains("D4"))
                    {
                        string[] poniesStringSplit = lineOfText.Split("|");
                        decimal ponyPrice = Decimal.Parse(poniesStringSplit[2]);
                        Ponies ponyType = new Ponies(poniesStringSplit[1], "Neigh, Neigh, Yay!", poniesStringSplit[0], ponyPrice);
                        Inventory["D4"] = ponyType;
                    }
                }
            }
  
            


        }
        public void DisplayInventoryAndQuanity()
        {
            customerBalance();
            Console.WriteLine("");
            AddAnimalsToVending();
            Console.WriteLine("Current Inventory\n ");
            Console.WriteLine($"{Inventory["A1"].Slot} | {Inventory["A1"].Name} | {Inventory["A1"].Price} | Duck | {Inventory["A1"].Quantity}");
            Console.WriteLine($"{Inventory["A2"].Slot} | {Inventory["A2"].Name} | {Inventory["A2"].Price} | Duck | {Inventory["A2"].Quantity}");
            Console.WriteLine($"{Inventory["A3"].Slot} | {Inventory["A3"].Name} | {Inventory["A3"].Price} | Duck | {Inventory["A3"].Quantity}");
            Console.WriteLine($"{Inventory["A4"].Slot} | {Inventory["A4"].Name} | {Inventory["A4"].Price} | Duck | {Inventory["A4"].Quantity}");
            Console.WriteLine($"{Inventory["B1"].Slot} | {Inventory["B1"].Name} | {Inventory["B1"].Price} | Penguin | {Inventory["B1"].Quantity}");
            Console.WriteLine($"{Inventory["B2"].Slot} | {Inventory["B2"].Name} | {Inventory["B2"].Price} | Penguin | {Inventory["B2"].Quantity}");
            Console.WriteLine($"{Inventory["B3"].Slot} | {Inventory["B3"].Name} | {Inventory["B3"].Price} | Penguin | {Inventory["B3"].Quantity}");
            Console.WriteLine($"{Inventory["B4"].Slot} | {Inventory["B4"].Name} | {Inventory["B4"].Price} | Penguin | {Inventory["B4"].Quantity}");
            Console.WriteLine($"{Inventory["C1"].Slot} | {Inventory["C1"].Name} | {Inventory["C1"].Price} | Cat | {Inventory["C1"].Quantity}");
            Console.WriteLine($"{Inventory["C2"].Slot} | {Inventory["C2"].Name} | {Inventory["C2"].Price} | Cat | {Inventory["C2"].Quantity}");
            Console.WriteLine($"{Inventory["C3"].Slot} | {Inventory["C3"].Name} | {Inventory["C3"].Price} | Cat | {Inventory["C3"].Quantity}");
            Console.WriteLine($"{Inventory["C4"].Slot} | {Inventory["C4"].Name} | {Inventory["C4"].Price} | Cat | {Inventory["C4"].Quantity}");
            Console.WriteLine($"{Inventory["D1"].Slot} | {Inventory["D1"].Name} | {Inventory["D1"].Price} | Pony | {Inventory["D1"].Quantity}");
            Console.WriteLine($"{Inventory["D2"].Slot} | {Inventory["D2"].Name} | {Inventory["D2"].Price} | Pony | {Inventory["D2"].Quantity}");
            Console.WriteLine($"{Inventory["D3"].Slot} | {Inventory["D3"].Name} | {Inventory["D3"].Price} | Pony | {Inventory["D3"].Quantity}");
            Console.WriteLine($"{Inventory["D4"].Slot} | {Inventory["D4"].Name} | {Inventory["D4"].Price} | Pony | {Inventory["D4"].Quantity}");
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

        public void FeedMoney() ////customer feed money;
        {
            Console.WriteLine("Please input money.");

            decimal totalMoney = decimal.Parse(Console.ReadLine());

            Balance += totalMoney;

        }
        public void customerBalance()
        {
            Console.WriteLine($"{Balance}");
        }
        
           
        



        public decimal TakeChangeReturned(decimal change)
        {
            Console.WriteLine("Your change is: ");

            return change;
        }

    }
}
