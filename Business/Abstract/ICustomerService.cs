using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IResult Add(Customer entity);
        IDataResult<Customer> GetById(int Id);
        IDataResult<List<Customer>> GetAll(Func<Customer, bool> expression = null);
        IResult Update(Customer entity);
        IResult Delete(int customerId);
    }
}
