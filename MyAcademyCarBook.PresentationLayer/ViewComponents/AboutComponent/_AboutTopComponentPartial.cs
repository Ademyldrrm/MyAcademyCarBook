using Microsoft.AspNetCore.Mvc;
using MyAcademyCarBook.BusinessLayer.Abstract;

namespace MyAcademyCarBook.PresentationLayer.ViewComponents.AboutComponent
{
    public class _AboutTopComponentPartial:ViewComponent
    {
        private readonly IAboutService _aboutService;

        public _AboutTopComponentPartial(IAboutService aboutService)
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
