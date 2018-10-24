using System.Text;

namespace P02_CarsSalesman
{
    internal class Engine
    {
        private const string Offset = "  ";

        public string Model;
        public int Power;
        public int Displacement;
        public string Efficiency;

        public Engine(string model, int power) : this(model, power, -1, "n/a")
        {
        }

        public Engine(string model, int power, int displacement) : this(model, power, displacement, "n/a")
        {
        }

        public Engine(string model, int power, string efficiency) : this(model, power, -1, efficiency)
        {
        }

        public Engine(string model, int power, int displacement, string efficiency)
        {
            Model = model;
            Power = power;
            Displacement = displacement;
            Efficiency = efficiency;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}{1}:\n", Offset, Model);
            sb.AppendFormat("{0}{0}Power: {1}\n", Offset, Power);
            sb.AppendFormat("{0}{0}Displacement: {1}\n", Offset, Displacement == -1 ? "n/a" : Displacement.ToString());
            sb.AppendFormat("{0}{0}Efficiency: {1}\n", Offset, Efficiency);

            return sb.ToString();
        }
    }
}