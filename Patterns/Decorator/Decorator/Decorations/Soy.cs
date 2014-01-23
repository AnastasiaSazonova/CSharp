using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Soy : CondimentDecorator
    {
        Beverage beverage;

        public Soy(Beverage beverage) 
        {
            this.beverage = beverage;
        }

        public override string getDescription() 
        {
            return beverage.getDescription() + ", Soy";
        }

        public override double cost()
        {
            return beverage.cost() + 0.99;
        }
    }
}
