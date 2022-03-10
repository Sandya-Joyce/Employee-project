using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
   public  class HR : Employee
    {     

        public override void SalaryPayout()
        {
           var Salary = 40000;
           var Bonus = 5000;



            var TotalSalary =  Salary + Bonus;
            Console.WriteLine("The Total Salary of the HR is "+TotalSalary);
        }
    }
}
