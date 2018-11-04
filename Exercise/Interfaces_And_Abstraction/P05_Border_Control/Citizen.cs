namespace P05_Border_Control
{
    internal class Citizen : ICitizen, IIdable
    {
        public string Name
        {
            get; set;
        }

        public int Age
        {
            get; set;
        }

        public string Id
        {
            get; set;
        }

        public Citizen(string name, int age, string id)
        {
            Name = name;
            Age = age;
            Id = id;
        }
    }
}