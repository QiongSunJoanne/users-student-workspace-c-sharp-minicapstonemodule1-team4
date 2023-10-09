using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;

namespace Capstone
{
    public class Program
    {
        public static void Main(string[] args)
        {

            VendingMachine vm = new VendingMachine();
            vm.Run();

        }
    }
}
