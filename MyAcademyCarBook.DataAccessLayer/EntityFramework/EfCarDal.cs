using Microsoft.EntityFrameworkCore;
using MyAcademyCarBook.DataAccessLayer.Abstract;
using MyAcademyCarBook.DataAccessLayer.Concrete;
using MyAcademyCarBook.DataAccessLayer.Repositories;
using MyAcademyCarBook.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAcademyCarBook.DataAccessLayer.EntityFramework
{
    public class EfCarDal : GenericRepository<Car>, ICarDal
    {
       

        public List<Car> GetAllCarsWithBrands()
        {
            var context = new CarBookContext();
            var values = context.Cars.Include(x => x.Brand).Include(x => x.CarCategory).Include(x => x.CarStatus).ToList();
            return values;
        }

        public List<Car> GetAllLast5Cars()
        {
            var context = new CarBookContext();
            var values = context.Cars.Include(x => x.Brand).Include(x => x.CarCategory).Include(x => x.CarStatus).Include(x => x.Prices).Take(5).ToList(); 
            return values;
        }

        public List<Car> GetAllPricebranCarCategory()
        {
            var context=new CarBookContext();
            var values= context.Cars.Include(x => x.Brand).Include(x => x.CarCategory).Include(x => x.CarStatus).Include(x=>x.Prices).ToList();
            return values;
        }
    }
}
