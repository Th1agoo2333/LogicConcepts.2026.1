using OPPconcepts.backend;

try
{
    var employee1 = new SalaryEmployee(1010, "John", "Doe", true, new Date(1990, 1, 1), new Date(2020, 1, 1), 2500000);
    var employee2 = new SalaryEmployee(1011, "Jane", "Smith", true, new Date(1992, 2, 2), new Date(2021, 2, 2), 10395836);
    Console.WriteLine(employee1);
    Console.WriteLine(employee2);
}

catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}

