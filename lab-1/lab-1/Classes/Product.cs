namespace lab_1.Classes
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Unit {  get; set; }

        private Money _price;

        public Product(string title, string description, Money price, string unit, int id)
        {
            Title = title;
            Description = description;
            _price = price;
            Unit = unit;
            Id = id;
        }

        public string DecreasePrice(Money value)
        {
            if (value > _price)
                return "The value for decrease should be lover than price. Price: " + _price.GetMoneySum();

            _price -= value;

            return "New price: " + _price.GetMoneySum();
        }

        public string IncreasePrice(Money value)
        {
            _price += value;

            return "New price: " + _price.GetMoneySum();
        }
    }
}
