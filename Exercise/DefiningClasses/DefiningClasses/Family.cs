using System.Collections.Generic;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> family;

        public void AddMember(Person member)
        {
            family.Add(member);
        }

        public Family()
        {
            family = new List<Person>();
        }
    }
}