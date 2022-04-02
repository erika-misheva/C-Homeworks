
using System;
using Task1.Enum;

namespace Task1.Modules
{
    public class Contractor : Employee
    {
        public override double GetSalary()
        {
            return WorkHours * PayPerHour;
        }
        public void CurrentPosition()
        {
            var managerDepartment = Responsible.Department;
            Console.WriteLine($"The Manager responsible for the contractor {FirstName} {LastName} is from the department: {managerDepartment}");
        }

        public Contractor(double workhours, int payperhour, Manager responsible, string firstname, string lastname, RoleEnum role) 
            : base(workhours, payperhour, responsible, firstname, lastname, role )
        {
            Salary = GetSalary();
        }

    }
}
