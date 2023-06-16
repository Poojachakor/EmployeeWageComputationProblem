using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputeProblem
{
    public class EmployeeWage
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private CompanyEmployeeWage[] CompanywageArr;
        private int noOfCompany = 0;
        public EmployeeWage()
        {
            this.CompanywageArr = new CompanyEmployeeWage[5];
        }
        public void addCompanies(string company, int Wage_Per_Hour, int Max_Days_IN_Month, int Max_HrsInMonth)
        {
            CompanywageArr[noOfCompany] = new CompanyEmployeeWage(company, Wage_Per_Hour, Max_Days_IN_Month, Max_HrsInMonth);
            noOfCompany++;
        }

        public void EmpComputation()
        {
            for (int i = 0; i < noOfCompany; i++)
            {
                CompanywageArr[i].setEmpWage(EmpComputation(CompanywageArr[i]));
                Console.WriteLine(CompanywageArr[i].Return());

            }
        }


        private int EmpComputation(CompanyEmployeeWage emp)
        {
            int empHour;
            int totalHours = 0;
            int totalDays = 0;
            int totalSallary = 0;
            Console.WriteLine();
            Console.WriteLine("-------- " + emp.company + "-----------");

            while (totalHours <= emp.Max_HrsInMonth && totalDays <= emp.Max_Days_IN_Month)
            {
                Random R = new Random();
                int empCheck = R.Next(3);
                totalDays++;
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        {
                            empHour = 8;
                            totalSallary = emp.Wage_Per_Hour * empHour;
                            break;
                        }
                    case IS_PART_TIME:
                        {
                            empHour = 4;
                            totalSallary = emp.Wage_Per_Hour * empHour;
                            break;
                        }
                    default:
                        {
                            empHour = 0;
                            totalSallary = emp.Wage_Per_Hour * empHour;
                            break;
                        }
                }
                totalHours = (totalHours + empHour);
                if (totalHours <= emp.Max_HrsInMonth)
                {
                    emp.sallary += totalSallary;

                    Console.WriteLine("Day# : " + totalDays + " =>  emp Hrs : " + empHour + " =>  EmpWage: " + totalSallary);
                }
            }
            return emp.sallary;
        }
    }
}