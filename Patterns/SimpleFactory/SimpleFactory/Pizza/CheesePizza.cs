using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class CheesePizza : Pizza
    {
        public CheesePizza() 
        {
            name = "Chese Pizza";
            dough = "Cheese crust";
            sauce = "Marinara";
        }
    }
}
