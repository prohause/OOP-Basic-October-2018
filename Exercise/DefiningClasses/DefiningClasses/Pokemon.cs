namespace DefiningClasses
{
    public class Pokemon
    {
        private readonly string _pokemonName;
        private readonly string _pokemonType;

        public Pokemon(string pokemonName, string pokemonType)
        {
            _pokemonName = pokemonName;
            _pokemonType = pokemonType;
        }

        public override string ToString()
        {
            return $"{_pokemonName} {_pokemonType}";
        }
    }
}