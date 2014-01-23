using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabric
{
    public abstract class Pizza
    {
        public string name;
        public Dough dough;
        public Sauce sauce;
        public Cheese cheese;
        public Veggies[] veggies;

        public abstract void prepare();
        

        public void bake() 
        {
            Console.WriteLine("Baking");
        }

        public void cut() 
        {
            Console.WriteLine("Cutting");
        }

        public void box() 
        {
            Console.WriteLine("Boxing");
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
