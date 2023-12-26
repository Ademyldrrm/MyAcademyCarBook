using Microsoft.AspNetCore.Mvc;

namespace MyAcademyCarBook.PresentationLayer.ViewComponents.HomPageLayout
{
    public class _HomePageLayoutCarList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
