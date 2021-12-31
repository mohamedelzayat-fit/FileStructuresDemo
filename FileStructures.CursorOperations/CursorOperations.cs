using System.Collections.Generic;
using System.IO;

namespace FileStructures.CursorOperations
{
    public class CursorOperations
    {
        public static void WriteToASpecificLine(string data, int lineNumber)
        {
            using(var fs = new FileStream("TestCursor.txt", FileMode.Open))
            using(var sr = new StreamReader(fs))
            using(var sw = new StreamWriter(fs))
            {
                var MyFile = new List<string>();

                while (sr.Peek() != -1)
                    MyFile.Add(sr.ReadLine());

                MyFile.Insert(lineNumber, data);
                fs.Position = 0;
                sw.Write(string.Join("\n", MyFile));
            }
        }

        public static void WriteToASpecificLocation(string data, int location)
        {
            using (var fs = new FileStream("TestCursor.txt", FileMode.Open))
            using (var sr = new StreamReader(fs))
            using (var sw = new StreamWriter(fs))
            {
                var MyFile = sr.ReadToEnd();
                var result = MyFile.Insert(location, data);
                fs.Position = 0;
                sw.Write(result);
            }
        }
    }
}
