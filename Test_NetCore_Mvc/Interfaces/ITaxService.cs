using System;
namespace Employee_Monthly_Salary_Pay_Slip.Interfaces
{
    public interface ITaxService
    {
        double CalculateIncomeTax(double taxableIncome);
    }
}
