namespace DefiningClasses
{
    internal class Car
    {
        private readonly string _model;
        private readonly Engine _engine;
        private readonly int? _weight;
        private readonly string _color;

        public Car(string model, Engine engine, int? weight, string color)
        {
            _model = model;
            _engine = engine;
            _weight = weight;
            _color = color;
        }

        public Car(string model, Engine engine, int? weight) : this(model, engine, weight, null)
        {
        }

        public Car(string model, Engine engine, string color) : this(model, engine, null, color)
        {
        }

        public Car(string model, Engine engine) : this(model, engine, null, null)
        {
        }

        public override string ToString()
        {
            var weight = _weight == null ? "n/a" : _weight.ToString();
            var color = _color ?? "n/a";
            return $"{_model}:\n{_engine}\n  Weight: {weight}\n  Color: {color}";
        }
    }
}