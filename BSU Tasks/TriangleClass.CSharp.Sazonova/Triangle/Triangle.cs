using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleLib
{
    public class Triangle
    {
        #region fields
        private double A;
        private double B;
        private double C; 
        #endregion

        #region constructor
        public Triangle(double a = 1, double b = 1, double c = 1)
        {
            if (a > 0 && b > 0 && c > 0)
            {
                if (a + b > c && b + c > a && a + c > b)
                {
                    this.A = a;
                    this.B = b;
                    this.C = c;
                }
                else
                {
                    throw new ArgumentException("It's not a triangle.");
                }
            }
            else 
            {
                throw new ArgumentException("Sides must be > 0."); 
            }
        }
        #endregion

        #region methods

        public double GetSquare()
        {
             double halfPerimeter = GetPerimeter() / 2;
             return Math.Round(Math.Sqrt(halfPerimeter * (halfPerimeter - A) * (halfPerimeter - B) * (halfPerimeter - C)), 2);
        }

        public double GetPerimeter()
        {
            return A + B + C;
        }

        public string Type 
        {
            get
            {
                if (A == B && B == C)
                {
                    return "equileteral";
                }
                else if (A == B || A == C || B == C)
                {
                    return "isosceles";
                }
                else
                {
                    return "normal";
                }
            }
        }

        public void SetTriangle(double a, double b, double c)
        {
            if (a > 0 && b > 0 && c > 0)
            {
                if (a + b > c && b + c > a && a + c > b)
                {
                    this.A = a;
                    this.B = b;
                    this.C = c;
                }
                else
                {
                    throw new ArgumentException("It's not a triangle.");
                }
            }
            else
            {
                throw new ArgumentException("Sides must be > 0.");
            }
        }

        #endregion
    }
}
