using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        private ICarImageDal _carImageDal;
        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }
        public IResult Add(CarImage carImage,IFormFile file)
        {
            if (CheckCarImageLimit(carImage.CarId))
            {
                string fileUrl = FileHelper.Upload(file);
                carImage.ImagePath = fileUrl;
                carImage.Date = DateTime.Now;
                _carImageDal.Add(carImage);
                return new SuccessResult("Ekleme başarılı");
            }
            return new ErrorResult("Bir arabada en fazla 5 adet resim olabilir");
        }
        public List<CarImage> GetAll()
        {
            return _carImageDal.GetAll();   
        }
        public bool CheckCarImageLimit(int carId)
        {
            var count = _carImageDal.GetAll(x => x.CarId == carId).Count;
            if (count < 5)
            {
                return true;
            }
            return false;

        }

        public List<CarImage> GetImagesByCar(int carId)
        {
             List<CarImage> carImages= _carImageDal.GetAll(x => x.CarId == carId);
            if (carImages.Count > 0)
            {
                return carImages;
            }
            carImages.Add(new CarImage() { CarId = carId, Date = DateTime.Now, ImagePath = Environment.CurrentDirectory+"\\wwwroot\\Default-Car.jpg" });
            return carImages;
        }

        public IResult Delete(int ImageId)
        {
            _carImageDal.Delete(ImageId);
            return new SuccessResult(Messages.SuccessToRemove);
        }

        public IResult DeleteByCar(int carId)
        {
            List<CarImage> carImages = _carImageDal.GetAll(x => x.CarId == carId);
            foreach (var carimage in carImages)
            {
                _carImageDal.Delete(carimage.Id);
            }
            return new SuccessResult(Messages.SuccessToRemove);
        }

        public IDataResult<CarImage> Update(CarImage carImage)
        {
            _carImageDal.Update(carImage);
            return new SuccessDataResult<CarImage>(GetById(carImage.Id).Data,"Güncelleme başarılı");
        }
        public IDataResult<CarImage> GetById(int ImageId)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.GetById(ImageId));
        }
    }
}
