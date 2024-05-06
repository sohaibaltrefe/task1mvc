using Microsoft.AspNetCore.Mvc;
using task1mvc.Data;

namespace task1mvc.Controllers
{
    public class EmployeeController : Controller
    {
        AppDbContext context = new AppDbContext();
        public IActionResult Index()
        {
            var Employeedata=context.Employees.ToList();
            return View( "Index", Employeedata);
        }
    }
}
