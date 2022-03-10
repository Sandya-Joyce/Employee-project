using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Employee
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Designation { get; set; }      
        
        public int Purse = 0;
        public int Counter { get; set; } = 100;



        public Employee(string firstname, string lastname, string designation)
        {

            Counter = Counter + 1;
            Id = Counter;



            var UserName = firstname + " " + lastname + "_" + Id;
            Console.WriteLine("UserName:" + UserName);





            Designation = designation;
            if (String.IsNullOrEmpty(designation))
            {
                Console.WriteLine("Designation couldn't be Empty");
            }

            else if (designation == "C1")
            {
                Purse = 1000;
                Console.WriteLine("The Amount of C1 role " + Purse);


            }
            else if (designation == "C2")
            {
                Purse = 2000;
                Console.WriteLine("The Amount of C2 role " + Purse);
            }
            else if (designation == "C3")
            {
                Purse = 3000;
                Console.WriteLine("The Amount of C3 role " + Purse);
            }
            else
            {
                Console.WriteLine("Invalid Designation");
            }

        }

        internal void SubractAmountFromPurse()
        {
            throw new NotImplementedException();
        }

        internal void AddAmountToPurse()
        {
            throw new NotImplementedException();
        }

        public Employee()
        {
        }


        private string addAmount;
        public Employee(string addAmount)
        {
            this.addAmount = addAmount;
        }

        public void AddAmountToPurse(int AddAmount)
        {
            
            if (AddAmount>0)
            {

                Purse = Purse + AddAmount;
                Console.WriteLine("The Total Amount After adding is " +Purse);

            }
            
        }
        public void SubractAmountFromPurse(int SubstractAmount)
        {
           
            if (SubstractAmount < Purse)
            { 
                Purse = Purse - SubstractAmount;
                Console.WriteLine("Your Balance Amount is "+Purse);
                 }
            else
            {
                Console.WriteLine("Insuffient Amount");

            }

        }


        

        public int Salary = 0;
        public int Bonus = 0;
        

        public virtual void SalaryPayout()
        {
            //default Implementation
            if (Salary >=0 && Bonus>=0)
            {
               Console.WriteLine("The Salary is");
            }

           

        }


       
    }
}