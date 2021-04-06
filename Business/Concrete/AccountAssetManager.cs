using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class AccountAssetManager : IAccountAssetService
    {
        IAccountAssetDal _accountAssetDal;

        public AccountAssetManager(IAccountAssetDal accountAssetDal)
        {
            _accountAssetDal = accountAssetDal;
        }

        public IResult Add(AccountAsset accountAsset)
        {
            _accountAssetDal.Add(accountAsset);
            throw new NotImplementedException();
        }

        public IDataResult<List<AccountAsset>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<AccountAsset> GetById(int productId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(AccountAsset accountAsset)
        {
            throw new NotImplementedException();
        }
    }
}
