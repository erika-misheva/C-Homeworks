using System;
using System.Collections.Generic;
using System.Text;
using Task1.Enum;

namespace Task1.Modules
{
    public class CEO : Employee
    {


        public Employee[] Employees { get; set; }
        public int Shares { get; set; }
        private double _sharesPrice { get; set; }

        public void AddSharesPrice(double sharesPrice)
        {
            _sharesPrice = sharesPrice;
        }

        public void PrintEmployees()
        {
            foreach (Employee employee in Employees)
            {
                PrintInfo(employee);
            }
        }
        public override double GetSalary()
        {
            return Salary + Shares * _sharesPrice;
        }
        public void PrintInfoCeo()
        {
            Console.WriteLine($"{FirstName} {LastName} is {Role} and her salary is {GetSalary()}$.");
        }
        public CEO(int shares, double workhours, int payperhour, Manager responsible, string firstname, string lastname, RoleEnum role) 
            : base(workhours, payperhour, responsible, firstname, lastname, role)
        {
            Shares = shares;    
            Salary = 1000;
            Salary = GetSalary();
        }

       

    }
}
