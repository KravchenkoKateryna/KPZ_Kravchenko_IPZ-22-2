using lab_1.Classes;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {

            List<Product> products = new List<Product>
            {
            new Product("TV", "Samsung TV 21 inch.", new Money(3000, 45), "pts", 1),
            new Product("Rice", "Long rice", new Money(10, 45), "kg", 2)
            };

            Console.WriteLine(products[0].IncreasePrice(new Money(300, 15)));
            Console.WriteLine(products[0].DecreasePrice(new Money(100, 0)));
            Console.WriteLine(products[0].DecreasePrice(new Money(10000, 0)));

            Warehouse warehouse = new Warehouse();

            Reporting._output = PrintResult;

            Reporting.GetWarehouseReport(warehouse);
            Reporting.ItemIncome(warehouse, 5, products[0]);
            Reporting.ItemIncome(warehouse, (float)4.3, products[1]);
            Reporting.GetWarehouseReport(warehouse);
            Reporting.ItemOut(warehouse, 1, 1);
            Reporting.GetWarehouseReport(warehouse);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static void PrintResult(string message)
    {
        Console.WriteLine(message);
    }
}