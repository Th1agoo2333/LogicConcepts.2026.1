using OPPconcepts.backend;

try
{

    var employees = new List<Employee>();
    decimal payroll = 0;

    var employee1 = new SalaryEmployee(1010, "John", "Doe", true, new Date(1990, 1, 1), new Date(2020, 1, 1), 2500000);
    employees.Add(employee1);
    var employee2 = new SalaryEmployee(1011, "Jane", "Smith", true, new Date(1992, 2, 2), new Date(2021, 2, 2), 10395836);
    employees.Add(employee2);
    var employee3 = new HourlyEmployee(1012, "Bob", "Johnson", true, new Date(1985, 3, 3), new Date(2019, 3, 3), 18000, 95);
    employees.Add(employee3);
    var employee4 = new HourlyEmployee(1013, "Alice", "Williams", true, new Date(1988, 4, 4), new Date(2018, 4, 4), 10000, 112);
    employees.Add(employee4);

    foreach (var employee in employees)
    {
        Console.WriteLine(employee);
        Console.WriteLine(new string('-', 47));
        payroll += employee.GetValueToPay();
    }
    Console.WriteLine(new string ('=', 47));
    Console.WriteLine($"Payroll................... {payroll,20:c2}");

}

catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

