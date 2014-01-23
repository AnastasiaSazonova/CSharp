using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public class Tea : CaffeineBeverage
    {
        public override void Brew() 
        {
            Console.WriteLine("Steeping tea");
        }

        public override void AddCondiments() 
        {
            Console.WriteLine("Adding lemon");
        }

        public override bool CustomerWantsCoffee()
        {
            return false;
        }
    }
}
