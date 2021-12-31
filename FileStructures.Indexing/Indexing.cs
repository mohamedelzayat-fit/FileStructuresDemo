using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStructures.Indexing
{
    public class Indexing
    {
        public static string FindName(string name)
        {
            var foundFile = "";

            using(var fs = new FileStream("IndexDemo/Index.txt", FileMode.Open, FileAccess.Read))
            using(var sr = new StreamReader(fs))
            {
                var result = sr.ReadToEnd().Split('\n').ToList();

                var firstLetter = name.ToLower()[0];

                var line = result.Where(item => firstLetter == item[0]).FirstOrDefault();

                var index = line.Split('=').ToList()[1].Trim();
                foundFile = "IndexDemo/Data/" + index + ".txt";
            }

            using (var fs = new FileStream(foundFile, FileMode.Open, FileAccess.Read))
            using (var sr = new StreamReader(fs))
            {
                while (sr.Peek() != -1)
                {
                    var item = sr.ReadLine();
                    if(item.Split(' ').ToList()[0] == name)
                    {
                        return item;
                    }
                }
            }
            return "";
        }
    }
}
