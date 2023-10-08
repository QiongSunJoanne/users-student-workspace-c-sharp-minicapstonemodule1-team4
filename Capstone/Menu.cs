using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    public class Menu
    {
        public void MenuDisplay()
        {
            VendingMachine vm = new VendingMachine();

            while (true)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1) Display Vending Machine Items");
                Console.WriteLine("2) Purchase");
                Console.WriteLine("3) Exit");

                Console.WriteLine("What option do you want to choose?");
                string dataInput = Console.ReadLine();

                if (dataInput == "1")
                {
                    Console.WriteLine("Items");
                    vm.DisplayAllItems();
                }
                else if(dataInput == "2")
                {
                    Display display = new Display(vm);
                    display.MenuDisplay();
                }
                else if (dataInput.ToUpper ()== "E")
                {
                    Console.WriteLine("Exit");
                    break;
                }
                else
                {
                    Console.WriteLine("Try Again!");
                }
                Console.ReadLine();

            }
        }

        public class Display
        {
            private VendingMachine vm;

            public Display(VendingMachine vm)
            {
                this.vm = vm;
            }

            public void PurchaseDisplay()
            {
                while (true)
                {
                    Console.Clear();
                   
                    Console.WriteLine("(1) Feed Money");
                    Console.WriteLine("(2) Select Product");
                    Console.WriteLine("(3) Finish Transaction");
                    Console.WriteLine("(R) Return to Main Menu");
                    Console.WriteLine("Which option do you want to choose?");
                    string input = Console.ReadLine();

                    if(input == "1")
                    {
                        Console.WriteLine($"Money provided is: {this.vm.Money.ToString()}");
                        break;
                    }
                    else if (input == "2")
                    {
                        while (true)
                        {
                            this.vm.DisplayAllItems();
                            Console.WriteLine("Which item do you want to choose?");
                            string choice = Console.ReadLine();
                        }
                    }
                    else if (input == "3")
                    {
                        Console.WriteLine("Transaction is finished!");
                        Console.WriteLine(this.vm.Money.TakeChange());
                    }
                    else if (input.ToUpper() == "B") 
                    {
                        Console.WriteLine("Back to main menu");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Try Again!");
                    }
                        
                }

            }
        }
    }
}
