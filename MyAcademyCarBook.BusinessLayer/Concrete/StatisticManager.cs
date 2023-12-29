using MyAcademyCarBook.BusinessLayer.Abstract;
using MyAcademyCarBook.DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAcademyCarBook.BusinessLayer.Concrete
{
    public class StatisticManager : IStatisticService
    {
        private readonly IStaticticDal _staticticDal;

        public StatisticManager(IStaticticDal staticticDal)
        {
            _staticticDal = staticticDal;
        }

        public decimal TAverageCarPrice()
        {
           return _staticticDal.AverageCarPrice();
        }

        public int TBrandCount()
        {
            return _staticticDal.BrandCount();
        }

        public int TCarCategoryCount()
        {
            return _staticticDal.CarCategoryCount();
        }

        public int TCarCount()
        {
           return _staticticDal.CarCount();
        }

        public string TLastCarBrandName()
        {
           return _staticticDal.LastCarBrandName();
        }

        public string TMaxCategoryBrand()
        {
            return _staticticDal.MaxCategoryBrand();
        }

        public string TMaxPriceCar()
        {
            return _staticticDal.MaxPriceCar();
        }

        public int TTestimonialCount()
        {
          return  _staticticDal.TestimonialCount();
        }
    }
}
