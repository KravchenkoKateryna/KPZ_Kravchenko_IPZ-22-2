using Builder.Classes;

namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hero = new HeroBuilder()
                .SetName("George")
                .SetGender("Male")
                .SetSkinColor("White")
                .SetHairColor("Black")
                .SetHeight(185)
                .AddGoodTrait("Honesty")
                .AddGoodTrait("Loyalty")
                .AddGoodTrait("Courage")
                .AddGoodTrait("Kindness")
                .SetWeight(94)
                .Build();

            var enemy = new EnemyBuilder()
                .SetName("Viktor")
                .SetGender("Male")
                .SetSkinColor("Black")
                .SetHairColor("Black")
                .SetHeight(185)
                .SetWeight(88)
                .AddBadTrait("Jealousy")
                .AddBadTrait("Egoism")
                .AddBadTrait("Greed")
                .AddBadTrait("Cruelty")
                .Build();

            hero.PrintCharacterInfo();
            Console.WriteLine(Environment.NewLine);

            enemy.PrintCharacterInfo();
            Console.WriteLine(Environment.NewLine);
        }
    }
}
