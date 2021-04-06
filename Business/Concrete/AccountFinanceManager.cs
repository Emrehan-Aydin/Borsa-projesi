using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class AccountFinanceManager : IAccountFinanceService
    {
        IAccountFinanceDal _accountAccountFinanceDal;
        public AccountFinanceManager(IAccountFinanceDal accountAccountFinanceDal)
        {
            _accountAccountFinanceDal = accountAccountFinanceDal;
        }

        public IResult Add(AccountFinance accountFinance)
        {
            _accountAccountFinanceDal.Add(accountFinance);
            return new SuccessResult("Finans Bilgisi Eklendi");
        }

        public IResult Delete(AccountFinance accountFinance)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<AccountFinance>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<AccountFinance> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(AccountFinance accountFinance)
        {
            throw new NotImplementedException();
        }
    }
}
