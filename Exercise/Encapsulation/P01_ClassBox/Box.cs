namespace P01_ClassBox
{
    public class Box
    {
        public double Length
        {
            get;
        }

        public double Width
        {
            get;
        }

        public double Height
        {
            get;
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