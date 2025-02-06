using Microsoft.AspNetCore.Mvc;

namespace Day1.Controllers
{
    public class ProductController : Controller
    {
        public string getInfo()
        {
            return "Hellp from my MVC ";
        }
        public ContentResult getContent()
        {
            ContentResult result = new ContentResult();
            result.Content = "Hell from content Result ";
           return result;
        } 
        public ViewResult getView()
        {
            ViewResult result = new ViewResult();
            result.ViewName = "ShowProduct";
            return result;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
