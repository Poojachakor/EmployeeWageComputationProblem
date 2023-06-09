using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputeProblem
{
    internal class Employee
    {
        const int WagePerHour = 20, FullDayHour = 8, PartTimeHour = 4, FullTime = 0, PartTime = 1, Absent = 2,
            TotalWorkingDays = 20, TotalWorkingHours = 100;
        public void DailyWage()
        {
            int wage = 0, totalworkdays = 0, totalworkhours = 0;
            while (totalworkhours <= TotalWorkingHours && totalworkdays < TotalWorkingDays)
            {
                totalworkdays++;
                Random random = new Random();
                int wages = random.Next(0, 3);
                switch (wages)
                {
                    case FullTime:
                        wage = FullDayHour;
                        break;
                    case PartTime:
                        wage = PartTimeHour;
                        break;
                    case Absent:
                        wage = 0;
                        break;
                }
                //int result = wage * WagePerHour;
                totalworkhours += wage;
                Console.WriteLine("Day " + totalworkdays + "====> EmpHrs: " + wage);
            }
            Console.WriteLine("Total working Hours = " + totalworkhours);
            Console.WriteLine("Total working Days = " + totalworkdays);
            int totalEmpWage = totalworkhours * WagePerHour;
            Console.WriteLine("Employee Wage is = {0}", totalEmpWage);
        }
    }
}
    

