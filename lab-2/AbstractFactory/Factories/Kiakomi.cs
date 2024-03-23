using AbstractFactory.Products;

namespace AbstractFactory.Factories
{
    sealed class Kiakomi : IManufacture
    {
        public EBook CreateEbook()
        {
            return new EBook("K4", 1200, "Kiakomi");
        }
        public Laptop CreateLaptop()
        {
            return new Laptop("Note 1", 5000, "Kiakomi");
        }
        public Smartphone CreateSmartphone()
        {
            return new Smartphone("I4", 800, "Kiakomi");
        }
    }
}
