namespace Mediator
{
    class Runway
    {
        public readonly Guid Id = Guid.NewGuid();
        public bool IsBusyWithAircraft { get; set; } = false;

        public void HighLightRed()
        {
            Console.WriteLine($"Runway {this.Id} is busy!");
        }

        public void HighLightGreen()
        {
            Console.WriteLine($"Runway {this.Id} is free!");
        }
    }
}
