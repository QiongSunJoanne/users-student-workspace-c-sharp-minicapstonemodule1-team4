using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    public class Customer
    {
        public decimal Money { get; private set; }

        public void FeedMoney(string amount)
        {
            decimal amountFeed = 0M;
            string message = $"FEED MONEY: ";

            decimal moneydefault = this.Money;

            this.Money += amountFeed;

            decimal moneyInMachine = this.Money;
        }

        public void MoneyInput()
        {
           
            
            
        }

        public bool TakeMoney(decimal amountTake)
        {
            if(this.Money <= 0)
            {
                return false;
            }
            this.Money -= amountTake;

            return true;
           
        }

        public string TakeChange()
        {
            string afterChange = string.Empty;
            int quarters = 0;
            int dimes = 0;
            int nickels = 0;

            string message = $"PLEASE TAKE CHANGE: ";

            decimal moneydefault = this.Money;
            if(this.Money > 0)
            {
                while(this.Money > 0)
                {
                    if(this.Money >= 0.25M)
                    {
                        quarters++;
                        this.TakeMoney(0.25M);
                    }
                    else if(this.Money >= 0.10M)
                    {
                        dimes++;
                        this.TakeMoney(0.10M);
                    }
                    else if (this.Money >= 0.05M)
                    {
                        nickels++;
                        this.TakeMoney(0.05M);
                    }

                }
                afterChange = GetMessage(quarters, dimes, nickels);

                decimal moneyInMachine = this.Money;

            }
            else
            {
                afterChange = "NO MONEY TO RETURN";
            }
            return afterChange;
            
        }
        private string GetMessage(int quarters, int dimes, int nickels)
        {
            string q = string.Empty;
            String d = string.Empty;
            string n = string.Empty;
            if (quarters > 0)
            {
                q = $"{quarters} quarters";
            }
            if (dimes > 0)
            {
                d = $"{dimes} dimes";
            }
            if (nickels > 0)
            {
                n = $"{nickels} nickels";
            }
            string message = $" YOUR CHANGE IS ";
            if (quarters>0 && dimes>0 && nickels > 0)
            {
                message += $"{q}, {d} and {n}";
            }
            else if ((quarters>0 && dimes>0)||(quarters>0 && nickels > 0))
            {
                message += $"{q} and {d}{n}";
            }
            else if (dimes>0 && nickels > 0)
            {
                message += $"{d} and {n}";
            }
            else if (quarters >0 || dimes>0 || nickels > 0)
            {
                message += $"{q}{d}{n}";
            }
            else
            {
                message = "NO CHANGE TO TAKE.";
            }
            return message;
            
        }
       
    }


}
