using Microsoft.AspNetCore.Mvc;
using MyAcademyCarBook.BusinessLayer.Abstract;

namespace MyAcademyCarBook.PresentationLayer.ViewComponents.CarDetailComponent
{
    public class _CarDetailCommentComponentPartial:ViewComponent
    {
        private readonly ICommentService _commentService;

        public _CarDetailCommentComponentPartial(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var values = _commentService.TGetCommentsByCarID(id);
            return View(values);
        }
    }
}
