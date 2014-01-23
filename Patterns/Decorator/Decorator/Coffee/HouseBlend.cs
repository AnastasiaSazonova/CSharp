using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class HouseBlend : Beverage
    {
        public HouseBlend() 
        {
            description = "House Blend Coffee.";
        }

        public override double cost() 
        {
            return 0.89;
        }
    }
}
