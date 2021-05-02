using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAccountInformationService
    {
        // Account information iş modülü servisleri
        IDataResult<AccountInformation> GetByAccount(int accountId);
        IDataResult<List<AccountInformation>> GetAll();
        IResult Add(AccountInformation accountInformation);
        IResult Update(AccountInformation accountInformation);
        IResult Delete(AccountInformation accountInformation);
    }
}
