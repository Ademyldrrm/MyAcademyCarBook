using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyAcademyCarBook.BusinessLayer.Abstract;
using MyAcademyCarBook.EntityLayer.Concrete;

namespace MyAcademyCarBook.PresentationLayer.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarService _carService;
        private readonly ICarDetailService _carDetailService;
        private readonly ICarCategoryService _carCategoryService;
        private readonly ICarStatusService _carStatusService;
        private readonly IBrandService _brandService;


        public CarController(ICarService carService, ICarDetailService carDetailService, ICarCategoryService carCategoryService, ICarStatusService carStatusService, IBrandService brandService)
        {
            _carService = carService;
            _carDetailService = carDetailService;
            _carCategoryService = carCategoryService;
            _carStatusService = carStatusService;
            _brandService = brandService;
        }

        public IActionResult Index()
        {
           var values=_carService.TGetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateCar()
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

            List<SelectListItem> carstatus = (from x in _carStatusService.TGetListAll()
                                              select new SelectListItem
                                              {
                                                  Text = x.CarStatusName,
                                                  Value = x.CarStatusID.ToString()
                                              }).ToList();


            ViewBag.c = carcategory;
            ViewBag.b = brands;
            ViewBag.cs = carstatus;


            return View();
        }
        [HttpPost]
        public IActionResult CreateCar(Car car)
        {
            if (ModelState.IsValid)
            {
                _carService.TInsert(car);
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult CarListWithBrands()
        {
            var values = _carService.TGetAllCarsWithBrands();
            return View(values);
        }














        public IActionResult CarList()
        {
            ViewBag.title1 = "Araba Listesi";
            ViewBag.title2 = "Sizin İçin Araç Listesi";
            var result = _carService.TGetAllCarsWithBrands();
            return View(result);
        }
        public IActionResult CarDetail(int id)
        {
            ViewBag.title1 = "Araba Detayları";
            ViewBag.title2 = " Son Araba Detayları";
            ViewBag.i=id;
            var values=_carDetailService.TGetCarDetailByID(id);
            ViewBag.v=values.Description;
            return View(values);
        }
    }
}
