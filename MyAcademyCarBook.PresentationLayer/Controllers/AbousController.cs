using Microsoft.AspNetCore.Mvc;
using MyAcademyCarBook.BusinessLayer.Abstract;

namespace MyAcademyCarBook.PresentationLayer.Controllers
{
    
    public class AbousController : Controller
    {
        private readonly ITeamService _teamService;
        private readonly IAboutService _aboutService;

        public AbousController(ITeamService teamService, IAboutService aboutService)
        {
            _teamService = teamService;
            _aboutService = aboutService;
        }

        public IActionResult Index()
        {
            var values=_teamService.TGetListAll();
            ViewBag.title1 = "Hakkımızda";
            ViewBag.title2 = "Hakkımızda Merak Ettiklerinizi Aşşağıdan Bulabilirsiniz";            
            return View(values);
        }
       
       
    }
}
