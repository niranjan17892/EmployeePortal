using System;
using Employee_Monthly_Salary_Pay_Slip.Interfaces;
using Employee_Monthly_Salary_Pay_Slip.Services;

namespace Employee_Monthly_Salary_Pay_Slip.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double AnnualSalary { get; set; }
        public int SuperRate { get; set; }
        public DateTime StartDate { get; set; }

       
        public double NetIncome { get; set; }
        public double Super { get; set; }

        public double IncomeTax { get; set; }
        public string Name { get; set; }
        public string PayPeriod { get; set; }
        public double GrossIncome { get; set; }
    }
}

