using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public abstract class Duck
    {
        public FlyBehavior flyBehavior;
        public QuackBehavior quackBehavior;
        public Duck() {}

        abstract public void display(); 

        public void performFly() 
        {
            flyBehavior.fly();
        }

        public void performQuack() 
        {
            quackBehavior.quack();
        }

        public void swim() 
        {
            Console.WriteLine("All ducks float."); 
        }

        public void setFlyBehavior(FlyBehavior fb) 
        {
            flyBehavior = fb;
        }

        public void setQuackBehavior(QuackBehavior qb)
        {
            quackBehavior = qb;
        }
    }
}
