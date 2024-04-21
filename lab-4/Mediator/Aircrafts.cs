namespace Mediator
{
    class Aircraft
    {

        public string Name { get; set; }
        public bool IsTakingOff { get; set; }
        public CommandCentre CommandCentre;

        public Aircraft(string name)
        {
            this.Name = name;
        }

        public void Land()
        {
            CommandCentre.RequestLanding(this);
        }

        public void TakeOff()
        {
            CommandCentre.RequestTakeOff(this);
        }
    }
}
