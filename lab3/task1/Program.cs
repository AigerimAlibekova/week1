using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    enum Df
    {
        DIR,
        FILE
    }

    class Layer
    {
        private int selectedItem;
        public int SelectedItem
        {
            get
            {
                return selectedItem;
            }
            set
            {
                if (value >= Content.Count)
                {
                    selectedItem = 0;
                }
                else if (value < 0)
                {
                    selectedItem = Content.Count - 1;
                }
                else
                {
                    selectedItem = value;
                }
            }
        }

        public List<FileSystemInfo> Content
        {
            get;
            set;
        }

        public void DeleteSelectedItem()
        {
            FileSystemInfo fileSystemInfo = Content[selectedItem];
            if (fileSystemInfo.GetType() == typeof(DirectoryInfo))
            {
                Directory.Delete(fileSystemInfo.FullName, true);
            }
            else
            {
                File.Delete(fileSystemInfo.FullName);
            }
            Content.RemoveAt(selectedItem);
            selectedItem--;
        }

        public void rename(FileSystemInfo fInfo)

        {

            if (fInfo.GetType() == typeof(DirectoryInfo))

            {
                DirectoryInfo y = fInfo as DirectoryInfo;
                for (int i = 1; i <= 2; i++) //  создаем пространство для надписи с консоли
                {
                    Console.WriteLine();
                }
                for (int i = 0; i < 20; i++)
                {
                    Console.Write("  ");
                }
                Console.Write("Enter new name:"); //запись в консоли для пользователя  
                string s = Console.ReadLine(); // новое имя которое мы напишем
                string path = y.Parent.FullName;
                string newname = Path.Combine(path, s); // потому что в c # нет команды просто переименовать имя каталога
                y.MoveTo(newname); // мы переместим файл по тому же пути с новым именем
            }
            else
            {
                FileInfo y = fInfo as FileInfo;
                for (int i = 1; i <= 2; i++) // создание пространства для записи имени из консоли
                {
                    Console.WriteLine();
                }
                for (int i = 0; i < 20; i++)
                {
                    Console.Write("  ");
                }
                Console.Write("Enter new name:"); //пишем в консоли для пользователя 
                string s = Console.ReadLine();
                string newname = Path.Combine(y.Directory.FullName, s);
                y.MoveTo(newname);

            }

        }

        public void Draw()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            for (int i = 0; i < Content.Count; ++i)
            {
                if (i == SelectedItem)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                }
                else
                    Console.BackgroundColor = ConsoleColor.Black;
                if (Content[i].GetType() == typeof(DirectoryInfo))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                }
                Console.WriteLine((i + 1) + "." + " " + Content[i].Name);

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Df mode = Df.DIR;
            DirectoryInfo root = new DirectoryInfo(@"C:\Users\Админ\Desktop\PP2");
            Stack<Layer> history = new Stack<Layer>();
            history.Push(
                    new Layer
                    {
                        Content = root.GetFileSystemInfos().ToList(),
                        SelectedItem = 0
                    }
                );


            while (true)
            {
                if (mode == Df.DIR)
                {
                    history.Peek().Draw();
                }
                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
                switch (consoleKeyInfo.Key)
                {
                    case ConsoleKey.Delete:
                        history.Peek().DeleteSelectedItem();
                        break;
                    case ConsoleKey.UpArrow:
                        history.Peek().SelectedItem--;
                        break;
                    case ConsoleKey.DownArrow:
                        history.Peek().SelectedItem++;
                        break;
                    case ConsoleKey.Backspace:
                        if (mode == Df.DIR)
                        {
                            history.Pop();
                        }
                        else
                        {
                            mode = Df.DIR;
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        break;
                    case ConsoleKey.Enter:
                        int gg = history.Peek().SelectedItem;
                        FileSystemInfo fileSystemInfo = history.Peek().Content[gg];
                        if (fileSystemInfo.GetType() == typeof(DirectoryInfo))
                        {
                            DirectoryInfo directoryInfo = fileSystemInfo as DirectoryInfo;
                            history.Push(
                               new Layer
                               {
                                   Content = directoryInfo.GetFileSystemInfos().ToList(),
                                   SelectedItem = 0
                               });
                        }
                        else
                        {
                            mode = Df.FILE;
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Black;
                            using (StreamReader sr = new StreamReader(fileSystemInfo.FullName))
                            {
                                Console.WriteLine(sr.ReadToEnd());
                            }
                        }
                        break;
                    case ConsoleKey.F2: // console key for renaming
                        history.Peek().rename(history.Peek().Content[history.Peek().SelectedItem]);
                        break;

                }
            }
        }
    }
}
