using System;


namespace Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
             Console.WriteLine("Enter your Firstname: ");
             var firstname = Console.ReadLine();
             if (firstname.Length == 0)
                Console.WriteLine("firstName couldn't be Empty");
             else 
                Console.WriteLine("Enter the Lastname");
                var lastname = Console.ReadLine();
                 if (lastname.Length == 0)
                     Console.WriteLine("The lastname couldn't be Empty");
                     lastname = Console.ReadLine();
            Console.WriteLine("Enter your Designation: ");
            var designation = Console.ReadLine();


            var employee = new Employee(firstname, lastname, designation);
            Console.ReadKey();






            Console.WriteLine();
            Console.WriteLine("enter the Amount to Add to Purse");           
            var addAmount = Console.ReadLine();
            var emp = new Employee(addAmount);
            emp.AddAmountToPurse();
          
            
            


            Console.ReadKey();


            Console.WriteLine("enter the Amount to Subsract from Purse");
            var substractAmount = Console.ReadLine();      
            var empsub = new Employee(substractAmount);
            empsub.SubractAmountFromPurse();


            employee.SalaryPayout();


            var manager = new Manager();
            manager.SalaryPayout();


            var hr = new HR();
            hr.SalaryPayout();


        }



    }
}

