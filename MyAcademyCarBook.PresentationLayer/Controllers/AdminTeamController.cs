using Microsoft.AspNetCore.Mvc;
using MyAcademyCarBook.BusinessLayer.Abstract;
using MyAcademyCarBook.EntityLayer.Concrete;

namespace MyAcademyCarBook.PresentationLayer.Controllers
{
    public class AdminTeamController : Controller
    {
        private readonly ITeamService _teamService;

        public AdminTeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        public IActionResult Index()
        {
            var values=_teamService.TGetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateTeam()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateTeam(Team team)
        {
            _teamService.TInsert(team);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteTeam(int id)
        {
            var values = _teamService.TGetById(id);
            _teamService.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateTeam(int id)
        {
            var values = _teamService.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateTeam(Team team)
        {
            _teamService.TUpdate(team);
            return RedirectToAction("Index");
        }
    }
}
