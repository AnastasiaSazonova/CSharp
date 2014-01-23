using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabric.Ingredients
{
    public class NYPizzaIngredientFactory : PizzaIngredientFactory
    {
        public Dough createDough() 
        {
            return new ThinCrustDough();
        }

        public Sauce createSauce() 
        {
            return new MarinaraSauce();     
        }

        public Cheese createCheese() 
        {
            return new ReggianoCheese();
        }

        public Veggies[] createVeggies() 
        {
            Veggies[] veggies = { new Garlic(), new Garlic() };
            return veggies;
        }
    }
}
