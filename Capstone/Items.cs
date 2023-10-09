using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    public abstract class Items
    {
        public string ItemName { get; set; }
        public string Sound { get; set; }
        public string Slot { get; private set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; } = 5;

        public string AnimalType { get; private set; }
        //Jordans Question - why was this commented out?
        //public bool IsPurchased { get; set; }
        //public string SoldOut { get; set; }


        public Items()
        {

        }
        
        
        public Items (string itemName, decimal price, int quantity, string sound, string slot, string animalType)
        {
            ItemName = itemName;
            Price = price;
            Quantity = quantity;
            Sound = sound;
            Slot = slot;
            AnimalType = animalType;
            //Jordan's Comment - what is this for?
            //SoldOut = $"{ItemName} Is Sold out !\nMake another choise!";
        }

        
    }
}
