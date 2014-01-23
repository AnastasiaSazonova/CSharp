using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class Pizza
    {
        public string name;
        public Dough dough;
        public Sauce sauce;
        public Cheese cheese;

        public abstract void Prepare();

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

        public void SetName(string Name)
        {
            this.name = Name;
        }

        public string GetName()
        {
            return name;
        }

        public override string ToString()
        {
            return string.Format("Your pizza: " + name + "\nWith: " + dough.name + " + " + sauce.name + " + " + cheese.name);
        }
    }
}
