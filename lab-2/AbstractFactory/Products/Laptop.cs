namespace AbstractFactory.Products
{
    sealed class Laptop(string name, decimal price, string manufacturer) : Product(name, price, manufacturer)
    {
    }
}