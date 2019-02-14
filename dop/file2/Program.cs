using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace file2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string[] file_name = File.ReadAllLines(@"C:\Users\Админ\Desktop\PP2\lab2\task4.txt");
            Console.WriteLine(file_name[0]);*/
            string text = File.ReadAllText(@"C:\Users\Админ\Desktop\PP2\lab2\task4.txt");
            File.WriteAllText(@"C:\Users\Админ\Desktop\lafamilia\task4out.txt", text);
            //тут сама новый файл создала он скопировал тот текст, еслитам что то написано, то перезаписывает
            /*try   task4 lab2
            {
            if (!File.Exists(path))
            {
                FileStream fs = File.Create(path);//{ }
            }

            if (File.Exists(path2))
                File.Delete(path2);
            File.Move(path, path2);   //перемещаем файл
            Console.WriteLine(path, path2);
            }
            catch (Exception e)
            {
                Console.WriteLine( e.ToString());
            }*/
        }
    }
}
