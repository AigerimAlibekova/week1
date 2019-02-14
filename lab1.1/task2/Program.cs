using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Student
    {
        public string name;
        public string id;
        public string year;

        public Student(string n, string i, string y)
        {
            name = n; //указываем, что name,который в public string - это n(string),который в public Student и так далее
            id = i; 
            year = y;
        }
        public void GetInfo() //функция, которая выводит на экран имя, айди и год студента
        {
            Console.WriteLine(name + " " + id + " " + year);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student a = new Student(Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
            //читает (вводим) name,id,year;
            a.GetInfo(); // реализует действие, которое указано в функции public void Info();
        }
    }
}
