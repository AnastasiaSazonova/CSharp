using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabric
{
    public abstract class PizzaStore
    {
        public Pizza orderPizza(string type) 
        {
            Pizza pizza;

            pizza = createPizza(type);

            //pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;
        }

        public abstract Pizza createPizza(string type); 
    }
}
