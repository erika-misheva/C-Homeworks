using System;
using Task1.Enum;

namespace Task1.Modules
{
    public class Manager : Employee
    {
        private double _bonus { get; set; }
        public string Department { get; set; }

        public Manager(string department, double workhours, int payperhour, Manager responsible, string firstname, string lastname, RoleEnum role)
            : base(workhours, payperhour, responsible, firstname, lastname, role)
        {
            Department = department;
            Salary = 1300;
            Salary = GetSalary();
        }

        public void AddBonus(double bonus )
        {
            _bonus += bonus;
        }

        public override double GetSalary()
        {
            return Salary + _bonus;
        }
    }
}
