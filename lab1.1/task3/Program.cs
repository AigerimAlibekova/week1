using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args) 
        {
            int n = int.Parse(Console.ReadLine()); // строку перевожу в число с помощью Parse
            string s = Console.ReadLine();
            string[] a = s.Split(); // разделяю строку на подстроки с помощью Split
            int[] b = new int[n]; //создаю одномерный массив, который состоит из n чисел 
            for(int i=0; i<n; i++)
            {
                b[i] = int.Parse(a[i]); //числа, которые в а[i] читает как строки
                //эти строки Parse переводит в числа и закидывает их в массив чисел b[i]
            }
            for(int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " " + a[i] + " "); //выводит на экран каждый элемент по два раза
            }
        }
    }
}
