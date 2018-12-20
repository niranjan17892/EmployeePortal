using System;
using Employee_Monthly_Salary_Pay_Slip.Models;

namespace Employee_Monthly_Salary_Pay_Slip.Interfaces
{
    public interface IPayslipService
    {
         IEmployeeRepository GeneratePaySlipForEmployee(IEmployeeRepository model);
    }
}
