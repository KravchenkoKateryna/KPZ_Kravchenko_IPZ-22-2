namespace Task2Decorator.HeroClasses
{
    public class Mage : Hero
    {
        public Mage(string name) : base(name) { }

        public override void Attack()
        {
            Console.WriteLine($"{Name} casts a spell!");
        }
    }
}
