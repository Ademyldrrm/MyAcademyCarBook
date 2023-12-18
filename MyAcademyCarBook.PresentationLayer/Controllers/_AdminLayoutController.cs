using Microsoft.AspNetCore.Mvc;

namespace MyAcademyCarBook.PresentationLayer.Controllers
{
    public class _AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult _PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult _PartialTopbar()
        {
            return PartialView();
        }
        public PartialViewResult _PartialSidebar()
        {
            return PartialView();
        }
        public PartialViewResult _PartialFooter() 
        {
            return PartialView();
        }
    }
}
