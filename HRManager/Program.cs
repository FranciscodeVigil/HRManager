using System;

namespace HRManager
{
    class Program
    {
        public class Employee
        {
            public int EmpNum { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public virtual string PaySummary
            {
                get { return "No pay for base class employee"; }
            }
        }
        public class Hourlyemployee : Employee
        {
            public decimal HourlyRate { get; set; }

            public Hourlyemployee() : base()
            {
                HourlyRate = 15.0M;
            }

            public override string PaySummary
            {
                get { return "This employee is payed " + HourlyRate + " per hour"; }
            }
            new public string ToString()
            {
                return base.ToString() + " Hourly Employee";
            }

        }
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.EmpNum = 1;
            emp.FirstName = "Steve";
            emp.LastName = "Jobs";
            Console.WriteLine("emp.GetPaySummary: " + emp.PaySummary);

            Hourlyemployee hourEmp = new Hourlyemployee();
            hourEmp.EmpNum = 2;
            hourEmp.FirstName = "Bill";
            hourEmp.LastName = "Gates";
            hourEmp.HourlyRate = 15.0M;
            Console.WriteLine("hourEmp.GetPaySummary: " + hourEmp.PaySummary);

            Employee emp2 = hourEmp;
            emp2.ToString();
            Console.WriteLine("emp2.GetPaySummary: " + emp2.PaySummary);
        }
    }
}
