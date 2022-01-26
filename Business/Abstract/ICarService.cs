using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICarService
    {
        IResult Add(Car entity);
        IDataResult<Car> GetById(int Id);
        IDataResult<List<Car>> GetAll(Func<Car, bool> expression=null);
        IResult Update(Car entity);
        IResult Delete(int delete);
        IDataResult<List<Car>> GetCarsByColorId(int colorId);
        IDataResult<List<Car>> GetCarsByBrandId(int brandId);

        IDataResult<List<CarDetailDto>> GetCarsDetails();
        
    }
}
