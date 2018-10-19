namespace DefiningClasses
{
    internal class Engine
    {
        private readonly int _engineSpeed;
        private readonly int _enginePower;

        public Engine(int engineSpeed, int enginePower)
        {
            _engineSpeed = engineSpeed;
            _enginePower = enginePower;
        }

        public bool OverPower()
        {
            return _enginePower > 250;
        }
    }
}