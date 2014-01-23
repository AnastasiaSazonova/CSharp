using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public class VeggiePizza : Pizza
    {
        public VeggiePizza() 
        {
            name = "Veggie Pizza";
            dough = "Veggie crust";
            sauce = "Veggie sauce";
        }
    }
}
