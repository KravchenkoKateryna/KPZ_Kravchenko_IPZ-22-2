namespace SimpleHTML.Classes
{
    public abstract class LifecycleHooks
    {
        public virtual void OnCreated()
        {
            Console.WriteLine("Element created.");
        }

        public virtual void OnInserted()
        {
            Console.WriteLine("Element inserted into DOM.");
        }

        public virtual void OnDisplayTypeChanged()
        {
            Console.WriteLine("Element display type changed.");
        }
    }
}
