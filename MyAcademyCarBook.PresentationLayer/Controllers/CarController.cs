using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyAcademyCarBook.BusinessLayer.Abstract;
using MyAcademyCarBook.EntityLayer.Concrete;
using X.PagedList;

namespace MyAcademyCarBook.PresentationLayer.Controllers
{
    public class CarController : Controller
    {
        private readonly ICarService _carService;
        private readonly ICarDetailService _carDetailService;
        private readonly ICarCategoryService _carCategoryService;
        private readonly ICarStatusService _carStatusService;
        private readonly IBrandService _brandService;
        private readonly IPriceService _priceService;


        public CarController(ICarService carService, ICarDetailService carDetailService, ICarCategoryService carCategoryService, ICarStatusService carStatusService, IBrandService brandService, IPriceService priceService)
        {
            _carService = carService;
            _carDetailService = carDetailService;
            _carCategoryService = carCategoryService;
            _carStatusService = carStatusService;
            _brandService = brandService;
            _priceService = priceService;
        }

        public IActionResult Index()
        {
            var values = _carService.TGetListAll();
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
            _carService.TInsert(car);
            return RedirectToAction("CarListWithBrands");
        }

        [HttpGet]
        public IActionResult UpdateCar(int id)
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
            var vallues = _carService.TGetById(id);
            return View(vallues);

        }
        [HttpPost]
        public IActionResult UpdateCar(Car car)
        {
            _carService.TUpdate(car);
            return RedirectToAction("CarListWithBrands");
        }




        public IActionResult CarListWithBrands()
        {
            var values = _carService.TGetAllCarsWithBrands();
            return View(values);
        }


        public IActionResult DeleteCar(int id)
        {
            var values = _carService.TGetById(id);
            _carService.TDelete(values);
            return RedirectToAction("Index");
        }


        public IActionResult CarList(int page = 1)
        {
            ViewBag.title1 = "Araba Listesi";
            ViewBag.title2 = "Sizin İçin Araç Listesi";
            var result = _carService.TGetAllPricebranCarCategory().ToPagedList(page, 3);


            return View(result);
        }
        public IActionResult CarDetail(int id)
        {
            ViewBag.title1 = "Araba Detayları";
            ViewBag.title2 = " Son Araba Detayları";
            ViewBag.i = id;
            var values = _carDetailService.TGetCarDetailByID(id);
            ViewBag.v = values.Description;
            return View(values);
        }
        [HttpPost]
        public IActionResult RentCar(int kategori, string model, int marka ,string gearType)
        {
            ViewBag.title1 = "Araba Listesi";
            ViewBag.title2 = "Sizin İçin Araç Listesi";
            var values = _carService.TGetAllPricebranCarCategory().Where(x => x.CarCategoryID == kategori && x.Model == model && x.BrandID == marka  && x.GearType== gearType).ToList();

            return View(values);
        }
    }
    
}
