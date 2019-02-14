using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace file1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите название файла");
            string file_name = Console.ReadLine();
            Console.Write(File.ReadAllText(file_name));
        //ReadAllText(сюда мы должны передать название файла, так как оно содержится в переменной file_name,мы сюда её передаём)
        }
    }
}
