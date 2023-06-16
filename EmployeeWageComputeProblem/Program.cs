namespace EmployeeWageComputeProblem
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation.");
            //Employee employee = new Employee();
            //employee.DailyWage();
            //Console.WriteLine("Welcome to Employee Wage Computation.");
            //Employee.ComputeEmployeeWage("Relience", 20, 20, 100);
            //Employee.ComputeEmployeeWage("Nike", 2000, 22, 176);


            EmployeeWage empwage = new EmployeeWage();

            empwage.Employee("Dmart", 20, 15, 80);
            Console.WriteLine("------------------------------");
            empwage.Employee("Relience", 25, 10, 60);
        }

    }
    
}
