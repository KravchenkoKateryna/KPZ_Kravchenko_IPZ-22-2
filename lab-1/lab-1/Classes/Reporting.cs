namespace lab_1.Classes
{
    internal static class Reporting
    {
        public static Action<string> _output;

        public static void ItemIncome(Warehouse warehouse, float amount, Product product)
        {
            var result = warehouse.AddItemToStorage(product, amount);
            string resMsg;
            
            if (result != amount)
                resMsg = $"Amount increased. New amount {amount} {product.Unit}";
            else
                resMsg = $"Item added to storage. Amount: {amount} {product.Unit}";

            _output(resMsg);
        }

        public static void ItemOut(Warehouse warehouses, float amount, int productId)
        {
            string resMsg;
            bool success = warehouses.TakeItemFromStorage(productId, amount);

            var product = warehouses.GetProduct(productId);

            if (product is null)
                resMsg = "There is no this product in warehouse.";

            else if (success)
                resMsg= $"Succesfuly depated {amount} {product.Unit} of {product.Title} from warehouse.";
            else
                resMsg = $"There is no such amount of {product.Title} in warehouse.";

            _output(resMsg);
        }

        public static void GetWarehouseReport(Warehouse warehouse)
        {
            var products = warehouse.GetStoredProduct();

            string result = string.Empty;

            if (products.Length == 0)
                result = "There is no products in storage";
            else 
                foreach (Product storedProduct in products)
                    result += $"{storedProduct.Title} - id: {storedProduct.Id}" + Environment.NewLine +
                        $"Amount: {warehouse.GetProductAmount(storedProduct.Id)} {storedProduct.Unit}" + Environment.NewLine +
                        $"Last arrive: {warehouse.GetLastArrive(storedProduct.Id)}" + Environment.NewLine;

            _output(result);
        }
    }
}
