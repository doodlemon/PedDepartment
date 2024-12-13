using Microsoft.AspNetCore.Mvc;
using PediatricsDepartment.Data;


namespace PediatricsDepartment.Controllers
{
    public class DepartmentsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DepartmentsController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Departments()
        {
            var departments = _context.Departments.ToList();
            return View(departments);
        }
    }
}
