﻿using Microsoft.AspNetCore.Mvc;
using MyAcademyCarBook.BusinessLayer.Abstract;

namespace MyAcademyCarBook.PresentationLayer.Controllers
{
    public class ServicesController : Controller
    {
        private readonly IServiceService _serviceService;

        public ServicesController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        public IActionResult Index()
        {
            ViewBag.title1 = "Hizmetlerimiz";
            ViewBag.title2 = "Bu Sayfada Hizmetlerimize Ulaşabilirsiniz";
            var values=_serviceService.TGetListAll();
            return View(values);
        }
    }
}
