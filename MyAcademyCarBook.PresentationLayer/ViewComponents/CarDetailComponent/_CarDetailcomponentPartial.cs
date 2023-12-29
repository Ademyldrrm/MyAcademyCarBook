using Microsoft.AspNetCore.Mvc;
using MyAcademyCarBook.BusinessLayer.Abstract;
using MyAcademyCarBook.DataAccessLayer.Concrete;
using MyAcademyCarBook.PresentationLayer.Models;
using Newtonsoft.Json.Linq;

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
            var context = new CarBookContext();
            
           var values = _carCategoryService.TGetListAll();

            var categories = (from category in values
                              select new CategoryViewModel
                              {
                                  CategoryName = category.CategoryName,
                                  CategoryCount = context.Cars.Count(car => car.CarCategoryID == category.CarCategoryID),
                              }).ToList();
            return View(categories);
        }
    }
}
