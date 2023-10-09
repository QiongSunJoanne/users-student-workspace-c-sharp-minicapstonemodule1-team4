using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Capstone
{
    public class VendingMachine
    {
        //private Menu Trans = new Menu();

        public Dictionary<string, Items> Inventory = new Dictionary<string, Items>();

        public decimal Balance { get; set; } = 0.00M;

        public ItemLog log = new ItemLog();
       

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
                    string[] animalStringSplit = lineOfText.Split("|");
                    string animalSlot = animalStringSplit[0];
                    string animalName = animalStringSplit[1];
                    decimal animalPrice = Decimal.Parse(animalStringSplit[2]);
                    string animalType = animalStringSplit[3];

                    if (lineOfText.Contains("Duck"))
                    {                    
                        Ducks duckType = new Ducks(animalName, animalPrice, 5, animalSlot, animalType);
                        Inventory[animalSlot] = duckType;
                    }
                    else if (lineOfText.Contains("Penguin"))
                    {

                        Penguin penguinType = new Penguin(animalName, animalPrice, 5, animalSlot, animalType);
                        Inventory[animalSlot] = penguinType;
                    }
                    else if (lineOfText.Contains("Cat"))
                    {
                        Cats catType = new Cats(animalName, animalPrice, 5, animalSlot, animalType);
                        Inventory[animalSlot] = catType;
                    }
                    else if (lineOfText.Contains("Pony"))
                    {
                        Ponies ponyType = new Ponies(animalName, animalPrice, 5, animalSlot, animalType);
                        Inventory[animalSlot] = ponyType;
                    }
                }
            }
        }

        public void DisplayInventoryAndQuanity()
        {
            foreach(KeyValuePair<string, Items> kvp in Inventory)
            {
                Console.WriteLine($"{Inventory[kvp.Key].Slot} | {Inventory[kvp.Key].ItemName} | {Inventory[kvp.Key].Price} | {Inventory[kvp.Key].AnimalType} | {Inventory[kvp.Key].Quantity}");
            }
        }

        public void MainMenu()
        {
            string firstUserChoice = "";
            do
            {
                Console.WriteLine("Please Select An Option!\n ");
                Console.WriteLine("(1) Display Vending Machine Items");
                Console.WriteLine("(2) Purchase");
                Console.WriteLine("(3) Exit");
                Console.WriteLine("");
                firstUserChoice = Console.ReadLine();
                if (firstUserChoice == "1")
                {
                    Console.Clear();
                    DisplayInventoryAndQuanity();
                    Console.WriteLine("\nPress Enter To Return To The Main Menu!");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if(firstUserChoice == "2")
                {
                    Console.Clear();
                    Purchase();
                    
                }
                else if(firstUserChoice == "3")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid Choice, Please Select Valid Option!\n(Press Enter To Continue)");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            while (firstUserChoice != "3");
        }

        public void Purchase()
        {
            string userChoice = "";
            do
            {
                Console.WriteLine($"Current Money Provided: {Balance}\n ");
                Console.WriteLine("(1) Feed Money");
                Console.WriteLine("(2) Select Product");
                Console.WriteLine("(3) Finish Transaction");
                Console.WriteLine("\nPlease Select An Option: ");
                userChoice = Console.ReadLine();

                if (userChoice == "1")
                {
                    Console.Clear();
                    FeedMoney();
                    
                }
                else if (userChoice == "2")
                {
                    Console.Clear();
                    ItemSelection();
                }
                else if (userChoice == "3")
                {
                    FinishTransaction();
                    return;
                }
            }
            while (userChoice != "3");
        }
        public void ItemSelection()
        {
            Console.WriteLine($"Current Money Provided: {Balance}\n ");
            DisplayInventoryAndQuanity();
            Console.Write("\nPlease Enter Item Number (ex A1): ");           
            string customerChoice = Console.ReadLine();
            customerChoice = customerChoice.ToUpper();

            try
            {
                if (customerChoice.Contains(Inventory[customerChoice].Slot))
                {
                    if (Inventory[customerChoice].Quantity < 1)
                    {
                        Console.WriteLine("Item Is Currently Sold Out, Please Make Another Selection\n(press enter to continue)");
                        Console.ReadLine();
                        Console.Clear();
                        return;
                    }

                    if (Balance > Inventory[customerChoice].Price)
                    {
                        
                        Balance -= Inventory[customerChoice].Price;
                        Inventory[customerChoice].Quantity--;
                        //jordan created log for purchase
                        log.WriteMessage($"{Inventory[customerChoice].ItemName} {Inventory[customerChoice].Slot}", Inventory[customerChoice].Price, Balance); 
                        Console.WriteLine($"{Inventory[customerChoice].Sound}\n(press enter to continue)");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {

                        Console.WriteLine($"Insufficient Funds\nItem Costs: {Inventory[customerChoice].Price}, (press enter to continue)");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
            }
            catch
            {
                Console.WriteLine("Invalid Selection, Please try again!");
                Console.ReadLine();
                Console.Clear();
            }
        }

        public void FeedMoney() ////customer feed money;
        {
            Console.WriteLine($"{Balance}");
            Console.WriteLine("Please input money.");
            decimal totalMoney = decimal.Parse(Console.ReadLine());
            Console.Clear();
            Balance += totalMoney;
            log.WriteMessage($"FEED MONEY:", totalMoney, Balance);                     
        }

        public void FinishTransaction()
        {
            decimal change = Balance;
            decimal wholeDollarAmount = (change * 100);
            int currentBalance = (int)wholeDollarAmount;
            
            int quarters = currentBalance / 25;
            int dimes = (currentBalance % 25) / 10;
            int nickels = ((currentBalance % 25) % 10) / 5;
            Console.WriteLine($"Your Change Is: Quarters: {quarters}, Dimes: {dimes}, and Nickels: {nickels} ");
            Balance = 0;
            log.WriteMessage($"GIVE CHANGE:", change, Balance);
            Console.WriteLine($"Current Money Provided: {Balance}\n(press enter to continue) ");
            Console.ReadLine();
            Console.Clear();
            return;
        }

        public void Run()
        {
            AddAnimalsToVending();
            MainMenu();
        }
    }
}
