namespace PayRollProject
{
    public abstract class Employee
    {
        public int Id{get; set;}
        public string Name{get; set;}
        public string Type{get; set;}

        protected double Gross;
        protected double Deductions;
        public Employee(int id, string name, string type)
        {
            this.Id = id;
            this.Name = name;
            this.Type = type;
        }
        public abstract double CalculateSalary();
        public double GetGross()
        {
            return this.Gross;
        }
        public double GetDeduction()
        {
            return this.Deductions;
        }
    }
}