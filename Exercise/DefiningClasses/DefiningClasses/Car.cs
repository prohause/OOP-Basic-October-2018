using System.Collections.Generic;

namespace DefiningClasses
{
    internal class Car
    {
        private string _model;
        private Engine _engine;
        private Cargo _cargo;
        private List<Tyre> _tyres;

        public string Model
        {
            get => _model;
            set => _model = value;
        }

        public Engine Engine1
        {
            get => _engine;
            set => _engine = value;
        }

        public Cargo Cargo1
        {
            get => _cargo;
            set => _cargo = value;
        }

        public List<Tyre> Tyres
        {
            get => _tyres;
            set => _tyres = value;
        }

        public Car(string model, Engine engine, Cargo cargo, List<Tyre> tyres)
        {
            Model = model;
            Engine1 = engine;
            Cargo1 = cargo;
            Tyres = tyres;
        }

        public override string ToString()
        {
            return Model;
        }
    }
}