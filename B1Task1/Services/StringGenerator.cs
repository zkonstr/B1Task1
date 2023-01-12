namespace B1Task1.src
{
    public class StringGenerator
    {
        private readonly Randomizer _stringRandomizer = new();
        private readonly DateTime _startDate;
        private readonly int _randCharsLength;
        private readonly double _randMaxDouble;
        private readonly int _randRoundDouble;
        public StringGenerator(DateTime startDate, int randCharsLength, double randMaxDouble, int randRoundDouble)
        {
            _startDate = startDate;
            _randCharsLength = randCharsLength;
            _randMaxDouble = randMaxDouble;
            _randRoundDouble = randRoundDouble;
        }

        public string GenerateString() =>
        _stringRandomizer.GenerateRandomDate(_startDate).ToString("dd/MM/yyyy")
                + "||" + _stringRandomizer.GenerateRandomChars(Randomizer.EnglishChars, _randCharsLength)
                + "||" + _stringRandomizer.GenerateRandomChars(Randomizer.RussianChars, _randCharsLength)
                + "||" + _stringRandomizer.GenerateRandomInt()
                + "||" + _stringRandomizer.GenerateRandomRoundedDouble(_randMaxDouble, _randRoundDouble) + "||";

        public string[] ConcatenateStrings(int stringCount)
        {
            List<string> list = new();
            for (int strNum = 0; strNum < stringCount; strNum++)
            {
                list.Add(GenerateString());
            }
            return list.ToArray();
        }
    }
}
