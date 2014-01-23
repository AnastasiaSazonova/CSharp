using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class PizzaStore
    {
        SimplePizzaFactory factory;

        public PizzaStore(SimplePizzaFactory Factory)
        {
            this.factory = Factory;
        }

        public Pizza OrderPizza(string type)
        {
            Pizza pizza;
            pizza = factory.CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Box();

            return pizza;
        }
    }
}
