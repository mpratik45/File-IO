using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static ConsoleApp6.class2;


namespace ConsoleApp6
{
    class Class3
    {
        public static void CreateFolder1()
        {
            string path = @"D:\Think Quotient\TestFolder1";
            DirectoryInfo d = new DirectoryInfo(path);
            if (d.Exists)
            {
                Console.WriteLine("Folder  is already created");
            }
            else
            {
                d.Create();
                Console.WriteLine("Folder is created");
            }
        }
        public static void CreateFile1()
        {
            string path = @"D:\Think Quotient\TestFolder\TestFile1.txt";
            FileInfo f = new FileInfo(path);
            if (f.Exists)
            {
                Console.WriteLine("File already exits");
            }
            else
            {
                f.Create();
                Console.WriteLine("File created");
            }

        }
        static void WriteToFile(Dept dept)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\Think Quotient\TestFolder\TestFile", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(dept.Id);
                bw.Write(dept.Name);
                bw.Write(dept.Location);
                bw.Close();
                fs.Close();
                Console.WriteLine("Data added to file");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static void ReadFromFile()
        {
            try
            {
                FileStream fs = new FileStream(@"D:\Think Quotient\TestFolder\TestFile", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                Console.WriteLine(br.ReadInt32()); //Id
                Console.WriteLine(br.ReadString());// Name
                Console.WriteLine(br.ReadString());// Location
                br.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void WriteToFileUsingStream()
        {
            try
            {
                FileStream fs = new FileStream(@"D:\Think Quotient\TestFolder\TextDoc.txt", FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine("This is sample text in the file");
                sw.Close();
                fs.Close();
                Console.WriteLine("Done Successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void ReadFromFileUsingStream()
        {
            try
            {
                FileStream fs = new FileStream(@"D:\Think Quotient\TestFolder\TextDoc.txt", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                Console.WriteLine(sr.ReadToEnd());
                sr.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public static void Main(string[] args)
        {
            /*DemoFileHandling.CreateFolder();
            DemoFileHandling.CreateFile();
            DemoFileHandling.CreateFolder1();
            DemoFileHandling.CreateFile1();*/

            //Dept dept = new Dept { Id = 1, Name = "HR", Location = "Pune" };
            // WriteToFile(dept);
            //ReadFromFile();

            WriteToFileUsingStream();
            ReadFromFileUsingStream();

        }
    }
}

