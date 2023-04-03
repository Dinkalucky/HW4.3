using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"MyFiles\newFile.txt";
            string inputText = "New Text";
            string outputText;

            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.WriteLine(inputText);
            }

            using (StreamReader reader = new StreamReader(path))
            {
                outputText = reader.ReadToEnd();
            }
            Console.WriteLine(outputText);
            Console.ReadLine();
        }
    }
}
