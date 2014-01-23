using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    public class SelectionSort
    {
        public static void Sort<T>(IList<T> arr, Func<T, T, bool> compare)
        {
            if (arr == null)
                throw new ArgumentException("Null reference on array.");
            if (arr.Count == 0)
                throw new ArgumentException("Empty array.");
            if(compare == null)
                throw new ArgumentException("Null reference on compare function.");
   
            for (int i = 0; i < arr.Count - 1; i++)
            {
                T min = arr[i];
                for (int j = i + 1; j < arr.Count; j++)
                {
                    if (!compare(arr[j], min))
                    {
                        T temp = min;
                        min = arr[j];
                        arr[j] = temp;
                    }
                }
                arr[i] = min;
            }
        }
    }
}
