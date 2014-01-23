using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class CaffeineBeverage
    {
        public void PrepareRecipe() // can't be overriden, must be final
        {
            BoilWater();
            Brew();
            PourInCup();
            if (CustomerWantsCoffee()) // метод-перехватчик
            {
                AddCondiments();
            }
        }

        public abstract void Brew();

        public abstract void AddCondiments();

        void BoilWater() 
        {
            Console.WriteLine("Boiling water");
        }

        void PourInCup() 
        {
            Console.WriteLine("Pouring in cup.");
        }

        public virtual bool CustomerWantsCoffee()
        {
            return true;
        }
             
    }
}
