namespace ChainOfResponsibility
{
    public class LevelTwoHandler : SupportHandler
    {
        public override void HandleRequest(int level)
        {
            if (level == 2)
                Console.WriteLine("Level Two Handler can handle this request.");
            else if (nextHandler != null)
                nextHandler.HandleRequest(level);
        }
    }
}
