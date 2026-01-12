namespace PayRollProject
{
    public class ContractEmployee : Employee
    {
        private int WorkingDays;
        private double DailyRate;

        public ContractEmployee(int id, string name, int workingDays, double dailyRate) : base(id, name, "Contract-Employee")
        {
            WorkingDays = workingDays;
            DailyRate = dailyRate;
        }
        public override double CalculateSalary()
        {
            Gross = WorkingDays * DailyRate;
            Deductions = Gross * 0.10;
            return Gross - Deductions;
        }
    }
}