using Day1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day1.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            List<Student> Model = StudentList.Students.ToList();

            return View("Index",Model);
        }
        public IActionResult Details(int Id)
        {
            Student model = StudentList.Students.FirstOrDefault(S=>S.Id == Id);
            return View("Details",model);
        }
    }
}
