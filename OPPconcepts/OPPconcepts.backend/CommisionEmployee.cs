
namespace OPPconcepts.backend
{
    public class CommisionEmployee : Employee
    {
        //fields
        private float _commisionPercentage;
        private decimal _Sales;


        //constructors
        public CommisionEmployee(int id, string firstName, string lastName, bool isActive, Date bornDate, Date hireDate, float commisionPercentage, decimal sales) :
            base(id, firstName, lastName, isActive, bornDate, hireDate)
        {
            CommisionPercentage = commisionPercentage;
            Sales = sales;
        }

        //properties
        public float CommisionPercentage 
        { 
            get => _commisionPercentage;
            set => _commisionPercentage = ValidateCommisionPercentage(value);
        }
        public decimal Sales 
        { 
            get => _Sales; 
            set => _Sales = ValidateSales (value); 
        }

        //methods
        public override decimal GetValueToPay() => (decimal)CommisionPercentage * Sales;
        

        public override string ToString() => base.ToString() + $"\n\t" +
            $"Commision Percentage{CommisionPercentage,19:p2}\n\t" +
            $"Sales..............{Sales,20:c2}";

        private float ValidateCommisionPercentage(float commisionPercentage)
        {
            if (commisionPercentage < 0 || commisionPercentage > 1)
                throw new ArgumentOutOfRangeException(nameof(commisionPercentage), "Commision percentage must be between 0 and 1");
            return commisionPercentage;
        }
         private decimal ValidateSales(decimal sales)
        {
                if (sales < 0)
                throw new ArgumentOutOfRangeException(nameof(sales), "Sales must be greater than or equal to $0");
                return sales;
        }
    }
}
