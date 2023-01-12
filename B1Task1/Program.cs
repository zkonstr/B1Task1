using B1Task1.src;
internal class Program
{
    private static void Main(string[] args)
    {
        TextGenerator generator = new TextGenerator();
        FileManager fileManager = new FileManager();
        String InitialPath = "C:\\Users\\zkons\\Desktop\\B1";
        int operation =0;
        Console.WriteLine("choose operation - 0 for create new files, 1 for concatenate them");
        operation = Convert.ToInt32(Console.ReadLine());
        switch (operation)
        {
            case 0: 
                fileManager.CreateFiles(InitialPath);
                break;
            case 1:
                //Console.WriteLine();
                //Console.ReadLine();
                fileManager.ConcatenateFiles(InitialPath);
                break;
            default: 
                Console.WriteLine("there are only 2 operations");
                break;
        } 
    }
}