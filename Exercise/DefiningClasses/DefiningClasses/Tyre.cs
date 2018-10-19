namespace DefiningClasses
{
    internal class Tyre
    {
        private readonly double _tyrePressure;
        private readonly int _tyreAge;

        public Tyre(double tyrePressure, int tyreAge)
        {
            _tyrePressure = tyrePressure;
            _tyreAge = tyreAge;
        }

        public bool UnderInflated()
        {
            return _tyrePressure < 1.0;
        }
    }
}