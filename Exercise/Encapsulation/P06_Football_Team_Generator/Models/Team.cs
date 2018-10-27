using System;
using System.Collections.Generic;
using System.Linq;

namespace P06_Football_Team_Generator.Models
{
    internal class Team
    {
        private string _name;
        private readonly List<Player> _players;

        public string Name
        {
            get => _name;
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }

                _name = value;
            }
        }

        public Team(string name)
        {
            Name = name;
            _players = new List<Player>();
        }

        private double Rating()
        {
            if (_players.Any())
            {
                return _players.Average(p => p.Stats());
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return $"{Name} - {Rating():F0}";
        }

        public void AddPlayer(Player player)
        {
            _players.Add(player);
        }

        public void RemovePlayer(string name)
        {
            if (_players.All(p => p.Name != name))
            {
                throw new ArgumentException($"Player {name} is not in {Name} team.");
            }

            var player = _players.First(p => p.Name == name);
            _players.Remove(player);
        }
    }
}