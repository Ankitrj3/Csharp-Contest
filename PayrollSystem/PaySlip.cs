namespace PayRollProject
{
    public class PaySlip
    {
        public int Id{get; set;}
        public string Name{get; set;}
        public string Type{get; set;}
        public double Gross{get; set;}
        public double Deductions{get; set;}
        public double Net{get; set;}

        public PaySlip(Employee emp, double net)
        {
            this.Id = emp.Id;
            this.Name = emp.Name;
            this.Type = emp.Type;
            this.Gross = emp.GetGross();
            this.Deductions = emp.GetDeduction();
            this.Net = net;
        }
    }
}