using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class AccountInformationManager : IAccountInformationService
    {
        IAccountInformationDal _accountInformationDal;

        public AccountInformationManager(IAccountInformationDal accountInformationDal)
        {
            _accountInformationDal = accountInformationDal;
        }
        public IResult Add(AccountInformation accountInformation)
        {
            _accountInformationDal.Add(accountInformation);
            return new SuccessResult("Başarıyla EKlendi");
        }

        public IDataResult<List<AccountInformation>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<AccountInformation> GetById(int productId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(AccountInformation account)
        {
            throw new NotImplementedException();
        }
    }
}
