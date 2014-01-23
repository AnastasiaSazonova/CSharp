using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabric
{
    class Program
    {
        public static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            Pizza pizza = nyStore.orderPizza("cheese");
            Console.ReadLine();
        }
        
    }
}
