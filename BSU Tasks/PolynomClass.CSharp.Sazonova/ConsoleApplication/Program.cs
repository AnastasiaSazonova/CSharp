using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PolynomLib;

namespace ConsoleApplication
{
    class Program
    {
        
        public static double[] InitializePolynom()
        {
            double[] coeffs;
            Console.WriteLine("Enter max degree of new polynom: ");
            int degree = int.Parse(Console.ReadLine());
            if (degree <= 0)
            {
                throw new ArgumentException("Degree must be greater than 0.");
            }
            else
            {
                coeffs = new double[degree + 1];
                for (int i = 0; i <= degree; i++)
                {
                    Console.WriteLine("Enter x^" + (degree - i) + " coefficient: ");
                    coeffs[i] = double.Parse(Console.ReadLine());
                }
            }
            return coeffs;
        }

        static void Main(string[] args)
        {
           
            double[] firstCoeffs = InitializePolynom();
            double[] secondCoeffs = InitializePolynom();
         
            try
            {
                Polynom polynom1 = new Polynom(firstCoeffs);
                Console.WriteLine("First polynom:");
                Console.WriteLine(polynom1.ToString());
                Polynom polynom2 = new Polynom(secondCoeffs);
                Console.WriteLine("\n\nSecond polynom:");
                Console.WriteLine(polynom2.ToString());

                Console.WriteLine("\n\nAddition:");
                Polynom result = polynom1 + polynom2;
                Console.WriteLine(result.ToString());

                Console.WriteLine("\n\nSubtraction:");
                Polynom result2 = polynom1 - polynom2;
                Console.WriteLine(result2.ToString());
                
                Console.WriteLine("\n\nMultiplication:");
                Polynom result3 = polynom1 * polynom2;
                Console.WriteLine(result3.ToString());

               /*Console.WriteLine("\n\nDivision:");
                Polynom divisionResult = polynom1 / polynom2;
                Console.WriteLine(divisionResult.ToString());*/
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
    }

