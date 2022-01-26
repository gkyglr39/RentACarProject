using Core.DataAccess.Abstract;
using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepository<Car, CarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarsDetails()
        {
            using (CarContext context = new CarContext())
            {
                var result = (from car in context.Cars
                              join brand in context.Brands
                              on car.BrandId equals brand.Id
                              join color in context.Colors on
                              car.ColorId equals color.Id
                              select new CarDetailDto() { BrandName = brand.Name, CarName = car.CarName, ColorName = color.Name }).ToList();
                return result;
            }
        }
    }
}
