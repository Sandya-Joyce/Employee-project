using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Employee
    {
        //Id, Name, UserName, Designation, Purse
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Designation { get; set; }

        public int Purse { get; set; }




        public Employee(int id , string firstname , string lastname , string designation)
        {
            Id = id;
            var counter = Id;
            Id=counter+1;
           // Id=new Employee(counter, firstname , lastname , designation);
           

            UserName= firstname + " " + lastname+ "_"+id;
            Console.WriteLine(UserName);
            
            

           Designation = designation;
            if(designation=="C1")
            {
                Purse = 1000;
               

            }
            else if (designation=="C2")
            {
                Purse = 2000;
                Console.WriteLine(Purse);
            }
            else if(designation=="C3")
            {
                Purse = 3000;
                Console.WriteLine (Purse);
            }          

        }

        public Employee( )
        {
          
        }

        public void AddAmountToPurse(int AddAmount)
        {
            if (AddAmount > 0)
            {


                Purse = Purse + AddAmount;

                
                   
                Console.WriteLine("The Total Amount After adding is "+Purse);

            }
            else
            {
                Console.WriteLine("Invalid Amount");
            }
           
        }
        public void SubractAmountFromPurse(int SubractAmount)
        {
            if (SubractAmount < Purse)
            {
                Purse = Purse - SubractAmount;
                Console.WriteLine("Your Balance Amount is "+Purse);
                 }
            else
            {
                Console.WriteLine("Insuffient Amount");

            }

        }


        //Polymorphism

        public int Salary = 0;
        public int Bonus = 0;
        public virtual void SalaryPayout()
        {
            //default Implementation
            if (Salary > 0 && Bonus>=0)
            {
               Console.WriteLine("The Salary is");
            }
            else
            {
                Console.WriteLine("Invalid Amount");
            }


        }


       
    }
}