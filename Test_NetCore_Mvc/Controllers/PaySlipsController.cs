using System;
using Employee_Monthly_Salary_Pay_Slip.Interfaces;
using Employee_Monthly_Salary_Pay_Slip.Models;
using Microsoft.AspNetCore.Mvc;


namespace Employee_Monthly_Salary_Pay_Slip.Controllers
{
    public class PaySlipsController : Controller
    {
        private readonly IPayslipService _service;
        public PaySlipsController(IPayslipService service)
        {
            _service = service;

        }

        public IActionResult Home()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Generate(EmployeeRepository model)
        {


            var _model = _service.GeneratePaySlipForEmployee(model);


            ViewData["Name"] = _model.Name;
            
            return View("Generate", _model);
        }
    }
}
