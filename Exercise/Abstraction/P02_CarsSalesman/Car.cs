using System.Text;

namespace P02_CarsSalesman
{
    internal class Car
    {
        private const string Offset = "  ";

        public string Model;
        public Engine Engine;
        public int Weight;
        public string Color;

        public Car(string model, Engine engine) : this(model, engine, -1, "n/a")
        {
        }

        public Car(string model, Engine engine, int weight) : this(model, engine, weight, "n/a")
        {
        }

        public Car(string model, Engine engine, string color) : this(model, engine, -1, color)
        {
        }

        public Car(string model, Engine engine, int weight, string color)
        {
            Model = model;
            Engine = engine;
            Weight = weight;
            Color = color;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}:\n", Model);
            sb.Append(Engine);
            sb.AppendFormat("{0}Weight: {1}\n", Offset, Weight == -1 ? "n/a" : Weight.ToString());
            sb.AppendFormat("{0}Color: {1}", Offset, Color);

            return sb.ToString();
        }
    }
}