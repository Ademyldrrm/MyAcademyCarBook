using Microsoft.AspNetCore.Mvc;
using MyAcademyCarBook.BusinessLayer.Abstract;

namespace MyAcademyCarBook.PresentationLayer.Controllers
{
    public class CarCategoryController : Controller
    {
        private readonly ICarCategoryService _carCategoryService;

        public CarCategoryController(ICarCategoryService carCategoryService)
        {
            _carCategoryService = carCategoryService;
        }

        public IActionResult Index()
        {
            var values=_carCategoryService.TGetListAll();
            return View(values);
        }
    }
}
