using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAccountService
    {
        IDataResult<Account> GetById(int Id);
        IDataResult<Account> Get(Account account);
        IDataResult<List<Account>> GetAll();
        IResult Add(Account account);
        IResult Update(Account account);
        IResult Delete(Account account);
    }
}
