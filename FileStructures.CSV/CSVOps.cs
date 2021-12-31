using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace FileStructures.CSV
{
    public class CSVOps
    {
        public static void WriteToAFile()
        {
            StreamWriter sw = File.AppendText("DelimitedFile.csv");

            for (int i = 0; i < 500; i++)
                sw.WriteLine(i + ",");

            sw.Close();
        }

        public static void WriteMultiColumnCSV()
        {
            using(StreamWriter sw = File.AppendText("DelimitedFileWithColumns.csv"))
            {
                sw.WriteLine("i,i * 100,i - 10");
                for (int i = 0; i < 4000; i++)
                    sw.WriteLine(i + "," + (i * 100) + ',' + (i - 10));
            }
        }

        public static void ReadMultiColumnCSV()
        {
            using (StreamReader sr = new StreamReader("DelimitedFileWithColumns.csv"))
            {
                sr.ReadLine();
                while(sr.Peek() != -1)
                { 
                    var line = sr.ReadLine().Split(',');
                }
            }
        }
    }
}
