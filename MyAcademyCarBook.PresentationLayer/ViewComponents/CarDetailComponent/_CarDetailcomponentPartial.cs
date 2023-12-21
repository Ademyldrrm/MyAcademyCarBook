using Microsoft.AspNetCore.Mvc;
using MyAcademyCarBook.BusinessLayer.Abstract;

namespace MyAcademyCarBook.PresentationLayer.ViewComponents.CarDetailComponent
{
    
    public class _CarDetailcomponentPartial:ViewComponent
    {
        private readonly ICarCategoryService _carCategoryService;

        public _CarDetailcomponentPartial(ICarCategoryService carCategoryService)
        {
            _carCategoryService = carCategoryService;
        }

        public IViewComponentResult Invoke()
        {
           var values= _carCategoryService.TGetListAll();
            return View(values);
        }
    }
}
