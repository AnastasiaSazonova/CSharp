using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza() 
        {
            name = "Chicago Style Cheese Pizza";
            dough = "Chicago Crust";
            sauce = "Chicago Tomato Sauce";
            toppings.Add("Chicago Mozarella");
        }

        public override void Cut() 
        {
            Console.WriteLine("Cutting Chicago Pizza");
        }
    }
}
