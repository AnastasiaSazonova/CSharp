using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleClass
{
    public class Triangle
    {
        #region fields
        private double A;
        private double B;
        private double C; 
        #endregion

        #region constructor
        public Triangle(int a = 1, int b = 1, int c = 1)
        {
            if (a > 0 && b > 0 && c > 0)
            {
                if (a + b > c || b + c > a || a + c > b)
                {
                    this.A = a;
                    this.B = b;
                    this.C = c;
                }
            }
            else 
            {
                throw new ArgumentException(); 
            }
        }
        #endregion

        #region methods

        public double GetSquare()
        {
            /*if(Type == "normal")
                {*/
                    double halfPerimeter = GetPerimeter() / 2;
                    return Math.Round(Math.Sqrt(halfPerimeter * (halfPerimeter - A) * (halfPerimeter - B) * (halfPerimeter - C)), 2);
                /*}
                else if (Type == "isosceles")
                {
                    if(A == C)
                    {
                        return Math.Round((B * (Math.Sqrt(Math.Pow(A, 2) - (Math.Pow(B, 2) / 4)))) / 2, 2);
                    }
                    else if (A == B)
                    {
                        return Math.Round((C * (Math.Sqrt(Math.Pow(A, 2) - (Math.Pow(C, 2) / 4)))) / 2, 2);
                    }
                    else 
                    {
                        return Math.Round((A * (Math.Sqrt(Math.Pow(B, 2) - (Math.Pow(A, 2) / 4)))) / 2, 2);
                    }
                }
                else 
                {
                    return Math.Round((Math.Sqrt(3) / 4) * Math.Pow(A, 2), 2);
                }*/
            
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
        #endregion
    }
}
