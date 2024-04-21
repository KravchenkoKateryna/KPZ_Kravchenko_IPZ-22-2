namespace ChainOfResponsibility
{
    public class LevelFourHandler : SupportHandler
    {
        public override void HandleRequest(int level)
        {
            if (level == 4)
                Console.WriteLine("Level Four Handler can handle this request.");
            else if (nextHandler != null)
                nextHandler.HandleRequest(level);
            else
                Console.WriteLine("No handler found for this request. Please try again.");
        }
    }
}
