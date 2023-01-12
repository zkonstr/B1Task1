namespace B1Task1.src
{
    public class FileService
    {
        private readonly StringGenerator _generator;

        public FileService(StringGenerator generator)
        {
            _generator = generator;
        }

        public void CreateFiles(string path, int filesCounts, int stringsCount)
        {
            for (int fileNum = 1; fileNum <= filesCounts; fileNum++)
            {
                var strings = _generator.ConcatenateStrings(stringsCount);
                StreamWriter writer = new(path + "\\t" + fileNum + ".txt", false);
                foreach (var s in strings)
                {
                    writer.WriteLine(s);
                }
                writer.Close();
            }
        }

        public static int MergeFiles(string path, string toDelete)
        {
            string[] filePaths = Directory.GetFiles(path);
            StreamWriter writer = new(path + "\\" + DateTime.Now.Ticks + ".txt");
            int deleteCounter = 0;
            foreach (var file in filePaths)
            {
                StreamReader reader = new(file);
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains(toDelete))
                        deleteCounter++;
                    else
                        writer.WriteLine(line);
                }
                reader.Close();
            }
            writer.Close();
            return deleteCounter;
        }
    }
}
