using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1Task1.src
{
    internal class FileManager
    {
        public void CreateFile(string path, string[] strings)
        {
            StreamWriter writer = new StreamWriter(path, false);
            foreach(string s in strings)
            {
                writer.WriteLine(s);
            }
            writer.Close();
        }
        public void DeleteFile(string path) { }
    }
}
