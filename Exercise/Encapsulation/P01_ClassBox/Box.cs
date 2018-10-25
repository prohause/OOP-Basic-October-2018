using System;

namespace P01_ClassBox
{
    public class Box
    {
        private double _length;
        private double _width;
        private double _height;

        public double Length
        {
            get => _length;

            private set
            {
                CheckValue(value, nameof(Length));

                _length = value;
            }
        }

        private void CheckValue(double value, string side)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"{side} cannot be zero or negative.");
            }
        }

        public double Width
        {
            get => _width;
            private set
            {
                CheckValue(value, nameof(Width));

                _width = value;
            }
        }

        public double Height
        {
            get => _height;
            set
            {
                CheckValue(value, nameof(Height));
                _height = value;
            }
        }

        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double CalculateSurfaceArea()
        {
            return 2 * Length * Width + 2 * Width * Height + 2 * Length * Height;
        }

        public override string ToString()
        {
            return $"Surface Area - {CalculateSurfaceArea():F2}" +
                   $"\nLateral Surface Area - {CalculateLateralArea():F2}" +
                   $"\nVolume - {CalculateVolume():F2}";
        }

        private double CalculateVolume()
        {
            return Length * Width * Height;
        }

        private double CalculateLateralArea()
        {
            return (2 * Length + 2 * Width) * Height;
        }
    }
}