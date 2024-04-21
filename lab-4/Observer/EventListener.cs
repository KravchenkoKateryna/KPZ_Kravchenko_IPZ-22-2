namespace Observer
{
    public class EventListener
    {
        public Action<string> EventCallback { get; }

        public EventListener(Action<string> callback)
        {
            EventCallback = callback;
        }
    }
}
