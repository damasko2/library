using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lib_int;

namespace library
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[] arr = new int[20];

            Console.WriteLine("Рандомный массив");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(100);
                Console.Write(arr[i] + "  ");
            }
            Console.WriteLine();

            Console.Write("\nMin -> ");
            Console.WriteLine(library_int.Min(arr));
            Console.WriteLine();

            Console.Write("Max -> ");
            Console.WriteLine(library_int.Max(arr));
            Console.WriteLine();

            Console.Write("Среднее -> ");
            Console.WriteLine(library_int.Summ(arr));
            Console.WriteLine();

            Console.Write("Перевернутое -> ");
            library_int.Revers(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+"  ");
            }
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("Строка -> ");
            string str = library_int.Conver(arr);
            Console.WriteLine(str);
            Console.WriteLine();
        }
    }
}
