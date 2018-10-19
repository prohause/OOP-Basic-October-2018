namespace DefiningClasses
{
    internal class Cargo
    {
        private readonly int _cargoWeight;
        private readonly string _cargoType;

        public Cargo(int cargoWeight, string cargoType)
        {
            _cargoWeight = cargoWeight;
            _cargoType = cargoType;
        }

        public string GetCargoType()
        {
            return _cargoType;
        }
    }
}