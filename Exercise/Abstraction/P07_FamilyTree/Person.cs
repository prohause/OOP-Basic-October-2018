using System.Collections.Generic;

public class Person
{
    public Person()
    {
        Children = new List<Person>();
        Parents = new List<Person>();
    }

    public string Name
    {
        get;
        set;
    }

    public string Birthday
    {
        get;
        set;
    }

    public List<Person> Parents
    {
        get;
        set;
    }

    public List<Person> Children
    {
        get;
        set;
    }

    public override string ToString()
    {
        return $"{Name} {Birthday}";
    }
}