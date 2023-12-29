using Microsoft.AspNetCore.Mvc;
using MyAcademyCarBook.BusinessLayer.Abstract;
using MyAcademyCarBook.EntityLayer.Concrete;
using System.Security.Cryptography.Pkcs;

namespace MyAcademyCarBook.PresentationLayer.Controllers
{
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;
        private readonly IContactInformationService _contactInformationService;
        public ContactController(IContactService contactService, IContactInformationService contactInformationService)
        {
            _contactService = contactService;
            _contactInformationService = contactInformationService;
        }

        public IActionResult Index()
        {
            var values = _contactInformationService.TGetById(1);
            ViewBag.Address = values.Adress;
            ViewBag.Mail = values.Mail;
            ViewBag.telefon=values.Telefon;
            ViewBag.title1 = "İletişim";
            ViewBag.title2 = "Bize Bu Sayfadan Ulaşabilirsiniz";
            return View();
        }
        [HttpGet]
        public IActionResult CreateContact() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateContact(Contact contact)
        {
            _contactService.TInsert(contact);
            return RedirectToAction("Index");
        }
    }
}
