namespace lab_1.Classes
{
    internal class Warehouse
    {
        private List<StoredProduct> storage = new List<StoredProduct>();

        public float AddItemToStorage(Product product, float amount)
        {
            foreach (StoredProduct storedProduct in storage)
            {
                if (storedProduct.Product.Id == product.Id)
                {
                    storedProduct.LastArrive = DateTime.Now;
                    storedProduct.Amount += amount;

                    return amount;
                }
            }

            storage.Add(new StoredProduct(product, amount, DateTime.Now));

            return amount;
        }

        public bool TakeItemFromStorage(int productID, float amount)
        {
            foreach(StoredProduct storedProduct in storage)
                if (storedProduct.Product.Id == productID)
                {
                    if (storedProduct.Amount < amount)
                        return false;

                    storedProduct.Amount -= amount;

                    return true;
                }

            return false;
        }

        public Product[] GetStoredProduct()
        {
            return storage.Select(item => item.Product).ToArray();
        }

        public Product? GetProduct(int productID)
         {
            foreach (StoredProduct storedProduct in storage)
                if (storedProduct.Product.Id == productID)
                    return storedProduct.Product;

            return null;
         }

        public float GetProductAmount(int id)
        {            
            foreach (StoredProduct storedProduct in storage)
                if (storedProduct.Product.Id == id)
                    return storedProduct.Amount;

            return 0;
        }

        public DateTime? GetLastArrive(int id)
        {
            foreach (StoredProduct storedProduct in storage)
                if (storedProduct.Product.Id == id)
                    return storedProduct.LastArrive;

            return null;
        }
    }
}
