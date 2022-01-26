using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Core.Aspects.Autofac.Validation;
using Business.Validations.FluentValidation;
using Core.Aspects.Autofac.Caching;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.GetAll")]
        public IResult Add(Car entity)
        {
            _carDal.Add(entity);
            return new SuccessResult(Messages.SuccessToAdd);
        }
        public IResult Delete(int delete)
        {
            _carDal.Delete(delete);
            return new SuccessResult(Messages.SuccessToRemove);
        }
        [CacheAspect(10)]
        public IDataResult<List<Car>> GetAll(Func<Car, bool> expression=null)
        {
            var result= expression == null ? _carDal.GetAll() : _carDal.GetAll(expression);
            if (result==null)
            return new ErrorDataResult<List<Car>>(Messages.NoDataFound);

            return new SuccessDataResult<List<Car>>(result, Messages.DataLoaded);
        }
        public IDataResult<Car> GetById(int Id)
        {
            var result = _carDal.GetById(Id);
            if (result != null)
              return  new SuccessDataResult<Car>(result);

            return new ErrorDataResult<Car>(result, Messages.NoDataFound) ;

        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            var result = _carDal.GetAll(x => x.BrandId == brandId);
            if (result != null)
                return new SuccessDataResult<List<Car>>(result);
            return new ErrorDataResult<List<Car>>(result,Messages.NoDataFound);
        }
        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            var result = _carDal.GetAll(x => x.ColorId == colorId);
            if (result != null)
                return new SuccessDataResult<List<Car>>(result);
            return new ErrorDataResult<List<Car>>(result, Messages.NoDataFound);
        }
        public IResult Update(Car entity)
        {
            _carDal.Update(entity);
            return new SuccessResult(Messages.SuccessToUpdate);
        }
        public IDataResult<List<CarDetailDto>> GetCarsDetails()
        {
            var result = _carDal.GetCarsDetails();
            return new SuccessDataResult<List<CarDetailDto>>(result);
        }
    }
}
