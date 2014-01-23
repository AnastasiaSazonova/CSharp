using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoPizzaStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.OrderPizza("cheese");
            pizza = chicagoPizzaStore.OrderPizza("cheese");
           
            Console.ReadLine();
        }
    }
}
