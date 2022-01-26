using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IBrandService
    {
        IResult Add(Brand entity);
        IDataResult<Brand> GetById(int Id);
        IDataResult<List<Brand>> GetAll(Func<Brand, bool> expression = null);
        IResult Update(Brand entity);
        IResult Delete(int delete);
        

    }
}
