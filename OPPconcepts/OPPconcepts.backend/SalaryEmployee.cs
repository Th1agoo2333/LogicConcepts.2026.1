namespace OPPconcepts.backend
{
    public class SalaryEmployee : Employee
    {

        //fields
        private decimal _salary;

        //constructors
        public SalaryEmployee(int id, string firstName, string lastName, bool isActive, Date bornDate, Date hireDate, decimal salary) : 
            base(id, firstName, lastName, isActive, bornDate, hireDate)
        {
            Salary = salary;
        }

        //properties
        public decimal Salary 
        { 
            get => _salary; 
            set => _salary = ValidateSalary(value); 
        }

        //methods
        public override decimal GetValueToPay() => Salary;

        public override string ToString() => base.ToString();

        private decimal ValidateSalary(decimal salary)
        {
            if (salary < 2000000)
                throw new ArgumentOutOfRangeException(nameof(salary), "Salary must be greater tahn or equal to $2,000,000");
            return salary;
        }
    }
}
