using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class MallardDuck : Duck
    {
        public MallardDuck() 
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWings();
        }

        public override void display() 
        {
            Console.WriteLine("I'm real mallard duck.");
        }
    }
}
