using Microsoft.AspNetCore.Mvc;
using Calculator.Models;
using Calculator.Services;

namespace Calculator.Controllers
{
    public class CalculatorController : Controller
    {
        private static CalculatorService calculatorService = new CalculatorService();

        [HttpGet]
        public IActionResult Index()
        {
            return View(calculatorService.GetModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Press(string value, string action)
        {
            calculatorService.Press(value, action);
            return View("Index", calculatorService.GetModel());
        }
    }
}