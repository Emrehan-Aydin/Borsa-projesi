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
        // İş modülünün bağlı olduğu Veri Erişim yönteminin bağlılığı
        IAccountFinanceDal _accountAccountFinanceDal;
        public AccountFinanceManager(IAccountFinanceDal accountAccountFinanceDal)
        {
            _accountAccountFinanceDal = accountAccountFinanceDal;
        }
        // İş modülünün servis ile bağlı olduğu fonksiyonlar
        // SQL Ekleme fonksiyonu
        public IResult Add(AccountFinance accountFinance)
        {
            _accountAccountFinanceDal.Add(accountFinance);
            return new SuccessResult("Finans Bilgisi Eklendi");
        }
        // SQL Silme fonksiyonu
        public IResult Delete(AccountFinance accountFinance)
        {
            _accountAccountFinanceDal.Delete(accountFinance);
            return new SuccessResult("Finans Bilgisi Eklendi");
        }
        // SQL Güncelleme fonksiyonu
        public IResult Update(AccountFinance accountFinance)
        {
            _accountAccountFinanceDal.Update(accountFinance);
            return new SuccessResult("Finans bilgisi güncellendi");
        }
        // SQL Tümünü Listeleme fonksiyonu
        public IDataResult<List<AccountFinance>> GetAll()
        {
            var result = _accountAccountFinanceDal.GetAll();
            return new SuccessDataResult<List<AccountFinance>>(result);
        }
        // SQL Hesaba göre listeleme fonksiyonu
        public IDataResult<AccountFinance> GetByAccount(int accountId)
        {
            var result = _accountAccountFinanceDal.Get(account => account.Id == accountId);
            return new SuccessDataResult<AccountFinance>(result);
        }


    }
}
