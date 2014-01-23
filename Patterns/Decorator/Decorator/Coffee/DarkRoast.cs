using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class DarkRoast : Beverage
    {
        public DarkRoast() 
        {
            description = "Dark Roast Coffee.";
        }

        public override double cost() 
        {
            return 1.00;
        }
    }
}
