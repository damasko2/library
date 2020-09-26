using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_int
{
    class library_int
    {
        public static int Min(int[] arr)
        {
            int min = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]<min)
                {
                    min = arr[i];
                }
            }

            return min;
        }
        public static int Max(int []arr)
        {
            int max = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]>max)
                {
                    max = arr[i];
                }
            }

            return max;
        }
        public static int Summ(int []arr)
        {
            int summ = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                summ += arr[i];
            }

            return summ / arr.Length;
        }
        public static void Revers(int []arr)
        {
            int []arr_2 = arr;
            int count = arr.Length-1;
            int num = 0;

            for (int i = 0; i < arr.Length/2; i++)
            {
                num = arr[i];
                arr[i] = arr[count];
                arr[count] = num;
                count = count - 1;
            }
        }
        public static string Conver(int []arr)
        {
            StringBuilder str = new StringBuilder();

            str.Append("[");
            str.Append(string.Join(",", arr));
            str.Append("]");

            string result = str.ToString();
            return result;
        }
    }
}
