using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            Pizza pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine(pizza.ToString());
            Console.ReadLine();
        }
    }
}
