using Core.Utilities.Results;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface IUserService
    {
        IResult Add(User entity);
        IDataResult<User> GetById(int Id);
        IDataResult<List<User>> GetAll(Func<User, bool> expression = null);
        IResult Update(User entity);
        IResult Delete(int userId);
        List<OperationClaim> GetClaims(User user);

        IDataResult<User> GetByMail(string email);


    }
}
