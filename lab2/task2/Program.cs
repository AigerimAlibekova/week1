using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program  //КОММЕЕНННТЫЫЫЫЫ ВНИЗУ
    {
        static bool Prime(int x) //recursive function
        {
            if (x == 1) return false;
            if (x == 2) return true;

            bool ok = true;

            for( int i = 2; i < x; i++) //число делим на числа от 2 до него самого(не включительно)
            {
                if (x % i == 0) //если на какое-либо делится, останавливаем процесс
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
        static bool PrimeString(string s)
        {
            return Prime(int.Parse(s)); //строку в Prime переводим в число с помощью Parse
        }
        static void Main(string[] args)
        {
            List<string> output = new List<string>(); //v

            FileStream fs = new FileStream(@"C:\Users\Админ\Desktop\PP2\lab2\task2input.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            string line = sr.ReadLine();
            string[] n = line.Split(' ');

            foreach (var x in n) //для каждой переменной х в string n
            {
                if (PrimeString(x))  //если число простое, добавляем его в ,,,,,,,,,,,,,
                {
                    output.Add(x); //pbx
                }
            }

            sr.Close();
            fs.Close();

            FileStream fs2 = new FileStream(@"C:\Users\Админ\Desktop\PP2\lab2\task2output.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs2);

            foreach(var x in output)
            {
                sw.Write(x + " ");
            }

            sw.Close(); //закрываем StreamReader
            fs2.Close(); //закрываем FileStream2
        }
    }
}
