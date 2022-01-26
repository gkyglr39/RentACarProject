using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        IResult Add(Color entity);
        IDataResult<Color> GetById(int Id);
        IDataResult<List<Color>> GetAll(Func<Color, bool> expression = null);
        IResult Update(Color entity);
        IResult Delete(int colorId);

    }
}
