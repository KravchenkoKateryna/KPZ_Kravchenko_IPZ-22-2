using AbstractFactory.Factories;
using AbstractFactory.Products;

namespace AbstractFactory
{
    class Program
    {
        private static void Main(string[] args)
        {
            TestFactory(new Balaxy());
            TestFactory(new Kiakomi());
            TestFactory(new IProne());
        }

        private static void TestFactory(IManufacture manufacture)
        {
            manufacture.CreateLaptop().GetProductInfo();
            manufacture.CreateEbook().GetProductInfo();
            manufacture.CreateSmartphone().GetProductInfo();
        }
    }
}
