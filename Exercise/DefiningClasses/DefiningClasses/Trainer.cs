using System.Collections.Generic;

namespace DefiningClasses
{
    internal class Trainer
    {
        private readonly string _name;
        private int _badges;
        private List<Pokemon> _pokemonList;

        public Trainer(string name)
        {
            _name = name;
            _badges = 0;
            _pokemonList = new List<Pokemon>();
        }

        public int GetBadges()
        {
            return _badges;
        }

        public string GetName()
        {
            return _name;
        }

        public void AddBadge()
        {
            _badges++;
        }

        public void AddPokemon(Pokemon pokemon)
        {
            _pokemonList.Add(pokemon);
        }

        public override string ToString()
        {
            return $"{_name} {_badges} {_pokemonList.Count}";
        }
    }
}