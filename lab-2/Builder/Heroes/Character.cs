namespace Builder.Heroes
{
    class Character
    {
        public string Name { get; set; }

        public uint Height { get; set; }

        public uint Weight { get; set; }

        public string HairColor { get; set; }

        public string SkinColor { get; set; }

        public string Gender { get; set; }

        public void PrintCharacterInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Height: {Height}");
            Console.WriteLine($"Weight: {Weight}");
            Console.WriteLine($"Hair Color: {HairColor}");
            Console.WriteLine($"Skin Color: {SkinColor}");
            Console.WriteLine($"Gender: {Gender}");
        }
    }
}
