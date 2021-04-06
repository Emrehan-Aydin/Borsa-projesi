using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAccountInformationService
    {
        IDataResult<AccountInformation> GetById(int productId);
        IDataResult<List<AccountInformation>> GetAll();
        IResult Add(AccountInformation account);
        IResult Update(AccountInformation account);
    }
}
