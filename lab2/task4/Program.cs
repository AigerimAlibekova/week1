using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string filename = "test1.txt";
            string path = @"C:\Users\Админ\Desktop\PP2\lab2"; //тут пишу, в какой папке хочу создать файл
            string path1 = @"C:\Users\Админ\Desktop\proga"; //тут пишу, в какую папку хочу переместить этот файл
            string aikafile = Path.Combine(path, filename); //объединяет две строки в путь
            string aigerimfile= Path.Combine(path1, filename);
            FileStream fs = File.Create(aikafile); //создаю файл
            fs.Close();
            File.Copy(aikafile, aigerimfile, true); //копирую его в другую папку
            File.Delete(aikafile); //удаляю этот файл с первой папки


            /*string path = @"C:\Users\Админ\Desktop\PP2\lab2\task4.txt"; //тут указываем,где находится существующий файл
            string path1 = @"C:\Users\Админ\Desktop\proga\task4.txt"; //тут пишем, куда хотим переместить этот файл
            
                if (!File.Exists(path))
                {
                FileStream fs = File.Create(path);
                }

            /*if (File.Exists(path2))
                File.Delete(path2);*/

            /*File.Move(path, path1);   //перемещаем файл
            Console.WriteLine( path, path1);*/
        }
    }
}
