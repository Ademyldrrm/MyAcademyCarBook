using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyAcademyCarBook.BusinessLayer.Abstract;

namespace MyAcademyCarBook.PresentationLayer.ViewComponents.HomPageLayout
{
    public class _HomePageLayoutCarList:ViewComponent
    {
        private readonly ICarService _carService;
        private readonly IBrandService _brandService;
        private readonly ICarCategoryService _carCategoryService;

        public _HomePageLayoutCarList(ICarService carService, IBrandService brandService, ICarCategoryService carCategoryService)
        {
            _carService = carService;
            _brandService = brandService;
            _carCategoryService = carCategoryService;
        }

        public IViewComponentResult Invoke()
        {
            List<SelectListItem> brands = (from x in _brandService.TGetListAll()
                                           select new SelectListItem
                                           {
                                               Text = x.BrandName,
                                               Value = x.BrandID.ToString()
                                           }).ToList();


            List<SelectListItem> carcategory = (from x in _carCategoryService.TGetListAll()
                                                select new SelectListItem
                                                {
                                                    Text = x.CategoryName,
                                                    Value = x.CarCategoryID.ToString()
                                                }).ToList();

           

            ViewBag.c = carcategory;
            ViewBag.b = brands;            
            return View();
           
        }
    }
}
