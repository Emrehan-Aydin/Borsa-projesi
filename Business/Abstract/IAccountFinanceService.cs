using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAccountFinanceService
    {
        IDataResult<AccountFinance> GetById(int Id);
        IDataResult<List<AccountFinance>> GetAll();
        IResult Add(AccountFinance accountFinance);
        IResult Update(AccountFinance accountFinance);
        IResult Delete(AccountFinance accountFinance);
    }
}
