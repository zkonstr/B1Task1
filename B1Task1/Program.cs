using B1Task1.src;

internal class Program
{
    private static void Main(string[] args)
    {
        TextGenerator generator = new TextGenerator();
        FileManager fileManager = new FileManager();
        String InitialPath = "C:\\Users\\zkons\\Desktop\\B1\\t";
        for (int fileNum = 1; fileNum <= 100; fileNum++)
        {
            var strings = generator.ConcatenateStrings();
            fileManager.CreateFile(InitialPath + fileNum+".txt", strings);
        }
    }
}