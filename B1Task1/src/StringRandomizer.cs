using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1Task1.src
{
    internal class StringRandomizer
    {
        private Random random = new Random();

        public string RandomDate()
        {
            DateTime startDate = DateTime.Now.AddYears(-5);
            DateTime date;
            int range = (DateTime.Today - startDate).Days;
            date = startDate.AddDays(random.Next(range));
            string date_str = date.ToString("dd/MM/yyyy");
            return date_str;
        }
        public string RandomEnglishChars()
        {
            const string chars = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";
            return new string(Enumerable.Repeat(chars, 10)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public string RandomRussianChars()
        {
            const string chars = "АаБбВвГгДдЕеЁёЖжЗзИиЙйКкЛлМмНнОоПпРрСсТтУуФфХхЦцЧчШшЩщЪъЫыЬьЭэЮюЯя";
            return new string(Enumerable.Repeat(chars, 10)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        public string RandomInt()
        {
            int n;
            do
            {
                n = random.Next(1, 100000);
            }
            while (n % 2 != 0);
            return n.ToString();
        }
        public string RandomDouble()
        {
            var d = Math.Round(random.NextDouble() + random.Next(1,19), 8);
            return d.ToString();
        }
    }
}
