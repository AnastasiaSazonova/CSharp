using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorAndComp
{
    public class Waitress
    {
        Menu dinnerMenu;

        public Waitress(Menu DinnerMenu)
        {
            this.dinnerMenu = DinnerMenu;
        }

        public void PrintMenu() 
        {
            Iterator dinnerMenuIterator = dinnerMenu.CreateIterator();
            Console.WriteLine("Dinner menu: ");
            PrintMenu(dinnerMenuIterator);
        }

        private void PrintMenu(Iterator iterator)
        {
            while (iterator.HasNext()) 
            {
                MenuItem menuItem = (MenuItem)iterator.Next();
                Console.WriteLine("Name: {0}", menuItem.GetName());
                Console.WriteLine("Description: {0}", menuItem.GetDescription());
                Console.WriteLine("Vegeterian: {0}", menuItem.IsVegetarian());
                Console.WriteLine("Price: {0}", menuItem.GetPrice());
            }
        }
    }
}
