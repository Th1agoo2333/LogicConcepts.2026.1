
namespace OPPconcepts.backend
{
    public class BaseCommisionEmployee:CommisionEmployee
    {
        //fields
        private decimal _salary;

        //constructors
        public BaseCommisionEmployee(int id, string firstName, string lastName, bool isActive, Date bornDate, Date hireDate, float commisionPercentage, decimal sales, decimal salary) :
            base(id, firstName, lastName, isActive, bornDate, hireDate, commisionPercentage, sales)
        {
            Salary = salary;
        }

        //properties
        public decimal Salary 
        { 
            get => _salary; 
            set => _salary = ValidateSalary (value); 
        }


        //methods

        public override decimal GetValueToPay() => base.GetValueToPay() + Salary;

        public override string ToString() => $"{base.ToString()}\n\tSalary base....... {Salary,20:C2}";

        private decimal ValidateSalary(decimal salary)
        {
            if (salary < 500000)
            {
                throw new ArgumentOutOfRangeException(nameof(salary), salary, "Salary must be greater than or equal to $500,000.");
            }
            return salary;
        }

    }
}
