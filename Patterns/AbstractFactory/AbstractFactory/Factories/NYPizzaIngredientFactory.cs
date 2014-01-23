using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class NYPizzaIngredientFactory : PizzaIngredientFactory
    {
        public Dough createDough() 
        {
            return new ThinDough();
        }

        public Cheese createCheese() 
        {
            return new ReggianoCheese();
        }

        public Sauce createSauce() 
        {
            return new MarinaraSauce();
        }
    }
}
