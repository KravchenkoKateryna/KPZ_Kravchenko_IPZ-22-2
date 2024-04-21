namespace Observer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var button = new LightElementNode("button", "inline", false);
            button.AddChild(new LightTextNode("Click me!"));

            button.AddEventListener("click", eventData =>
            {
                Console.WriteLine($"Button clicked! Event data: {eventData}");
            });

            Console.WriteLine(button.OuterHTML);
            button.TriggerEvent("click", "Button clicked from code!");
        }
    }
}