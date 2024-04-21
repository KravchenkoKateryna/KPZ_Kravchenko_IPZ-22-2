namespace ChainOfResponsibility
{
    public class LevelThreeHandler : SupportHandler
    {
        public override void HandleRequest(int level)
        {
            if (level == 3)
                Console.WriteLine("Level Three Handler can handle this request.");
            else if (nextHandler != null)
                nextHandler.HandleRequest(level);
        }
    }
}
