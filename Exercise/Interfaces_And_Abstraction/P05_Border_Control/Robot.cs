namespace P05_Border_Control
{
    public class Robot : IRobot, IIdable
    {
        public string Model
        {
            get; set;
        }

        public string Id
        {
            get; set;
        }

        public Robot(string model, string id)
        {
            Model = model;
            Id = id;
        }
    }
}