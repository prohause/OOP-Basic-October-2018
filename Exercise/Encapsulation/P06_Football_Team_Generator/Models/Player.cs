using System;

namespace P06_Football_Team_Generator.Models
{
    internal class Player
    {
        private string _name;
        private int _endurance;
        private int _sprint;
        private int _dribble;
        private int _passing;
        private int _shooting;

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

        private int Endurance
        {
            get => _endurance;
            set
            {
                if (IsNotValid(value))
                {
                    Print(nameof(Endurance));
                }

                _endurance = value;
            }
        }

        private int Sprint
        {
            get => _sprint;
            set
            {
                if (IsNotValid(value))
                {
                    Print(nameof(Sprint));
                }

                _sprint = value;
            }
        }

        private int Dribble
        {
            get => _dribble;
            set
            {
                if (IsNotValid(value))
                {
                    Print(nameof(Dribble));
                }

                _dribble = value;
            }
        }

        private int Passing
        {
            get => _passing;
            set
            {
                if (IsNotValid(value))
                {
                    Print(nameof(Passing));
                }
                _passing = value;
            }
        }

        private int Shooting
        {
            get => _shooting;
            set
            {
                if (IsNotValid(value))
                {
                    Print(nameof(Shooting));
                }
                _shooting = value;
            }
        }

        private static void Print(string stat)
        {
            throw new ArgumentException($"{stat} should be between 0 and 100.");
        }

        private bool IsNotValid(int value)
        {
            return value < 0 || value > 100;
        }

        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            Name = name;
            Endurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
        }

        public double Stats()
        {
            var stats = (Endurance + Sprint + Dribble + Passing + Shooting) / 5.0;
            return stats;
        }
    }
}