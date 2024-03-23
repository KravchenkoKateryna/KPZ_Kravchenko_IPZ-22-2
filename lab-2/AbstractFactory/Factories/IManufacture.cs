using AbstractFactory.Products;

namespace AbstractFactory.Factories
{
    interface IManufacture
    {
        EBook CreateEbook();

        Laptop CreateLaptop();

        Smartphone CreateSmartphone();
    }
}