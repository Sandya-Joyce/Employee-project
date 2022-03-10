using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Manager : Employee
    {
        public override void SalaryPayout()
        {
           

           var Salary = 50000;
           var Bonus = 6000;

             var TotalSalary = Salary + Bonus;
            Console.WriteLine("The Total Salary of the Manager is "+TotalSalary);

        }
    }
}
