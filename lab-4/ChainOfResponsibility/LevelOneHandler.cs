namespace ChainOfResponsibility
{
    public class LevelOneHandler : SupportHandler
    {
        public override void HandleRequest(int level)
        {
            if (level == 1)
                Console.WriteLine("Level One Handler can handle this request.");
            else if (nextHandler != null)
                nextHandler.HandleRequest(level);
        }
    }
}
