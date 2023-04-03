using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string path = @"MyFiles\newFile.txt";
            string compressedFile = @"MyFiles\newFile.gz";
            FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
            string text;
            if (File.Exists(path))
            {
                Console.WriteLine("Файл знайдено");
                using (StreamReader reader = new StreamReader(stream))
                {
                    text = reader.ReadToEnd();
                    Console.WriteLine(text);
                    FileStream compressStream = File.Create(compressedFile);
                    GZipStream compress = new GZipStream(compressStream, CompressionMode.Compress);
                    stream.CopyToAsync(compress);
                }
            }
            else
            {
                Console.WriteLine("Такого файлу немає");
            }

            Console.ReadKey();
        }
    }
}
