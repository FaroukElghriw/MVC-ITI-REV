using Microsoft.AspNetCore.Mvc;

namespace Day1.Controllers
{
    public class StateController : Controller
    {
        public IActionResult Set()
        {
            // set for Tempdate
            //TempData["Name"] = "Farouk";

            //return Content("Data Saved");
            string name = "Farouk";
            int age = 21;
            HttpContext.Session.SetString("name", name);
            HttpContext.Session.SetInt32("age", age);
            return Content($"date Save {name} and {age}");
        }
        public IActionResult SetCookie()
        {
            Response.Cookies.Append("name", "Farouk");
            return Content("Cookie Saved");
        }
        public IActionResult Get1()
        {
            // get form Tempdate
            string name = TempData["Name"].ToString();

            return Content($"Get1 and call for tempdate = {name}");
        }
        public IActionResult Get2()
        {
            // set for Tempdate
            string name = TempData["Name"].ToString();

            return Content($"Get2 and call for tempdate = {name} ?? {"Empty"}");
        }
    }
}
