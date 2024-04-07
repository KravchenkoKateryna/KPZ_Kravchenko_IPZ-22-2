namespace Task2Decorator
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public Inventory Inventory { get; set; }

        protected Hero(string name)
        {
            Name = name;
            Inventory = new Inventory();
        }

        public abstract void Attack();
    }
}
