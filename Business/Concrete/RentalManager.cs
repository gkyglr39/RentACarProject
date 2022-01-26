using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public IResult Add(Rental entity)
        {
            
            _rentalDal.Add(entity);
            return new SuccessResult();
        }

        public IResult Delete(int rentalId)
        {
            _rentalDal.Delete(rentalId);
            return new SuccessResult();
        }

        public IDataResult<List<Rental>> GetAll(Func<Rental, bool> expression = null)
        {
            var result = expression != null ? _rentalDal.GetAll(expression) : _rentalDal.GetAll();
            return new SuccessDataResult<List<Rental>>(result);
        }

        public IDataResult<Rental> GetById(int Id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.GetById(Id));
        }
        public IResult Update(Rental entity)
        {
            _rentalDal.Update(entity);
            return new SuccessResult();
        }
    }
}
