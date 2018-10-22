namespace DefiningClasses
{
    public class Car
    {
        private readonly string _carModel;
        private readonly int _carSpeed;

        public Car(string carModel, int carSpeed)
        {
            _carModel = carModel;
            _carSpeed = carSpeed;
        }

        public override string ToString()
        {
            return _carModel == null ? "" : $"\n{_carModel} {_carSpeed}";
        }
    }
}