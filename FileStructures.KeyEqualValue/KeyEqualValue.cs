using System.Collections.Generic;
using System.IO;
using FileStructures.Core;

namespace FileStructures.KeyEqualValue
{
    public class KeyEqualValue
    {
        public static void WriteToAFile(Student student)
        {
            using(var fs = new FileStream("KeyEqualValue.txt", FileMode.OpenOrCreate))
            using(var sw = new StreamWriter(fs))
            {
                sw.WriteLine($"Id = {student.Id}");
                sw.WriteLine($"Name = {student.Name}");
            }
        }

        public static string ReadFromAFile()
        {
            using (var fs = new FileStream("KeyEqualValue.txt", FileMode.OpenOrCreate))
            using (var sr = new StreamReader(fs))
            {
                return sr.ReadToEnd();
            }
        }

        public static List<Student> ReadFromAFileStd()
        {
            var lst = new List<Student>();
            using (var fs = new FileStream("KeyEqualValue.txt", FileMode.OpenOrCreate))
            using (var sr = new StreamReader(fs))
            {
                while (sr.Peek() != -1)
                {
                    var indexNumberLine = sr.ReadLine();
                    var resultIndex = indexNumberLine.Split('=');

                    var studentNameLine = sr.ReadLine();
                    var resultName = studentNameLine.Split('=');

                    lst.Add(new Student() { Id = int.Parse(resultIndex[1]), Name = resultName[1] });
                }
            }

            return lst;
        }
        
    }
}
