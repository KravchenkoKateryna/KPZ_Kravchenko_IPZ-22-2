namespace lab_1.Classes
{
    public class StoredProduct
    {
        public Product Product { get; set; }
        public float Amount { get; set; }
        public DateTime LastArrive { get; set; }

        public StoredProduct(Product product, float amount, DateTime lastArrive)
        {
            Product = product;
            Amount = amount;
            LastArrive = lastArrive;
        }
    }
}
