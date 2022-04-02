using System;
using Task1.Enum;

namespace Task1.Modules
{
    public class Employee
    {
        public double WorkHours { get; set; }
        public int PayPerHour { get; set; }
        public Manager Responsible { get; set; }
        protected double Salary { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public RoleEnum Role { get; set; }

        public void PrintInfo(Employee employee)
        {
            Console.WriteLine($"{employee.FirstName} {employee.LastName} his/her position in the firm is {employee.Role} and his/her salary is {employee.GetSalary()}$.");
        }

        public virtual double GetSalary()
        {
            return Salary;
        }
        public Employee(double workhours, int payperhour, Manager responsible, string firstname, string lastname, RoleEnum role)
        {
            WorkHours = workhours;
            PayPerHour = payperhour;
            Responsible = responsible;
            Salary = GetSalary();
            FirstName = firstname;
            LastName = lastname;
            Role = role;
        }

       
    }
}
