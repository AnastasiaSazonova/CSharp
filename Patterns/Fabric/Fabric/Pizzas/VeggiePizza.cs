using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabric.Pizzas
{
    public class VeggiePizza : Pizza
    {
        PizzaIngredientFactory ingredienFactory;

        public VeggiePizza(PizzaIngredientFactory IngredientFactory) 
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
