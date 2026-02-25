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
    var employee5 = new CommisionEmployee(1014, "Charlie", "Brown", true, new Date(1995, 5, 5), new Date(2022, 5, 5), 0.03f, 600000000);
    employees.Add(employee5);
    var employee6 = new CommisionEmployee(1015, "Eve", "Davis", true, new Date(1993, 6, 6), new Date(2023, 6, 6), 0.03f, 120000000);
    employees.Add(employee6);
    var employee7 = new BaseCommisionEmployee(1016, "Frank", "Miller", true, new Date(1980, 7, 7), new Date(2017, 7, 7), 0.015f, 250000000, 550000);
    employees.Add(employee7);
    var employee8 = new BaseCommisionEmployee(1017, "Grace", "Wilson", true, new Date(1982, 8, 8), new Date(2016, 8, 8), 0.015f, 0, 550000);
    employees.Add(employee8);

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

