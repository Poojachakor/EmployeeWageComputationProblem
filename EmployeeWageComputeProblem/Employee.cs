using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputeProblem
{
    internal class Employee
    {
        public const int isFullTime = 1;
        public const int isPartTime = 2;

        public static void ComputeEmployeeWage(string company, int empWagePerHour, int numOfWorkingDays, int maxHrsInMonth)
        {
            int empHrs = 0;
            int totalEmpHrs = 0;
            int totalEmpWage = 0;
            int totalWorkingDays = 0;

            while (totalEmpHrs <= maxHrsInMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case isFullTime:
                        empHrs = 8;
                        break;
                    case isPartTime:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                int empWage = empHrs * empWagePerHour;
                Console.WriteLine("Day is : " + totalWorkingDays + " ,working hours is " + empHrs + " wage for the day is : " + empWage);
            }
            totalEmpWage = totalEmpHrs * empWagePerHour;
            Console.WriteLine("Total Employee Wage for company " + company + " is " + totalEmpWage);
        }
    }
}
    

