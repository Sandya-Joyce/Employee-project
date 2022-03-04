using System;

namespace Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The UserName: ");
            var UserName= Console.ReadLine();

            Console.WriteLine("Enter The Designation: ");
            var Designation= Console.ReadLine();
            var employee = new Employee(102,"John", "Jones","C1");

            employee.AddAmountToPurse(200);
            employee.SubractAmountFromPurse(300);


            Console.WriteLine("Salary Details of HR and Manager");
            var manager = new Manager();
           
             manager.SalaryPayout();
          

            

            var hr= new HR();
            hr.SalaryPayout();
            













        }
    }
}
