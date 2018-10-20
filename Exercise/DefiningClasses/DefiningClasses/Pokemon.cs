namespace DefiningClasses
{
    internal class Pokemon
    {
        private readonly string _name;
        private readonly string _element;
        private int _health;

        public Pokemon(string name, string element, int health)
        {
            _name = name;
            _element = element;
            Health = health;
        }

        public int Health
        {
            get => _health;
            set => _health = value;
        }

        public string GetElement()
        {
            return _element;
        }
    }
}