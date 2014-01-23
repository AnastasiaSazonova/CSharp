using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriangleLib;

namespace ConsoleApplication
{
    class Program
    {
        private static void PrintTrianglesData(Triangle triangle) 
        {
            Console.WriteLine("Square = {0}, Perimeter = {1}, Type is {2}", triangle.GetSquare(), triangle.GetPerimeter(), triangle.Type);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter first side: ");
            double a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second side: ");
            double b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third side: ");
            double c = int.Parse(Console.ReadLine());

            try
            {
                Triangle triangle = new Triangle(a, b, c);
                PrintTrianglesData(triangle);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
