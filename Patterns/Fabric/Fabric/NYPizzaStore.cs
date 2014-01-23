using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabric
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza createPizza(string type)
        {
            Pizza pizza = null;
            PizzaIngredientFactory ingredientFactory = new Ingredients.NYPizzaIngredientFactory();

            if (type == "cheese")
            {
                pizza = new Pizzas.CheesePizza(ingredientFactory);
                pizza.setName("NY Cheese Pizza");
            }
            else if (type == "veggie")
            {
                pizza = new Pizzas.VeggiePizza(ingredientFactory);
                pizza.setName("NY Veggie Pizza");
            }
                return pizza;
        }
    }
} 
