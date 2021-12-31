using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using FileStructures.SimpleWrite;
using FileStructures.Core;
using FileStructures.KeyEqualValue;
using FileStructures.CSV;
using FileStructures.CursorOperations;
using FileStructures.Indexing;
using FileStructure.Serialization;

namespace IntroductionToFileStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("-------------- Simple write demo -----------");
            SimpleWrite.WriteToAFile(new Student() { Id = 1002145, Name = "Haris" }.ToString());
            Console.WriteLine(SimpleWrite.ReadFromFile());
            Console.WriteLine("--------------------------------------------");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-------------- Key equal value demo-----------");
            KeyEqualValue.WriteToAFile(new Student() { Id = 1002145, Name = "Haris" });
            Console.WriteLine(KeyEqualValue.ReadFromAFile());
            Console.WriteLine("--------------------------------------------");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("-------------- Key equal value demo with student object -----------");
            var result = KeyEqualValue.ReadFromAFileStd();
            Console.WriteLine(string.Join(Environment.NewLine, result));
            Console.WriteLine("--------------------------------------------");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-------------- Writing to a CSV file -----------");
            CSVOps.WriteToAFile();
            CSVOps.WriteMultiColumnCSV();
            Console.WriteLine("--------------------------------------------");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("-------------- Writing to a specific line -----------");
            CursorOperations.WriteToASpecificLine("Inserted line", 1);
            Console.WriteLine("--------------------------------------------");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("-------------- Writing to a specific location -----------");
            CursorOperations.WriteToASpecificLocation("INJETED ", 21);
            Console.WriteLine("--------------------------------------------");

            //Directory Operations
            Console.ForegroundColor = ConsoleColor.Red;
            Directory.CreateDirectory("MyDirectory/SomeOtherChildDirectory");
            Console.WriteLine(string.Join("\n", Directory.EnumerateFiles("\\")));
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine(string.Join("\n", Directory.EnumerateDirectories(AppDomain.CurrentDomain.BaseDirectory)));

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-------------- Indexing operations -----------");
            Console.WriteLine(Indexing.FindName("Darragh"));
            Console.WriteLine("--------------------------------------------");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("-------------- Serilization demo -----------");
            Serializer.SerializeObject(new Student() { Id = 1002145, Name = "Haris" }, "SerializedStudent.bin");
            Console.WriteLine(Serializer.DeserializeObject<Student>("SerializedStudent.bin"));
            Console.WriteLine("--------------------------------------------");
        }
    }
}
