using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Solve(string s) //КОМММЕЕЕНТТЫЫЫЫ ВНИЗУУУУУУУУУУУУ
        {
            bool ok = true;
            for(int i = 0; i < s.Length; i++)
            {
                if(s[s.Length - 1 - i] != s[i]) // проверяем последнюю букву и первую и так далее
                    //если буквы не одни и те же, останавливаем процесс
                {
                    ok = false;
                    break;
                }
            }
            if (ok) //если буквы одинаковые, выводим на экран "Yes"
            {
                Console.WriteLine("Yes");
            }
            else //если не одинаковые, то "No"
            {
                Console.WriteLine("No");
            }
        }
        static void Main(string[] args)
        {
        
            FileStream fs = new FileStream(@"C:\Users\Админ\Desktop\PP2\lab2\task1.txt", FileMode.Open, FileAccess.Read);
            //открываем текстовый файл и читаем его
            StreamReader sr = new StreamReader(fs);

            string line = sr.ReadLine(); //что написано в текствовом файле берём как string

            Solve(line); //проверяем этот string с помощью функции Solve

            sr.Close();
            fs.Close();
        }
    }
}
