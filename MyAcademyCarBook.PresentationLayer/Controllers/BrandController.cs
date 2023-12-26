using Microsoft.AspNetCore.Mvc;
using MyAcademyCarBook.BusinessLayer.Abstract;
using MyAcademyCarBook.EntityLayer.Concrete;

namespace MyAcademyCarBook.PresentationLayer.Controllers
{
    public class BrandController : Controller
    {
        private readonly IBrandService _brandService;

        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        public IActionResult Index()
        {
           var values= _brandService.TGetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateBrand()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateBrand(Brand brand)
        {
            _brandService.TInsert(brand);

           return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateBrand(int id)
        {
            var values=_brandService.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateBrand(Brand brand)
        {
            _brandService.TUpdate(brand);
            return RedirectToAction("Index");
        }
       
        public IActionResult GetBrandSearchByName(string name)
        {
            ViewData["CurrentFilter"] = name;
            var values=from x in _brandService.TGetListAll() select x;
            if(!string.IsNullOrEmpty(name))
            {
                values = values.Where(y => y.BrandName.Contains(name));
            }
           return View(values.ToList());
        }

    }
}
