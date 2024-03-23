using Builder.Heroes;
using System.Xml.Serialization;

namespace Builder.Classes
{
    class EnemyBuilder
    {
        private Enemy _enemyCharacter = new();

        public void Reset()
        {
            _enemyCharacter = new Enemy();
        }

        public EnemyBuilder SetName (string name)
        {
            _enemyCharacter.Name = name;

            return this;
        }

        public EnemyBuilder SetHeight(uint height)
        {
            _enemyCharacter.Height = height;

            return this;
        }

        public EnemyBuilder SetWeight(uint weight)
        {
            _enemyCharacter.Weight = weight;

            return this;
        }

        public EnemyBuilder SetHairColor(string hairColor)
        {
            _enemyCharacter.HairColor = hairColor;

            return this;
        }

        public EnemyBuilder SetSkinColor(string skinColor)
        {
            _enemyCharacter.SkinColor = skinColor;

            return this;
        }

        public EnemyBuilder SetGender(string gender)
        {
            _enemyCharacter.Gender = gender;

            return this;
        }

        public EnemyBuilder AddBadTrait(string trait)
        {
            _enemyCharacter.BadTraits.Add(trait);

            return this;
        }

        public Enemy Build() => _enemyCharacter;
    }
}
