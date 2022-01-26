using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        public void Add(Car car)
        {
            InMemoryCars.AddCar(car);
        }

        public void Delete(int Id)
        {
            InMemoryCars.Delete(Id);
        }

        public List<Car> GetAll()
        {
            return InMemoryCars.GetCars();
        }



        public List<Car> GetAll(Func<Car, bool> expression)
        {
            return InMemoryCars.GetCars().Where(expression).ToList();
        }

        public Car GetById(int Id)
        {
            return InMemoryCars.GetCarById(Id);
        }

        public List<CarDetailDto> GetCarsDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            InMemoryCars.Update(car);
        }
    }
}
