using Microsoft.AspNetCore.Mvc;

namespace MyAcademyCarBook.PresentationLayer.Controllers
{
    public class AbousController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.title1 = "Hakkımızda";
            ViewBag.title2 = "Hakkımızda Merak Ettiklerinizi Aşşağıdan Bulabilirsiniz";
            return View();
        }
    }
}
