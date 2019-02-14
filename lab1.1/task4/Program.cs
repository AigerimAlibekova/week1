using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // n - строка, с помощью Parse переводит n в число
            int[,] a = new int[n, n]; //создаю двумерный массив
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("[*]"); //этот двумерный массив заполняю звёздочками
                }
            }
        }
    }
}
