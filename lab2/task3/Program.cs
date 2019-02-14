using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task3
{
    class Program
    {
        public static void Level(int Level)
        {
            for (int i = 0; i < Level; i++)
            {
                Console.Write("   ");
            }
        }
        public static void FILE(DirectoryInfo dir, int level)
        {
            foreach (FileInfo f in dir.GetFiles()) //для каждого файла в DirectoryInfo
            {
                Level(level);
                Console.WriteLine(f.Name);
            }
            foreach (DirectoryInfo d in dir.GetDirectories()) //для каждой папки
            {
                Level(level);
                Console.WriteLine(d.Name);
                FILE(d, level + 1); //если в папке есть другие папки
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Админ\Desktop\PP2"); //указываю папку
            FILE(dir, 0); //показывает папки и файлы
        }
    }
}
