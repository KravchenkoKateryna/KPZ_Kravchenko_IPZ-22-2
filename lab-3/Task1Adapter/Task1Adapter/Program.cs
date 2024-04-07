using Task1Adapter;

internal class Program
{
    private static void Main(string[] args)
    {
        var logger = new Logger();
        logger.Log("Simple test message.");
        logger.Error("Error test message.");
        logger.Warn("Warning test message.");

        var fileLogger = new FileLoggerAdapter("log.txt");
        fileLogger.Log("Simple test message.");
        fileLogger.Error("Error test message.");
        fileLogger.Warn("Warning test message.");
    }
}