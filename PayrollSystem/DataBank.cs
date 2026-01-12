namespace PayRollProject
{
    public class DataBank
    {
        private static List<Employee> _employees = new();

        public DataBank()
        {
            _employees.Add(new FullTimeEmployee(1, "Amit", 50000));
            _employees.Add(new ContractEmployee(2, "Ravi", 22, 1200));
            _employees.Add(new FullTimeEmployee(3, "Neha", 60000));
            _employees.Add(new ContractEmployee(4, "Ankit", 20, 1000));
            _employees.Add(new FullTimeEmployee(5, "Priya", 55000));
            _employees.Add(new ContractEmployee(6, "Anil", 25, 900));
        }
        public List<Employee> GetAllEmp()
        {
            return _employees;
        }

        public void AddEmp(List<Employee> employees)
        {
            _employees.AddRange(employees);
        }
    }
}