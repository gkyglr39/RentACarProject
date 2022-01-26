using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICarImageService
    {

        IResult Add(CarImage carImage,IFormFile file);
        List<CarImage> GetAll();
        List<CarImage> GetImagesByCar(int carId);

        IDataResult<CarImage> GetById(int ImageId);

        IResult Delete(int ImageId);

        IDataResult<CarImage> Update(CarImage carImage);
        IResult DeleteByCar(int carId);

    }
}
