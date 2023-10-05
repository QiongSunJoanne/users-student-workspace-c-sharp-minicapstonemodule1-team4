using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    public class Ducks : Items
    {
        public override string Sound
        {
            get
            {
                if (IsPurchased)
                {
                    return "Quack, Quack, Splash!";
                }
                return Sound;
            }
        }
        public Ducks() : base("Yellow Duck", 2M)
        {

        }
    }
}