namespace DefiningClasses
{
    internal class Engine
    {
        private readonly string _model;
        private readonly int _power;
        private readonly int? _displacement;
        private readonly string _efficiency;

        public Engine(string model, int power, int? displacement, string efficiency)
        {
            _model = model;
            _power = power;
            _displacement = displacement;
            _efficiency = efficiency;
        }

        public Engine(string model, int power, int displacement) : this(model, power, displacement, null)
        {
        }

        public Engine(string model, int power, string efficiency) : this(model, power, null, efficiency)
        {
        }

        public Engine(string model, int power) : this(model, power, null, null)
        {
        }

        public string GetModel()
        {
            return _model;
        }

        public override string ToString()
        {
            var displ = _displacement == null ? "n/a" : _displacement.ToString();
            var effic = _efficiency ?? "n/a";
            return $"  {_model}:\n    Power: {_power}\n    Displacement: {displ}" +
                   $"\n    Efficiency: {effic}";
        }
    }
}