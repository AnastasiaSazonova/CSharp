using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza() 
        {
            name = "NY Style Cheese Pizza";
            dough = "NY Crust Dough";
            sauce = "NY Marinara Sauce";
            toppings.Add("NY Cheese");
        }
    }
}
