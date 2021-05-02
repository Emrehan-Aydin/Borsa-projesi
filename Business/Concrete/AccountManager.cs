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
        // İş modülünün bağlı olduğu Veri Erişim yönteminin bağlılığı
        IAccountDal _accountDal;
        public AccountManager(IAccountDal accountDal)
        {
            _accountDal = accountDal;
        }
        // İş modülünün servis ile bağlı olduğu fonksiyonlar
        // SQL Ekleme fonksiyonu
        public IResult Add(Account account)
        {
            _accountDal.Add(account);
            return new SuccessResult("Üyelik Oluşturuldu!");
        }
        // SQL Silme fonksiyonu
        public IResult Delete(Account account)
        {
            _accountDal.Delete(account);
            return new SuccessResult("Üyelik Silindi!");
        }
        // SQL Güncelleme fonksiyonu
        public IResult Update(Account account)
        {
            _accountDal.Update(account);
            return new SuccessResult("Üyelik Güncellendi!");
        }
        // SQL Hesabı getirme fonksiyonu
        public IDataResult<Account> Get(Account account)
        {
            var result = _accountDal.Get(accounts => accounts.AccountName == account.AccountName && accounts.AccountType==account.AccountType && account.Password==accounts.Password);
            if (result != null)
            {
                return new SuccessDataResult<Account>(result);
            }
            else
            {
                return new ErrorDataResult<Account>();
            }
            
        }
        // SQL Tümünü listeleme fonksiyonu
        public IDataResult<List<Account>> GetAll()
        {
            var result = _accountDal.GetAll();
            return new SuccessDataResult<List<Account>>(result);
        }
    }
}
