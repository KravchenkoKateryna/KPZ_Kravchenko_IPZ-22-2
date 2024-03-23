using Prototype.Classes;

namespace Prototype
{
    class Program
    {
        private static void Main()
        {
            Virus virus = new Virus
            {
                Weight = 45,
                Name = "CoronaVirus",
                Age = 5,
                Childs =
                [
                    new() 
                    {
                        Weight = 26,
                        Name = "CVAncestor1",
                        Age = 4,
                        Childs =
                        [
                            new() 
                            { 
                                Weight = 14, 
                                Name = "CVAncestor11" 
                            },
                            new() {
                                Weight = 23,
                                Name = "CVAncestor12",
                                Age = 3,
                                Childs =
                                [
                                    new Virus
                                    {
                                        Weight = 14,
                                        Name = "CVAncestor121",
                                        Age = 1
                                    }
                                ]
                            }
                        ]
                    },

                    new() 
                    {
                        Weight = 27,
                        Name = "CVAncestor2",
                        Age = 4,
                        Childs =
                        [
                            new Virus 
                            { 
                                Weight = 14, 
                                Name = "CVAncestor22" 
                            }
                        ]
                    }
                ]
            };


            Virus virusCopy = virus.Clone();

            virusCopy.PrintVirusInfo();
        }
    }
}
