using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static ConsoleApp6.class2;

namespace ConsoleApp6
{
    class class2
    {
        public class Dept
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Location { get; set; }
        }


        static void CreateFolder()
        {
            string path = @"E:\Think Quotient\TestFolder";
            if (Directory.Exists(path))
            {
                Console.WriteLine("Folder is already created");
            }
            else
            {
                Directory.CreateDirectory(path);
                Console.WriteLine("Folder is created");
            }
        }
        static void CreateFile()
        {
            string path = @"E:\Think Quotient\TestFolder\TestFile.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File already exits");
            }
            else
            {
                File.Create(path);
                Console.WriteLine("File created sucessfully");
            }

        }



        static void Main(string[] args)
        {
            Dept dept = new Dept { Id = 1, Name = "HR", Location = "Pune" };

        }

    }
}