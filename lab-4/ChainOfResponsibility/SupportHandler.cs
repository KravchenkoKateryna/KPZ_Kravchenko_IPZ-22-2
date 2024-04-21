namespace ChainOfResponsibility
{
    public abstract class SupportHandler
    {
        protected SupportHandler nextHandler;

        public void SetNextHandler(SupportHandler nextHandler)
        {
            this.nextHandler = nextHandler;
        }

        public abstract void HandleRequest(int level);
    }
}
