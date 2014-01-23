using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(string type) 
        {
            Pizza pizza = null;

            if (type == "cheese")
            {
                pizza = new CheesePizza();
            }
            else if(type == "vegie")
            {
                pizza = new VeggiePizza();
            }
         
            return pizza;
        }
    }
}
