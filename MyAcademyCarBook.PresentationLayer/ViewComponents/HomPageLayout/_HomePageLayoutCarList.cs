using Microsoft.AspNetCore.Mvc;
using MyAcademyCarBook.BusinessLayer.Abstract;

namespace MyAcademyCarBook.PresentationLayer.ViewComponents.HomPageLayout
{
    public class _HomePageLayoutCarList:ViewComponent
    {
        private readonly ICarService _carService;

        public _HomePageLayoutCarList(ICarService carService)
        {
            _carService = carService;
        }

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
