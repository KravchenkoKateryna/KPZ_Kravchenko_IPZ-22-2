using AbstractFactory.Products;

namespace AbstractFactory.Factories
{
    internal class Balaxy : IManufacture
    {
        public EBook CreateEbook()
        {
            return new EBook("EBook 10", 1800, "Balaxy");
        }
        public Laptop CreateLaptop()
        {
            return new Laptop("Lap 4", 4500, "Balaxy");
        }
        public Smartphone CreateSmartphone()
        {
            return new Smartphone("S45 Max", 900, "Balaxy");
        }
    }
}