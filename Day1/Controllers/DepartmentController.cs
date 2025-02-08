using Day1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day1.Controllers
{
    public class DepartmentController : Controller
    {
        ITIEntities context;
        public DepartmentController()
        {
           context = new ITIEntities();
        }
        public IActionResult Index()
        {
          
            var depts= context.Departments.ToList();
            return View("Index",depts);
        }
        public IActionResult GetStudent(int id)
        {
            var student = context.Students.Where(S => S.DepartmentId == id).ToList();
           return  View("GetStudent",student);
        }
    }
}
