namespace AbstractFactory.Products
{
    sealed class Smartphone(string name, decimal price, string manufacturer) : Product(name, price, manufacturer)
    {
    }
}