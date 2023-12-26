using Microsoft.AspNetCore.Mvc;
using MyAcademyCarBook.BusinessLayer.Abstract;

namespace MyAcademyCarBook.PresentationLayer.ViewComponents.HomPageLayout
{
    public class _HomePageLayoutLastCarsComponentPartial:ViewComponent
    {
        private readonly ICarService _carService;

        public _HomePageLayoutLastCarsComponentPartial(ICarService carService)
        {
            _carService = carService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _carService.TGetAllLast5Cars();
            return View(values);
        }
    }
}
