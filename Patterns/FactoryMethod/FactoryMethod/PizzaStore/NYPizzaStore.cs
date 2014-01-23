using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string item)
        {
            if (item == "cheese")
            {
                return new NYStyleCheesePizza();
            }
            else
                return null;
        }
    }
}
