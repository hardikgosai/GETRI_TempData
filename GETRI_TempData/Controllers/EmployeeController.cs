using GETRI_TempData.Models;
using Microsoft.AspNetCore.Mvc;

namespace GETRI_TempData.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            TempData["test"] = "This is TempData";
            return RedirectToAction("GetEmployeeDetails");
        }

        public IActionResult GetEmployeeDetails()
        {
            List<EmployeeModel> list = new List<EmployeeModel>();
            list.Add(new EmployeeModel { EmpId = 1, EmpName = "John", EmpAge = "23", EmpAddress = "USA" });
            list.Add(new EmployeeModel { EmpId = 2, EmpName = "Smith", EmpAge = "25", EmpAddress = "UK" });
            list.Add(new EmployeeModel { EmpId = 3, EmpName = "Mark", EmpAge = "27", EmpAddress = "India" });
            list.Add(new EmployeeModel { EmpId = 4, EmpName = "Mary", EmpAge = "29", EmpAddress = "USA" });
            list.Add(new EmployeeModel { EmpId = 5, EmpName = "Sara", EmpAge = "31", EmpAddress = "USA" });

            ViewBag.Test = TempData["test"];
            ViewBag.Employee =list;
            
            return View();
        }
    }
}
