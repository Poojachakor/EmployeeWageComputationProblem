namespace EmployeeWageComputeProblem
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation.");
            Employee.ComputeEmployeeWage("Relience",20,20,100);
            Employee.ComputeEmployeeWage("Nike", 2000, 22, 176);

        }
    }
}
