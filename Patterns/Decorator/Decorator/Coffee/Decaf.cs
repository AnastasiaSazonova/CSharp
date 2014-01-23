using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Decaf : Beverage
    {
        public Decaf() 
        {
            description = "Decaf Coffee";
        }

        public override double cost() 
        {
            return 2.99;
        }
    }
}
