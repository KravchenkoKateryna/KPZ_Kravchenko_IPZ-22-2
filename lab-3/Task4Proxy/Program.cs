using Task4Proxy;

class Program
{
    static void Main()
    {
        var smartTextReader = new SmartTextReader();
        var smartTextChecker = new SmartTextChecker();
        var smartTextReaderLocker = new SmartTextReaderLocker(@"\.txt$");

        char[][] content = smartTextReader.ReadFile("example.txt");
        char[][] content1 = smartTextChecker.ReadFile("example.txt");
        char[][] content2 = smartTextReaderLocker.ReadFile("example.txt");
    }
}