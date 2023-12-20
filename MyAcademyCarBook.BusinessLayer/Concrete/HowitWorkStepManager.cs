using MyAcademyCarBook.BusinessLayer.Abstract;
using MyAcademyCarBook.DataAccessLayer.Abstract;
using MyAcademyCarBook.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAcademyCarBook.BusinessLayer.Concrete
{
    public class HowitWorkStepManager : IHowitWorkStepService
    {
        private readonly IHowitWorkStepDal _howitWorkStepDal;

        public HowitWorkStepManager(IHowitWorkStepDal howitWorkStepDal)
        {
            _howitWorkStepDal = howitWorkStepDal;
        }

        public void TDelete(HowitWorkStep entity)
        {
            _howitWorkStepDal.Delete(entity);   
        }

        public HowitWorkStep TGetById(int id)
        {
           return _howitWorkStepDal.GetById(id);
        }

        public List<HowitWorkStep> TGetListAll()
        {
            return _howitWorkStepDal.GetListAll();
        }

        public void TInsert(HowitWorkStep entity)
        {
            _howitWorkStepDal.Insert(entity);
        }

        public void TUpdate(HowitWorkStep entity)
        {
           _howitWorkStepDal.Update(entity);
        }
    }
}
