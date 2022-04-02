using System;
using Task1.Modules;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager salesManager = new Manager("Sales",180, 20, null,
                "Bob", "Bobsky", Enum.RoleEnum.Manager);
            salesManager.AddBonus(1000);

            Manager QAManager = new Manager("QA",160, 20,
                null, "Ana", "Bocka", Enum.RoleEnum.Manager);
            QAManager.AddBonus(900);

            Contractor salesContractor = new Contractor(120, 15, salesManager,
                "Bile", "Bilska", Enum.RoleEnum.Contarctor);
            salesContractor.CurrentPosition();

            Contractor marketingContractor = new Contractor(100, 15, salesManager,
                "Bill", "Billsky", Enum.RoleEnum.Contarctor);
            marketingContractor.CurrentPosition();
            Console.WriteLine();

            SalesPerson John = new SalesPerson(150, 12, salesManager,
                "John", "Wick", Enum.RoleEnum.Sales);
            John.AddSuccessRevenue(2100);

            Manager[] managers = { salesManager, QAManager };
            Contractor[] contractors = { salesContractor, marketingContractor };
            SalesPerson[] salesPeople = { John };

            CEO morgana = new CEO(19,200, 25, null,
               "Morgana", "Pendragon", Enum.RoleEnum.CEO);

            SalesPerson Ron = new SalesPerson(150, 10, salesManager, "Ron", "Ronsky", Enum.RoleEnum.Sales);
            Ron.AddSuccessRevenue(1500);

            morgana.Employees = new Employee[] { salesManager, QAManager, salesContractor, marketingContractor, John, Ron};
            
            morgana.AddSharesPrice(100);
            morgana.PrintInfoCeo();
            Console.WriteLine();

            Console.WriteLine("The employees are:");
            morgana.PrintEmployees();

            


        }
    }
}
