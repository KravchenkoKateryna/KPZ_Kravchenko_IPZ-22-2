using ChainOfResponsibility;

internal class Program
{
    static void Main(string[] args)
    {
        SupportHandler levelOneHandler = new LevelOneHandler();
        SupportHandler levelTwoHandler = new LevelTwoHandler();
        SupportHandler levelThreeHandler = new LevelThreeHandler();
        SupportHandler levelFourHandler = new LevelFourHandler();

        levelOneHandler.SetNextHandler(levelTwoHandler);
        levelTwoHandler.SetNextHandler(levelThreeHandler);
        levelThreeHandler.SetNextHandler(levelFourHandler);

        while (true)
        {
            Console.WriteLine("Please enter the level of support you need (1-4):");
            int level = Convert.ToInt32(Console.ReadLine());
            levelOneHandler.HandleRequest(level);
        }
    }
}