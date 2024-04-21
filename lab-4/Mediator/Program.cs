using Mediator;

internal class Program
{
    static void Main(string[] args)
    {
        Runway runway1 = new Runway();
        Runway runway2 = new Runway();
        Runway[] runways = { runway1, runway2 };

        Aircraft aircraft1 = new Aircraft("Aircraft1");
        Aircraft aircraft2 = new Aircraft("Aircraft2");
        Aircraft[] aircrafts = { aircraft1, aircraft2 };


        CommandCentre commandCentre = new CommandCentre(runways, aircrafts);

        // Request landing and takeoff
        aircraft1.Land();
        aircraft2.Land();
        aircraft1.TakeOff();
        aircraft2.TakeOff();
    }
}