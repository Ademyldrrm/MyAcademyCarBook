using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MyAcademyCarBook.BusinessLayer.Abstract;

namespace MyAcademyCarBook.PresentationLayer.ViewComponents.AboutComponent
{
    public class _AbaoutLowerComponentPartial:ViewComponent
    {
        private readonly IAboutService _aboutService;

        public _AbaoutLowerComponentPartial(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _aboutService.TGetListAll();
            return View(values); 
        }
    }
}
