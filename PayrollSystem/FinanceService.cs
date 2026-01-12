using System;
namespace PayRollProject
{
    public class FinanceService
    {
        public static void Notify(PaySlip slip)
        {
            Console.WriteLine($"[FINANCE DEPT] Payment of ${slip.Net} processed for Employee #{slip.Id}");
        }
    }
}