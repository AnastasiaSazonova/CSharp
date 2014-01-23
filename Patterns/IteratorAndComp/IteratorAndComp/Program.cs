using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorAndComp
{
    class Program
    {
        static void Main(string[] args)
        {
            LunchMenu dinnerMenu = new LunchMenu();
            Waitress waitress = new Waitress(dinnerMenu);
            waitress.PrintMenu();
            Console.ReadKey();
        }
    }
}
