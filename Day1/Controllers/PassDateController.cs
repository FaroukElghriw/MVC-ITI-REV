using Day1.Models;
using Day1.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Day1.Controllers
{
    public class PassDateController : Controller
    {
        ITIEntities context= new ITIEntities();

        public IActionResult Index()
        {
            List<string> branches = new List<string>();
            branches.Add("Cairo");
            branches.Add("Alex");
            branches.Add("Giza");
            branches.Add("Mansoura");
            ViewData["branchlist"]=branches;
            ViewBag.date = DateTime.Now;

            List<Department> deptmodel =context.Departments.ToList();
            return View(deptmodel);
        }
        public IActionResult ShowStudent(int id)
        {
            Student stdModel =
                 context.Students.Include(S => S.Department).FirstOrDefault(S => S.Id == id);

            StudentwithDepartmentViewModel stdvm = new StudentwithDepartmentViewModel();
            stdvm.Id= stdModel.Id;
            stdvm.Name = stdModel.Name;
            stdvm.DeptName = stdModel.Department.Name;
            if (stdvm.DeptName == "HR")
            {
                stdvm.Color = "green";
            }
            else
            {
                stdvm.Color = "red";
            }

                return View(stdvm);

        }
    }
}
