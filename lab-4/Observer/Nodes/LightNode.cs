namespace Observer
{
    public abstract class LightNode
    {
        public abstract string OuterHTML { get; }
        public abstract string InnerHTML { get; }

        public Dictionary<string, EventListener> EventListeners = new Dictionary<string, EventListener>();

        public void AddEventListener(string eventName, Action<string> callback)
        {
            EventListeners[eventName] = new EventListener(callback);
        }

        public void TriggerEvent(string eventName, string eventData)
        {
            if (EventListeners.ContainsKey(eventName))
            {
                EventListeners[eventName].EventCallback.Invoke(eventData);
            }
        }
    }
}
