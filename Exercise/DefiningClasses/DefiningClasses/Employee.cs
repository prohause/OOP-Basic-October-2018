namespace DefiningClasses
{
    internal class Employee
    {
        private readonly string _name;
        private decimal _salary;
        private string _position;
        private string _department;
        private readonly string _email;
        private readonly int _age;

        public Employee(string name, decimal salary, string position, string department, string email, int age)
        {
            _name = name;
            SetSalary(salary);
            _position = position;
            _department = department;
            _email = email;
            _age = age;
        }

        public Employee(string name, decimal salary, string position, string department)
            : this(name, salary, position, department, "n/a", -1)
        {
        }

        public Employee(string name, decimal salary, string position, string department, int age)
        : this(name, salary, position, department, "n/a", age)
        {
        }

        public Employee(string name, decimal salary, string position, string department, string email)
        : this(name, salary, position, department, email, -1)
        {
        }

        public decimal GetSalary()
        {
            return _salary;
        }

        public void SetSalary(decimal value)
        {
            _salary = value;
        }

        public override string ToString()
        {
            return $"{_name} {GetSalary():F2} {_email} {_age}";
        }
    }
}