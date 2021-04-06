using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAccountAssetService
    {
        IDataResult<AccountAsset> GetById(int productId);
        IDataResult<List<AccountAsset>> GetAll();
        IResult Add(AccountAsset accountAsset);
        IResult Update(AccountAsset accountAsset);
    }
}
