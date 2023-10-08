﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Capstone
{
    public class Penguin : Items
    {
        public const string Sound = "Squawk, Squawk, Whee!";
        public Penguin(string itemName, decimal price, int quantity) : base(itemName, price, quantity, Sound)
        {

        }
    }
}
