namespace AbstractFactory.Products
{
    abstract class Product(string name, decimal price, string manufacturer)
    {
        public readonly string Name = name;
        public readonly decimal Price = price;
        public readonly string Manufacturer = manufacturer;

        public void GetProductInfo()
        {
            Console.WriteLine($"======== Information about {GetType().Name} {Name} ========");
            Console.WriteLine($"Manufacturer: {Manufacturer}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine(Environment.NewLine);
        }
    }
}