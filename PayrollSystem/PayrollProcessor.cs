namespace PayRollProject
{
    public delegate void SalaryProcessedHandler(PaySlip paySlip);
    public class PayrollProcessor
    {
        public SalaryProcessedHandler? SalaryProcessed;

        public Dictionary<int, PaySlip> ProcessPayroll(List<Employee> employees)
        {
            Dictionary<int, PaySlip> payslips = new Dictionary<int, PaySlip>();
            foreach (Employee emp in employees)
            {
                double net = emp.CalculateSalary();
                PaySlip slip = new PaySlip(emp, net);

                payslips.Add(emp.Id, slip);
                if (SalaryProcessed != null)
                    SalaryProcessed(slip);
            }
            return payslips;
        }
    }
}