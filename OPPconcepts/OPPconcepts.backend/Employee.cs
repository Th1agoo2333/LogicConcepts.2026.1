
namespace OPPconcepts.backend;

public abstract class Employee
{
       //constructors
    protected Employee(int  id, string firstName, string lastName, bool isActive, Date bornDate, Date hireDate)
       {
        
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        IsActive = isActive;
        BornDate = bornDate;
        HireDate = hireDate;
        
    }

    //properties
    public int Id { get; set;}
    public string FirstName { get; set;} = null!;
    public string LastName { get; set; } = null!;
    public bool IsActive { get; set;}
    public Date BornDate { get; set; } = null!;
    public Date HireDate { get; set; } = null!;

    //methods
    public override string ToString()
    {
        return $"{Id}\t{FirstName}\n\t" +
            $"Value to pay.......{GetValueToPay(),20:c2}";
    }
    
    public abstract decimal GetValueToPay();
}
