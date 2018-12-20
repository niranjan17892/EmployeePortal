using System;
using Employee_Monthly_Salary_Pay_Slip.Interfaces;
using Employee_Monthly_Salary_Pay_Slip.Models;

namespace Employee_Monthly_Salary_Pay_Slip.Services
{
    public class PaySlipService : IPayslipService
    {
        private readonly ITaxService _taxService;

        public PaySlipService(ITaxService taxService)
        {
            // Todo: Make it generic and remove this dependency.

            _taxService = taxService;
        }


        public IEmployeeRepository GeneratePaySlipForEmployee(IEmployeeRepository model)
        {

            // Todo: Can be improved by saving the data to DB and handle logic dynamically.
            // For now every logic is static and fixed.

            var _incmeTax = _taxService.CalculateIncomeTax(model.AnnualSalary);
            var _grossIncme = Math.Round(model.AnnualSalary / 12);

            var empModel = new EmployeeRepository
            {
                Name = model.FirstName + model.LastName,
                PayPeriod = string.Concat(model.StartDate.Date.AddDays(1 - model.StartDate.Day).ToString("dd MMMM") + " - ", model.StartDate.Date.AddDays(1 - model.StartDate.Day).AddMonths(1).AddDays(-1).ToString("dd MMMM")),
                GrossIncome = _grossIncme,
                IncomeTax = _incmeTax,
                NetIncome = _grossIncme - _incmeTax,
                Super = Math.Round(_grossIncme * (model.SuperRate / 100.0)),
                SuperRate = model.SuperRate,
                StartDate = model.StartDate,
                AnnualSalary = model.AnnualSalary
            };



            //public string Name => string.Concat(FirstName + " " + LastName);
            //public string PayPeriod => string.Concat(StartDate.Date.AddDays(1 - StartDate.Day).ToString("dd MMMM")+" - ", StartDate.Date.AddDays(1 - StartDate.Day).AddMonths(1).AddDays(-1).ToString("dd MMMM"));
            //public double GrossIncome => Math.Round(AnnualSalary / 12);

            // public double IncomeTax { get { return TaxService.CalculateIncomeTax(AnnualSalary); } }

            //model.NetIncome = model.GrossIncome - model.IncomeTax;
            //model.Super = Math.Round(model.GrossIncome * (model.SuperRate / 100.0));


            return empModel;
        }

    }
}
