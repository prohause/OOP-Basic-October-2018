using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {
        private List<Person> family;

        public void AddMember(Person member)
        {
            family.Add(member);
        }

        public Person GetOldestMember()
        {
            return family.OrderByDescending(p => p.Age).First();
        }

        public Family()
        {
            family = new List<Person>();
        }
    }
}