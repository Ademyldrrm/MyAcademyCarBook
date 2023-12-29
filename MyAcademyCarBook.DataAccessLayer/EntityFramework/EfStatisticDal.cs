using MyAcademyCarBook.DataAccessLayer.Abstract;
using MyAcademyCarBook.DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAcademyCarBook.DataAccessLayer.EntityFramework
{
    public class EfStatisticDal : IStaticticDal
    {
        CarBookContext carBookContext=new CarBookContext();
        public decimal AverageCarPrice()
        {
            decimal value = carBookContext.Prices.Average(x => x.PriceValue);
            return value;
              
        }

        public int BrandCount()
        {
           int brandCount=carBookContext.Brands.Count();
            return brandCount;
        }

        public int CarCategoryCount()
        {
           int CarCategoryCount=carBookContext.CarCategories.Count();
            return CarCategoryCount;
        }

        public int CarCount()
        {
           int count=carBookContext.Prices.Count();
            return count;
        }

        public string LastCarBrandName()
        {
            string last = carBookContext.Cars.OrderByDescending(x => x.CarID).Select(c => c.Brand.BrandName).FirstOrDefault();
            return last;
        }

        public string MaxCategoryBrand()
        {
            var enCokKategoriyeSahipMarka = carBookContext.Cars
                 .GroupBy(c => c.CarCategory.CategoryName) // CarCategoryID özelliği üzerinden gruplandırma yapılıyor
                 .OrderByDescending(g => g.Count())
                 .Select(g => g.Key)
                 .FirstOrDefault();

            return enCokKategoriyeSahipMarka;
        }

        public string MaxPriceCar()
        {
            string enYuksekFiyatliAraba = carBookContext.Cars.OrderByDescending(x => x.Prices.Max(p => p.PriceValue)).Select(c => c.Brand.BrandName).FirstOrDefault();
            return enYuksekFiyatliAraba;
        }

        public int TestimonialCount()
        {
            int TestimonialCount=carBookContext.Testimonials.Count();
            return TestimonialCount;
        }
    }
}
