using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAccountAssetService
    {
        // Account Asset iş modülü servisleri
        IDataResult<List<AccountAsset>> GetByAccount(int accountId);
        IDataResult<List<AccountAsset>> GetAll();
        IResult Add(AccountAsset accountAsset);
        IResult Update(AccountAsset accountAsset);
        IResult Delete(AccountAsset accountAsset);
    }
}
