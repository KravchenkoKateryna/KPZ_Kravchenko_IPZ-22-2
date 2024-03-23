using System.Data;

namespace Prototype.Classes
{
    internal class Virus
    {
        public uint Weight;
        public uint Age;
        public string Name;

        public List<Virus> Childs = [];

        public Virus Clone()
        {
            Virus virusClone = new();
            virusClone.Weight = Weight;
            virusClone.Age = Age;
            virusClone.Name = Name;
            virusClone.Childs.AddRange(Childs);

            return virusClone;
        }

        public void PrintVirusInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Weight: {Weight}");

            foreach (var child in Childs)
                child.PrintVirusInfo();
        }
    }
}
