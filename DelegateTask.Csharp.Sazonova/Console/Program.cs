using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sort;
using CompareMethods;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrInt = {1, 3, 6, 0, 2};
            SelectionSort.Sort<int>(arrInt, Compare.CompareInt);
            for (int i = 0; i < arrInt.Length; i++)
            {
                Console.Write(arrInt[i]+ "\n");
            }
           
            string[] arrStr = { "three", "one", "zero" };
            SelectionSort.Sort<string>(arrStr, Compare.CompareStrings);
            for (int i = 0; i < arrStr.Length; i++)
            {
                Console.Write("\n" + arrStr[i]);
            }

            Console.ReadKey();       
        }
    }
}
