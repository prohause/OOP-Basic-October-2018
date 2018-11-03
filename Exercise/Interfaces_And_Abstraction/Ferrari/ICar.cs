namespace Ferrari
{
    public interface ICar
    {
        string Driver
        {
            get; set;
        }

        string Model
        {
            get;
        }

        string UseBrakes();

        string PushGasPedal();
    }
}