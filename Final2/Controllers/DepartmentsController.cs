using Microsoft.AspNetCore.Mvc;
using Final2.Models;

namespace Final2.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {


            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Name = "Electronics" });
            list.Add(new Department { Id = 2, Name = "Drugs" });

            return View(list);
        }
    }
}
    