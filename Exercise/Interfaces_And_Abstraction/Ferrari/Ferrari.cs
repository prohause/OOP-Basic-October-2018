namespace Ferrari
{
    public class Ferrari : ICar
    {
        public string Driver
        {
            get; set;
        }

        public string Model
        {
            get;
        }

        public Ferrari(string driver)
        {
            Driver = driver;
            Model = "488-Spider";
        }

        public string UseBrakes()
        {
            return "Brakes!";
        }

        public string PushGasPedal()
        {
            return "Zadu6avam sA!";
        }
    }
}