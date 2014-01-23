using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string item)
        {
            Pizza pizza = null;
            PizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

            if (item == "cheese")
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.SetName("NY Style cheese pizza");
            }

            return pizza;
        }
    }
}
