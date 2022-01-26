using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IRentalService
    {
        IResult Add(Rental entity);
        IDataResult<Rental> GetById(int Id);
        IDataResult<List<Rental>> GetAll(Func<Rental, bool> expression = null);
        IResult Update(Rental entity);
        IResult Delete(int rentalId);
    }
}
