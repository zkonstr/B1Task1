using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace B1Task1.src
{
    internal class TextGenerator
    {
        StringRandomizer StringRandomizer = new StringRandomizer();
        public string GenerateString()
        {
            var s = StringRandomizer.RandomDate()+"||"+StringRandomizer.RandomEnglishChars() 
                +"||"+ StringRandomizer.RandomRussianChars() + "||"+StringRandomizer.RandomInt()
                +"||"+ StringRandomizer.RandomDouble()+"||";
            return s.ToString();
        }
        public string[] ConcatenateStrings()
        {
            
            List<string> list = new List<string>();
            string s ="";
            for (int strNum = 0; strNum < 100000; strNum++)
            {
                s = GenerateString();
                list.Add(s);
            }
            String[] str = list.ToArray();
            return str;
        }
    }
}
