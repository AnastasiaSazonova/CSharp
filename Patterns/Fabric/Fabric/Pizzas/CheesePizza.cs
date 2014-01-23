using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabric.Pizzas
{
    public class CheesePizza : Pizza
    {
        PizzaIngredientFactory ingredienFactory;

        public CheesePizza(PizzaIngredientFactory IngredientFactory) 
        {
            this.ingredienFactory = IngredientFactory;
        }

        public override void prepare() 
        {
            Console.WriteLine("Preparing" + name);
            dough = ingredienFactory.createDough();
            cheese = ingredienFactory.createCheese();
            sauce = ingredienFactory.createSauce();
        }
    }
}
