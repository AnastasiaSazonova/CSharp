using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolynomLib
{
    public class Polynom
    {
        #region fields
        private double[] coefficients;
        private static double[] remainers;
        private static double[] dividedPolynomsCoeffs;
        #endregion

        #region constructors
        public Polynom(double[] Coefficients)
        {
            if (Coefficients == null)
                return;
            if (Coefficients.Length != 0 && Coefficients[0] != 0)
            {
                this.coefficients = Coefficients;           
            }
            else
            {
                throw new ArgumentException("Please, enter list, that starts not from 0 to initialize polynom.");
            }
        }

        public Polynom(Polynom polynom)
        {
            if (polynom == null)
                return;
            if(polynom.GetPolynomsCoeffs().Length == 0)
                return;
            this.coefficients = new double[polynom.Degree + 1];
            for (int i = 0; i <= polynom.Degree; i++)
            {
                this.coefficients[i] = polynom.GetPolynomsCoeffs()[i];
            }
            //this.coefficients = polynom.GetPolynomsCoeffs();
        }

        #endregion 

        #region public methods and properties(degree, get coefficients, +, -, *, /)

        public int Degree
        {
            get
            {
                return this.GetPolynomsCoeffs().Length - 1;
            }
        }

        public double[] GetPolynomsCoeffs()
        {
            return this.coefficients;
        } 

        public static Polynom operator+(Polynom firstPolynom, Polynom secondPolynom)
        {
            if (firstPolynom == null || secondPolynom == null)
            {
                throw new ArgumentException("Null polynom.");
            }
            Polynom addedPolynom;
            int minDegree = (firstPolynom.Degree > secondPolynom.Degree)? secondPolynom.Degree : firstPolynom.Degree;
            double[] minPolynomCoeffs;
            minPolynomCoeffs = firstPolynom.Degree > secondPolynom.Degree ? firstPolynom.GetPolynomsCoeffs() : secondPolynom.GetPolynomsCoeffs();
            addedPolynom = (firstPolynom.Degree > secondPolynom.Degree) ? new Polynom(firstPolynom) : new Polynom(secondPolynom);
            for (int i = 0; i < minDegree + 1; i++)
            {
                addedPolynom.GetPolynomsCoeffs()[i] += minPolynomCoeffs[i];
            }
            return addedPolynom;
        }
       
        public static Polynom operator-(Polynom firstPolynom, Polynom secondPolynom)
        {
            if (firstPolynom == null || secondPolynom == null)
            {
                throw new ArgumentException("Null polynom.");
            }
            Polynom subtractedPolynom;
            int minDegree = (firstPolynom.Degree > secondPolynom.Degree) ? secondPolynom.Degree : firstPolynom.Degree;
            int maxDegree = (firstPolynom.Degree < secondPolynom.Degree) ? secondPolynom.Degree : firstPolynom.Degree;
            double[] subtractedCoeffs = new double[maxDegree + 1];
            for (int i = minDegree; i >= 0; i--)
            {
                subtractedCoeffs[i] = firstPolynom.GetPolynomsCoeffs()[i] - secondPolynom.GetPolynomsCoeffs()[i];
            }
            
            subtractedPolynom = new Polynom(subtractedCoeffs);
            return subtractedPolynom;
        }
      
        public static Polynom operator*(Polynom firstPolynom, Polynom secondPolynom)
        {
            Polynom multipliedPolynom;
            double[] firstPolynomsCoeffs = firstPolynom.GetPolynomsCoeffs();
            double[] secondPolymonsCoeffs = secondPolynom.GetPolynomsCoeffs();
            int lengthOfFirst = firstPolynomsCoeffs.Length;
            int lengthOfSecond = secondPolymonsCoeffs.Length;
            double[] multiplyCoeffs = new double[lengthOfFirst + lengthOfSecond - 1];
            
            for (int i = 0; i < lengthOfFirst; i++)
            {
                int counter = i;

                for (int j = 0; j < lengthOfSecond; j++)
                {
                    double resCoeff = firstPolynomsCoeffs[i] * secondPolymonsCoeffs[j];
                    multiplyCoeffs[counter++] += resCoeff;
                }
            }

            multipliedPolynom = new Polynom(multiplyCoeffs);
            return multipliedPolynom;
        }

        public static Polynom operator/(Polynom firstPolynom, Polynom secondPolynom)
        {
            if (firstPolynom.Degree <= secondPolynom.Degree)
            {
                throw new ArgumentException("Power of the first polynom must be greater than of second.");
            }
            else
            {
                Polynom dividedPolynom;
                double[] firstPolynomsCoeffs = firstPolynom.GetPolynomsCoeffs();
                double[] secondPolynomsCoeffs = secondPolynom.GetPolynomsCoeffs();
                dividedPolynomsCoeffs = new double[firstPolynomsCoeffs.Length - 1];
                remainers = new double[secondPolynomsCoeffs.Length];
                int index = 0;
                double [] arrayOfRemainers = division(firstPolynomsCoeffs, secondPolynomsCoeffs, index++);
                while (arrayOfRemainers.Length >= secondPolynomsCoeffs.Length)
                {
                    arrayOfRemainers = division(firstPolynomsCoeffs, secondPolynomsCoeffs, index++);
                }

                dividedPolynom = new Polynom(dividedPolynomsCoeffs);
                return dividedPolynom;
            }
        }

        public override string ToString()
        {
            string str = "";
            int degree = this.Degree;
            for (int i = 0; i < degree; i++)
            {
                double currentCoeff = this.GetPolynomsCoeffs()[i];
                if (currentCoeff == 0)
                    str += "";
                else if (currentCoeff == 1)
                    str += string.Format("x^" + (degree - i) + " + ");
                else
                    str += string.Format(currentCoeff + "x^" + (degree - i) + " + ");
            }
            str += this.GetPolynomsCoeffs()[degree];
            return str;
        }

        #endregion

        #region private methods
        private static int counter = 0;
        private static double[] division(double[] firstPolynomsCoeffs, double[] secondPolynomsCoeffs, int index)
        {
            double divisor = secondPolynomsCoeffs[0];
            double res;
            
            if (dividedPolynomsCoeffs.Length == 0)
            {
                res = firstPolynomsCoeffs[0] / divisor;
            }
            else
            {
                res = remainers[0] / divisor;
            }
            dividedPolynomsCoeffs[counter++] = res;
            remainers = new double[secondPolynomsCoeffs.Length];

            for (int i = 0; i < secondPolynomsCoeffs.Length; i++)
            {

                double remainer = res * secondPolynomsCoeffs[i];
                double rem = firstPolynomsCoeffs[index++] - remainer;
                if (i > 0)
                {
                    remainers[i] = rem;
                }

            }
            if (firstPolynomsCoeffs.Length > index)
            {
                //remainers[secondPolynomsCoeffs.Length] = firstPolynomsCoeffs[index];
            }
            return remainers;
        }

     
        #endregion
    }
}

