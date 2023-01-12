using System.Text;

namespace B1Task1.src
{
    internal class Randomizer
    {
        private readonly Random _random = new();
        public const string EnglishChars = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";
        public const string RussianChars = "АаБбВвГгДдЕеЁёЖжЗзИиЙйКкЛлМмНнОоПпРрСсТтУуФфХхЦцЧчШшЩщЪъЫыЬьЭэЮюЯя";

        public DateTime GenerateRandomDate(DateTime startDate)
        {
            int range = (DateTime.Today - startDate).Days;
            return startDate.AddDays(_random.Next(range));
        }

        public string GenerateRandomChars(string charSet, int length)
        {
            StringBuilder randomChars = new(length);
            for (int i = 0; i < randomChars.Length; i++)
            {
                randomChars[i] = charSet[_random.Next(charSet.Length)];
            }
            return randomChars.ToString();
        }

        public int GenerateRandomInt()
        {
            int n;
            do
            {
                n = _random.Next(1, 100000000);
            }
            while (n % 2 != 0);
            return n;
        }

        public double GenerateRandomRoundedDouble(double max, int round) =>
            Math.Round(_random.NextDouble() * max, round);
    }
}
