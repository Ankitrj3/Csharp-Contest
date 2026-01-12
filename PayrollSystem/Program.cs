using PayRollProject;

namespace PayRollProject;

/// <summary>
/// Main Entry point of this project
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        //creating list of Employees : Act as DataBank {HardCoded}
        DataBank emprepo = new DataBank();

        //want to test on these employees as well including the pre-existing data
        List<Employee> employees = new()
        {
            new FullTimeEmployee(7, "Igloo", 50000),
            new ContractEmployee(8, "Kamaljeet", 25, 900)
        };

        emprepo.AddEmp(employees);  //Adding the new list of employees.

        //creating the object of PayrollProcessor class
        PayrollProcessor processor = new PayrollProcessor();

        // Multicast delegate
        processor.SalaryProcessed += HRService.Notify;
        processor.SalaryProcessed += FinanceService.Notify;

        Console.WriteLine("\n--- Processing Payroll ---");

        Dictionary<int, PaySlip> payslips = processor.ProcessPayroll(emprepo.GetAllEmp());

        Console.WriteLine("\n--- Payroll Summary ---");

        //calculating the totalPayout and printing the payslips of employees
        double totalPayout = 0;
        foreach (var slip in payslips.Values)
        {
            Console.WriteLine($"{slip.Id} | {slip.Name} | {slip.Type} | " +
                $"Gross: {slip.Gross} | Deduction: {slip.Deductions} | Net: {slip.Net}");
            totalPayout += slip.Net;
        }

        Console.WriteLine($"\nTotal Employees: {payslips.Count}");
        Console.WriteLine($"Total Payout: {totalPayout}");
    }
}
