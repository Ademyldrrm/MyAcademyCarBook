using Microsoft.AspNetCore.Mvc;
using MyAcademyCarBook.BusinessLayer.Abstract;

namespace MyAcademyCarBook.PresentationLayer.Controllers
{
    
    public class AbousController : Controller
    {
        private readonly ITeamService _teamService;

        public AbousController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        public IActionResult Index()
        {
            var values=_teamService.TGetListAll();
            ViewBag.title1 = "Hakkımızda";
            ViewBag.title2 = "Hakkımızda Merak Ettiklerinizi Aşşağıdan Bulabilirsiniz";            
            return View(values);
        }
        public PartialViewResult AbaoutTopPartial()
        {
            return PartialView();
        }
        public PartialViewResult AboutLowerPartial()
        {
            return PartialView();
        }
    }
}
