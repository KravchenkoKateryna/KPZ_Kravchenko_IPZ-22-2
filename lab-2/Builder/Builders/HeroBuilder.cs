using Builder.Heroes;


namespace Builder.Classes
{
    class HeroBuilder
    {
        private Hero _heroCharacter = new();

        public void Reset()
        {
            _heroCharacter = new Hero();
        }

        public HeroBuilder SetName(string name)
        {
            _heroCharacter.Name = name;

            return this;
        }

        public HeroBuilder SetHeight(uint height)
        {
            _heroCharacter.Height = height;

            return this;
        }

        public HeroBuilder SetWeight(uint weight)
        {
            _heroCharacter.Weight = weight;

            return this;
        }

        public HeroBuilder SetHairColor(string hairColor)
        {
            _heroCharacter.HairColor = hairColor;

            return this;
        }

        public HeroBuilder SetSkinColor(string skinColor)
        {
            _heroCharacter.SkinColor = skinColor;

            return this;
        }

        public HeroBuilder SetGender(string gender)
        {
            _heroCharacter.Gender = gender;

            return this;
        }

        public HeroBuilder AddGoodTrait(string trait)
        {
            _heroCharacter.GoodTraits.Add(trait);

            return this;
        }

        public Hero Build() => _heroCharacter;
    }
}