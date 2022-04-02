using System;
using Task1.Enum;

namespace Task1.Modules
{
    public class SalesPerson : Employee
    {
        private double _successSaleRevenue { get; set; }

        public SalesPerson(double workhours, int payperhour, Manager responsible, string firstname, string lastname, RoleEnum role)
            : base(workhours, payperhour, responsible, firstname, lastname, role)
        {
            Salary = 500;
            Salary = GetSalary();
        }

        public void AddSuccessRevenue(double revenue)
        {
            _successSaleRevenue += revenue;
        }

        public override double GetSalary()
        {
            if (_successSaleRevenue <= 2000)
            {
                return Salary + 500;
            }

            if (_successSaleRevenue > 2000 && _successSaleRevenue <= 5000)
            {
                return Salary + 1000;
            }

            return Salary + 1500;
        }
    }
}
