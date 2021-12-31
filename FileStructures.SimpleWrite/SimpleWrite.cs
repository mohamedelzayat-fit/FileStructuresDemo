using System.IO;

namespace FileStructures.SimpleWrite
{
    public class SimpleWrite
    {
        public static void WriteToAFile(string content)
        {
            using (var fs = new FileStream("SimpleWrite.txt",FileMode.OpenOrCreate))
            {
                using(var sw = new StreamWriter(fs))
                {
                    sw.WriteLine(content + " new");
                    sw.WriteLine(content + " new");
                    sw.WriteLine(content + " new");
                    sw.WriteLine(content + " new");
                    sw.WriteLine(content + " new");
                }
            }
        }

        public static string ReadFromFile()
        {
            using (var fs = new FileStream("SimpleWrite.txt", FileMode.OpenOrCreate))
            {
                using (var sr = new StreamReader(fs))
                {
                    return sr.ReadToEnd();
                }
            }
        }
    }
}
