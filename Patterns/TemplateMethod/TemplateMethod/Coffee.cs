using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class Coffee : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Dripping coffee.");
        }

        public override void AddCondiments() 
        {
            Console.WriteLine("Adding sugar.");
        }
    }
}
