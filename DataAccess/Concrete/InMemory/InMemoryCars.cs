using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public static class InMemoryCars
    {
        private static List<Car> Cars = new List<Car>()
        {
            new Car(){ Id=1, BrandId=1, DailyPrice=2000, ColorId=1, Description="Kiralık araç1", ModelYear=2015},
            new Car(){ Id=2, BrandId=1, DailyPrice=3000, ColorId=1, Description="Kiralık araç2", ModelYear=2016},
            new Car(){ Id=3, BrandId=1, DailyPrice=4000, ColorId=1, Description="Kiralık araç3", ModelYear=2017},
            new Car(){ Id=4, BrandId=1, DailyPrice=5000, ColorId=1, Description="Kiralık araç4", ModelYear=2018},

        };

        public static List<Car> GetCars()
        {
            return Cars;
        }

        public static void AddCar(Car car)
        {
            Cars.Add(car);
        }
        public static Car GetCarById(int Id)
        {
            return Cars.Find(x => x.Id == Id);
        }
        public static void Update(Car car)
        {
            int index = Cars.FindIndex(x => x.Id == car.Id);
            Cars[index] = car;
        }
        public static void Delete(int Id)
        {
            Cars.RemoveAt(Cars.FindIndex(x => x.Id == Id));
        
        }

    }
}
