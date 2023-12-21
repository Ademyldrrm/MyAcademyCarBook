﻿using MyAcademyCarBook.DataAccessLayer.Abstract;
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
    public class EfCarDetailDal : GenericRepository<CarDetail>, ICarDetailDal
    {
        public CarDetail GetCarDetailByID(int id)
        {
            var context = new CarBookContext();
            var values = context.CarDetails.Where(x => x.CarID == id).FirstOrDefault();
            return values;
        }
    }
}
