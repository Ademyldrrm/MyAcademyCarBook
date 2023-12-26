using Microsoft.AspNetCore.Mvc;
using MyAcademyCarBook.BusinessLayer.Abstract;

namespace MyAcademyCarBook.PresentationLayer.Controllers
{
    public class AdminContactController : Controller
    {
        private readonly IContactService _contactService;

        public AdminContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            var values=_contactService.TGetListAll();
            return View(values);
        }
        public IActionResult DeleteContact(int id) 
        {
            var values=_contactService.TGetById(id);
            _contactService.TDelete(values);
            return RedirectToAction("Index");
        }
    }
}
