using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1Task1.src
{
    public class FileManager
    {
        TextGenerator generator = new TextGenerator();
        public void CreateFiles(string path)
        {
            var strings = new string[100000];
            for (int fileNum = 1; fileNum <= 100; fileNum++)
            {
                strings = generator.ConcatenateStrings();
                StreamWriter writer = new StreamWriter(path +"\\t"+ fileNum + ".txt", false);
                foreach(string s in strings)
                {
                    writer.WriteLine(s);
                }
                writer.Close();
            }

        }
        public void DeleteFromFile(string path,string toDelete)
        {
            //foreach(string s in )
        }
        public void ConcatenateFiles(string path,string toDelete)
        {
            string[] filePaths = Directory.GetFiles(path);
            StreamWriter writer = new StreamWriter(path + "\\" + DateTime.Now.Ticks + ".txt");
            foreach (var file in filePaths)
            {
                StreamReader reader = new StreamReader(file);
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains(toDelete))
                    {

                    }
                    else writer.WriteLine(line);
                }
                reader.Close(); 
            }
            writer.Close();
        }
    }
}
