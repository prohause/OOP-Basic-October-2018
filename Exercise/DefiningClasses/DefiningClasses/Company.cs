namespace DefiningClasses
{
    public class Company
    {
        private readonly string _companyName;
        private readonly string _companyDepartment;
        private readonly double _companySalary;

        public Company(string companyName, string companyDepartment, double companySalary)
        {
            _companyName = companyName;
            _companyDepartment = companyDepartment;
            _companySalary = companySalary;
        }

        public override string ToString()
        {
            return _companyName == null ? "" : $"\n{_companyName} {_companyDepartment} {_companySalary:F2}";
        }
    }
}