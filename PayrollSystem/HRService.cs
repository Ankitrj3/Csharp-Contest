using System;
namespace PayRollProject
{
    public class HRService
    {
        public static void Notify(PaySlip slip)
        {
            Console.WriteLine($"[HR NOTIFICATION] Employee {slip.Name} ({slip.Type}) - Salary: ${slip.Net}");
        }
    }
}