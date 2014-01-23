using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorAndComp
{
    public class MenuItem : MenuComponent
    {
        string name;
        string descrition;
        bool vegetarian;
        double price;

        public MenuItem(string Name,
                        string Description,
                        bool Vegetarian,
                        double Price)
        {
            this.name = Name;
            this.descrition = Description;
            this.vegetarian = Vegetarian;
            this.price = Price;
        }

        public override string GetName()
        {
            return this.name;
        }

        public override string GetDescription() 
        {
            return this.descrition; 
        }

        public override bool IsVegetarian() 
        {
            return this.vegetarian; 
        }

        public override double GetPrice()
        {
            return this.price;
        }

        public override void Print() 
        {
            Console.WriteLine("Name: {0} ", GetName());
            if (IsVegetarian()) 
            {
                Console.WriteLine("veggie");
            }
            Console.WriteLine("Description: {0} ", GetDescription());
            Console.WriteLine("Price: {0} ", GetPrice());
        }
    }
}
