using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static ConsoleApp6.Class4;

namespace ConsoleApp6
{
    class Class4
    {

        class DemoFileHandling1
        {

            public class Course1
            {
                public int Id { get; set; }
                public string Name { get; set; }
                public string Fees { get; set; }
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
                string path = @"E:\Think Quotient\TestFolder\Test1File.txt";
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
            static void WriteToFile(Course1 course1)
            {
                try
                {
                    FileStream fs = new FileStream(@"E:\Think Quotient\TestFolder\Test1File.txt", FileMode.Create, FileAccess.Write);
                    BinaryWriter bw = new BinaryWriter(fs);
                    bw.Write(course1.Id);
                    bw.Write(course1.Name);
                    bw.Write(course1.Fees);
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
                    FileStream fs = new FileStream(@"E:\Think Quotient\TestFolder\Test1File.txt", FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    Console.WriteLine(br.ReadInt32()); //Id
                    Console.WriteLine(br.ReadString());// Name
                    Console.WriteLine(br.ReadInt32());// Fees
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
                    FileStream fs = new FileStream(@"E:\Think Quotient\TestFolder\Test1File.txt", FileMode.Create, FileAccess.Write);
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
                    FileStream fs = new FileStream(@"E:\Think Quotient\TestFolder\Test1File.txt", FileMode.Open, FileAccess.Read);
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
                //DemoFileHandling1.CreateFolder();
                //DemoFileHandling1.CreateFile();
                //Course1 course1 = new Course1 { Id = 1, Name = ".Net", Fees = "50000" };
                // WriteToFile(course1);
                //ReadFromFile();
                WriteToFileUsingStream();
                ReadFromFileUsingStream();


            }
        }
    }
}
