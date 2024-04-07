namespace Task2Decorator.HeroClasses
{
    public class Paladin : Hero
    {
        public Paladin(string name) : base(name) { }

        public override void Attack()
        {
            Console.WriteLine($"{Name} smites with holy light!");
        }
    }
}
