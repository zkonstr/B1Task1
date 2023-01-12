using B1Task1.src;
internal class Program
{
    private static void Main(string[] args)
    {
        const string InitialPath = "C:\\Users\\zkons\\Desktop\\B1";
        const int FilesCounts = 100;
        const int StringsCount = 100000;

        StringGenerator stringGenerator = new(DateTime.Today.AddYears(-5), 10, 20, 8);
        FileService fileManager = new(stringGenerator);

        Console.WriteLine("choose operation - 0 for create new files, 1 for concatenate them");
        int operation = Convert.ToInt32(Console.ReadLine());
        switch (operation)
        {
            case 0:
                fileManager.CreateFiles(InitialPath, FilesCounts, StringsCount);
                break;
            case 1:
                Console.WriteLine("input the sequence that should to be deleted");
                var toDelete = Console.ReadLine() ?? "";
                var deletedCount = FileService.MergeFiles(InitialPath, toDelete);
                Console.WriteLine("strings deleted: " + deletedCount);
                break;
            default:
                Console.WriteLine("there are only 2 operations");
                break;
        }
    }
}