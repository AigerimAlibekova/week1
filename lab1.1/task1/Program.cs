using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program 
    { //создаём функцию, которая находит простые числа, то есть,которые делятся только на 1 и на самого себя
        static bool Prime(int n)
        {
            if (n <= 1) return false;
            else
            {
                bool l = true;
                for (int i = 2; i < n; i++) //все числа делим на i, то есть с двух до этого числа(не включительно)
                {
                    
                    if (n % i == 0) //если число делится на какое-либо из этих чисел, останавливаем процесс
                    {
                        l = false;
                        break;
                    }
                }
                return l;
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //количество элементов в массиве
            //в Console.Readline читает строку,поэтому мы с помощью Parse переводим эту строку в число
            string s = Console.ReadLine();
            string[] a = s.Split(); //Split разбивает строку на подстроки, нам это нужно, чтобы проверить каждое число
            int[] m = new int[n]; //создаём одномерный массив, в котором n элементов
            for(int i = 0; i < n; i++)
            {
                m[i] = int.Parse(a[i]); 
                // в а[i]- это массив строк, то есть каждое число читается как строка 
                //эту каждую строку с помощью Parse переводим в число и закидывам в m[i]
                //m [i] - массив чисел
            }
            int cnt = 0;
            for (int i = 0; i < n; i++)
            {
                if (Prime(m[i]) == false) m[i] = 0;
                //каждое число в m[i] проверяем в функции Prime, узнаем простое ли оно,если число не простое, заменяем 0
                else cnt++; //а простые числа считаем
            }
            Console.WriteLine(cnt);
            for (int i = 0; i < n; i++) {
                if (m[i] != 0) Console.Write(m[i] + " "); 
                // числа, которые не равны 0, то есть простые, выводим с помощью Console.Write
                    }
        }
    }
}
