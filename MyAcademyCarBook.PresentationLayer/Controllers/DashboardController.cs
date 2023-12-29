using Microsoft.AspNetCore.Mvc;
using MyAcademyCarBook.BusinessLayer.Abstract;

namespace MyAcademyCarBook.PresentationLayer.Controllers
{
    public class DashboardController : Controller
    {
        private readonly IStatisticService _statisticService;
        private readonly ICommentService _commentService;

        public DashboardController(IStatisticService statisticService, ICommentService commentService)
        {
            _statisticService = statisticService;
            _commentService = commentService;
        }

        public IActionResult Index()
        {
            ViewBag.avargecarprice = _statisticService.TAverageCarPrice();
            ViewBag.carcount = _statisticService.TCarCount();
            ViewBag.lastbrandname = _statisticService.TLastCarBrandName();
            ViewBag.maxpricecar = _statisticService.TMaxPriceCar();
            ViewBag.brandCount=_statisticService.TBrandCount();
            ViewBag.CarCategoryCount=_statisticService.TCarCategoryCount(); 
            ViewBag.MaxCategoryBradn=_statisticService.TMaxCategoryBrand();
            ViewBag.TestimonialCount=_statisticService.TTestimonialCount();

            var values = _commentService.TGetCommentsByCarID2();






            return View(values);
        }
    }
}
