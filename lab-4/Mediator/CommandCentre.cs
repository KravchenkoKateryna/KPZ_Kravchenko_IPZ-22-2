namespace Mediator
{
    class CommandCentre
    {
        private List<Runway> _runways = new List<Runway>();
        private List<Aircraft> _aircrafts = new List<Aircraft>();

        private Dictionary<Runway, Aircraft> _busyRunways = new Dictionary<Runway, Aircraft>();

        public CommandCentre(Runway[] runways, Aircraft[] aircrafts)
        {
            this._runways.AddRange(runways);
            this._aircrafts.AddRange(aircrafts);

            foreach (Aircraft aircraft in aircrafts)
                aircraft.CommandCentre = this;
        }

        public void RequestLanding(Aircraft aircraft)
        {
            foreach (var runway in _runways)
            {
                // If the runway is not busy, allow the aircraft to land
                if (!_busyRunways.ContainsKey(runway))
                {
                    Console.WriteLine($"Aircraft {aircraft.Name} is landing on runway {runway.Id}.");
                    _busyRunways[runway] = aircraft;
                    runway.HighLightRed();
                    Console.WriteLine($"Aircraft {aircraft.Name} has landed.");
                    return;
                }
            }

            // If all runways are busy, the aircraft cannot land
            Console.WriteLine($"Could not land, all runways are busy.");
        }

        public void RequestTakeOff(Aircraft aircraft)
        {
            foreach (var runway in _runways)
            {
                // If the runway is busy with the current aircraft, allow it to take off
                if (_busyRunways.ContainsKey(runway) && _busyRunways[runway] == aircraft)
                {
                    Console.WriteLine($"Aircraft {aircraft.Name} is taking off from runway {runway.Id}.");
                    runway.HighLightGreen();
                    _busyRunways.Remove(runway);
                    Console.WriteLine($"Aircraft {aircraft.Name} has taken off.");
                    return;
                }
            }

            // If the aircraft is not on any runway, it cannot take off
            Console.WriteLine($"Could not take off, aircraft {aircraft.Name} is not on any runway.");
        }
    }
}
