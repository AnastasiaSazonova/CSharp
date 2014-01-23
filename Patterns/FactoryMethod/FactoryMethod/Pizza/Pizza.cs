using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Pizza
    {
        public string name;
        public string dough;
        public string sauce;
        public List<string> toppings = new List<string>();

        public void Prepare() 
        {
            Console.WriteLine("\nPreparing " + name);
            Console.WriteLine("Adding sauce " + sauce);
            Console.WriteLine("Adding dough " + dough);
            for (int i = 0; i < toppings.Count; i++)
            {
                Console.WriteLine("Adding toppings: " + toppings[i]);
            }
        }

        public virtual void Bake() 
        {
            Console.WriteLine("Baking");
        }

        public virtual void Cut() 
        {
            Console.WriteLine("Cutting");
        }

        public virtual void Box() 
        {
            Console.WriteLine("Boxing");
        }

        public string GetName() 
        {
            return name;
        }
    }
}
