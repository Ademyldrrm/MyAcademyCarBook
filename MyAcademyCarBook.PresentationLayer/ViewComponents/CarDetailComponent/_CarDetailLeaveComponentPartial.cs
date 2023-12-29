using Microsoft.AspNetCore.Mvc;
using MyAcademyCarBook.BusinessLayer.Abstract;

namespace MyAcademyCarBook.PresentationLayer.ViewComponents.CarDetailComponent
{
    public class _CarDetailLeaveComponentPartial:ViewComponent
    {
        private readonly ICommentService _commentService;

        public _CarDetailLeaveComponentPartial(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IViewComponentResult Invoke(int id)
        {
            ViewBag.Id = id;

            return View();
        }
    }
}
