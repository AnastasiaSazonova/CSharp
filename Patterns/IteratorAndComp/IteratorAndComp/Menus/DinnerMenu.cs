﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorAndComp
{
    public class DinnerMenu : Menu
    {
        static readonly int Max_Items = 6;
        int numberOfMenuItems = 0;
        MenuItem[] menuItems;

        public DinnerMenu() 
        {
            menuItems = new MenuItem[Max_Items];
            AddItem("Veggie pizza", "ingredients", true, 10);
            AddItem("Cheese pizza", "ingredients", false, 10);
        }

        public void AddItem(string Name, string Description, 
                            bool Vegetarian, double Price)
        {
            MenuItem menuItem = new MenuItem(Name, Description, Vegetarian, Price);
            if (numberOfMenuItems > Max_Items)
            {
                Console.Write("Menu is full enough.");
            }
            else
                menuItems[numberOfMenuItems] = menuItem;
                numberOfMenuItems++;
        }

        public Iterator CreateIterator() 
        {
            return new DinnerMenuIterator(menuItems);
        }
    }
}
