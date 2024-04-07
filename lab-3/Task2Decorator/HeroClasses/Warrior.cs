namespace Task2Decorator.HeroClasses
{
    public class Warrior : Hero
    {
        public Warrior(string name) : base(name) { }

        public override void Attack()
        {
            Console.WriteLine($"{Name} attacks with a sword!");
        }
    }
}
