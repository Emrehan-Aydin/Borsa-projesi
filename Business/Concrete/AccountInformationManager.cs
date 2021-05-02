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
        // İş modülünün bağlı olduğu Veri Erişim yönteminin bağlılığı
        IAccountInformationDal _accountInformationDal;
        public AccountInformationManager(IAccountInformationDal accountInformationDal)
        {
            _accountInformationDal = accountInformationDal;
        }
        // İş modülünün servis ile bağlı olduğu fonksiyonlar
        // SQL Ekleme fonksiyonu
        public IResult Add(AccountInformation accountInformation)
        {
            _accountInformationDal.Add(accountInformation);
            return new SuccessResult("Başarıyla EKlendi");
        }
        // SQL Silme fonksiyonu
        public IResult Delete(AccountInformation accountInformation)
        {
            _accountInformationDal.Delete(accountInformation);
            return new SuccessResult("Başarıyla silindi");
        }
        // SQL Güncelleme fonksiyonu
        public IResult Update(AccountInformation accountInformation)
        {
            _accountInformationDal.Update(accountInformation);
            return new SuccessResult("Başarıyla güncellendi");
        }
        // SQL Tümünü Listeleme fonksiyonu
        public IDataResult<List<AccountInformation>> GetAll()
        {
            var result = _accountInformationDal.GetAll();
            return new SuccessDataResult<List<AccountInformation>>(result);
        }
        // SQL Hesaba göre listeleme fonksiyonu
        public IDataResult<AccountInformation> GetByAccount(int accountId)
        {
            var result = _accountInformationDal.Get(account => account.Id == accountId);
            return new SuccessDataResult<AccountInformation>(result);
        }


    }
}
