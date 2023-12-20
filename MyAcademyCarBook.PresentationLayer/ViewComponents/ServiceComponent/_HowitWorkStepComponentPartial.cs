using Microsoft.AspNetCore.Mvc;
using MyAcademyCarBook.BusinessLayer.Abstract;

namespace MyAcademyCarBook.PresentationLayer.ViewComponents.ServiceComponent
{
    public class _HowitWorkStepComponentPartial:ViewComponent
    {
        private readonly IHowitWorkStepService _howitWorkStepService;

        public _HowitWorkStepComponentPartial(IHowitWorkStepService howitWorkStepService)
        {
            _howitWorkStepService = howitWorkStepService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _howitWorkStepService.TGetListAll();
            return View(values);
        }
    }
}
