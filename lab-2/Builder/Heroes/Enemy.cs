namespace Builder.Heroes
{
    internal class Enemy : Character
    {
        public List<string> BadTraits = [];

        public new void PrintCharacterInfo()
        {
            Console.WriteLine("================ Information about enemy ================ ");
            base.PrintCharacterInfo();
            Console.WriteLine($"Bad traits: {string.Join(",", BadTraits)}");
        }
    }
}
