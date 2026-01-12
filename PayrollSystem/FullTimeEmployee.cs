namespace PayRollProject
{
    public class FullTimeEmployee : Employee
    {
        private double MonthlySalary;
        public FullTimeEmployee(int id, string name, double salary) : base(id, name, "Full-Time-Employee")
        {
            if(salary <= 0)
            {
                throw new Exception("Invalid salary amount");
            }
            this.MonthlySalary = salary;
        }
        public override double CalculateSalary()
        {
            this.Gross = MonthlySalary;
            this.Deductions = Gross * 0.10; // 10% deduction
            return Gross - Deductions;
        }
    }
}