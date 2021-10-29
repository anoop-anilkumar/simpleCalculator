using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using simpleCalculator.Models;

namespace simpleCalculator.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Calculator()
        {
            return View(new Calculator());
        }
        [HttpPost]
        public JsonResult Add(int num1, int num2)
        {
            int num3 = num1 + num2;
            return Json(num3);
        }
        public JsonResult Sub(int num1, int num2)
        {
            int num3 = num1 - num2;
            return Json(num3);
        }
        public JsonResult Mul(int num1, int num2)
        {
            int num3 = num1 * num2;
            return Json(num3);

        }
        public JsonResult Div(int num1, int num2)
        {
            int num3 = num1 / num2;
            return Json(num3);
        }
        public JsonResult Mod(int num1, int num2)
        {
            int num3 = num1 % num2;
            return Json(num3);
        }

    }
}