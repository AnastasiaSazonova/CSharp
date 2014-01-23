using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorAndComp
{
    public class DinnerMenuIterator : Iterator
    {
        MenuItem[] items;
        int position = 0;

        public DinnerMenuIterator(MenuItem[] Items) 
        {
            this.items = Items;
        }

        public object Next()
        {
            MenuItem menuItem = items[position];
            position++;
            return menuItem;
        }

        public bool HasNext() 
        {
            if (position >= items.Length || items[position] == null)
                return false;
            else
                return true;
        }
    }
}
