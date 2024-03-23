using AbstractFactory.Products;

namespace AbstractFactory.Factories
{
    internal class IProne : IManufacture
    {
        public EBook CreateEbook()
        {
            return new EBook("IPad 4", 3500, "IProne");
        }
        public Laptop CreateLaptop()
        {
            return new Laptop("Mac", 7000, "IProne");
        }
        public Smartphone CreateSmartphone()
        {
            return new Smartphone("11 Pro", 1500, "IProne");
        }
    }
}
