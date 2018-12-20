using System;
namespace Employee_Monthly_Salary_Pay_Slip.Interfaces
{
    public interface IEmployeeRepository : ITaxRepository
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        double AnnualSalary { get; set; }
        int SuperRate { get; set; }
        DateTime StartDate { get; set; }

        string Name { get; set; }
        string PayPeriod { get; set; }
        double GrossIncome { get; set; }

        double NetIncome { get; set; }
        double Super { get; set; }
    }
}
