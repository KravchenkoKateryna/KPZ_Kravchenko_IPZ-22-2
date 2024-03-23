namespace Builder.Heroes
{
    internal class Hero : Character
    {
        public List<string> GoodTraits = [];

        public new void PrintCharacterInfo()
        {
            Console.WriteLine("================ Information about hero ================ ");
            base.PrintCharacterInfo();
            Console.WriteLine($"Good traits: {string.Join(",", GoodTraits)}");
        }
    }
}