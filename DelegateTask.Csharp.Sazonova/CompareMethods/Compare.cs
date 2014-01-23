using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareMethods
{
    public class Compare
    {
        public static bool CompareInt(int a, int b) 
        {
            if (a > b)
                return true;
            else
                return false;
        }

        public static bool CompareDouble(double a, double b)
        {
            if (a > b)
                return true;
            else
                return false;
        }

        public static bool CompareStrings(string str1, string str2)
        {
            if (str1.Length > str2.Length)
                return true;
            else
                return false;
        }
    }
}
