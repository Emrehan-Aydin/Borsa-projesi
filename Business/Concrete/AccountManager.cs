using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class AccountManager : IAccountService
    {
        IAccountDal _accountDal;

        public AccountManager(IAccountDal accountDal)
        {
            _accountDal = accountDal;
        }

        public IResult Add(Account account)
        {
            _accountDal.Add(account);
            return new SuccessResult("Üyelik Oluşturuldu!");
        }

        public IResult Delete(Account account)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Account> Get(Account account)
        {
            return new SuccessDataResult<Account>(_accountDal.Get(accounts => accounts.AccountName==account.AccountName));
        }

        public IDataResult<List<Account>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Account> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Account account)
        {
            throw new NotImplementedException();
        }
    }
}
