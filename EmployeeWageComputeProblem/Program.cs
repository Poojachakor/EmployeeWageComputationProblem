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

            empwage.addCompanies("Dmart", 20, 15, 90);

            empwage.addCompanies("Relience", 45, 23, 150);

            empwage.EmpComputation();
            Console.WriteLine("Total wage for Relience company : " + empwage.getTotalwage("Relience"));
            //Console.WriteLine("Total wage for Damart Company : " + empwage.getTotalwage("Dmart"));

        }
    }
}


    
    

