using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mode;
            Console.WriteLine("Щоб створити 100 каталогів натисніть 1 ");
            Int32.TryParse(Console.ReadLine(), out mode);
            string path = @"MyFiles";
            string subpath;
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            if (mode == 1)
            {
                if (!dirInfo.Exists)
                {
                    dirInfo.Create();
                }

                for (int i = 0; i < 100; i++)
                {
                    subpath = $"Folder_{i}";
                    dirInfo.CreateSubdirectory(subpath);
                }

                Console.WriteLine("Каталоги створені");
            }

            Console.WriteLine("Для видалення каталогів натисніть 2");
            Int32.TryParse(Console.ReadLine(), out mode);

            if (mode == 2)
            {
                for (int i = 0; i < 100; i++)
                {
                    subpath = $"MyFiles\\Folder_{i}";
                    if (Directory.Exists(path))
                    {
                        Directory.Delete(subpath, true);
                        Console.WriteLine("Каталог удален");
                    }
                    else
                    {
                        Console.WriteLine("Каталог не существует");
                    }
                }
                
            }

            Console.ReadKey();
        }
    }
}
