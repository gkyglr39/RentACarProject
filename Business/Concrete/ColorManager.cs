using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
       private IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        public IResult Add(Color entity)
        {
            _colorDal.Add(entity);
            return new SuccessResult();
        }

        public IResult Delete(int delete)
        {
            _colorDal.Delete(delete);
            return new SuccessResult();
        }

        public IDataResult<List<Color>> GetAll(Func<Color, bool> expression=null)
        {
            var result= expression != null ? _colorDal.GetAll(expression) : _colorDal.GetAll();
            return new SuccessDataResult<List<Color>>(result);
        }
        public IDataResult<Color> GetById(int Id)
        {
            return new SuccessDataResult<Color>(_colorDal.GetById(Id));
        }
        public IResult Update(Color entity)
        {
            _colorDal.Update(entity);
            return new SuccessResult();
        }
    }
}
