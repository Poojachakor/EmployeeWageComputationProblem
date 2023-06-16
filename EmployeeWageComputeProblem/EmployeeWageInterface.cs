using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputeProblem
{
    public class EmployeeWageInterface
    {
        public interface EmpWageInterface
        {
            public void addCompanies(string Company, int wagePerHour, int maxdays, int maxhours);

            public void EmpComputation();

        }
    }
}

