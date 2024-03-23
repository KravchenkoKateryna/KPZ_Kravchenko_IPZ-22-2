namespace AbstractFactory.Products
{
    sealed class EBook(string name, decimal price, string manufacturer) : Product(name, price, manufacturer)
    {
    }
}