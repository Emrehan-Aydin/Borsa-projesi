using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CashConfirmationManager : ICashConfirmationService
    {
        // İş modülünün bağlı olduğu Veri Erişim yönteminin bağlılığı
        ICashConfirmationDal _cashConfirmationDal;
        public CashConfirmationManager(ICashConfirmationDal cashConfirmationDal)
        {
            _cashConfirmationDal = cashConfirmationDal;
        }
        // İş modülünün servis ile bağlı olduğu fonksiyonlar
        // SQL Ekleme fonksiyonu
        public IResult Add(CashConfirmation cashComfirmation)
        {
            var result = _cashConfirmationDal.Get(account=>account.AccountId==cashComfirmation.AccountId);
            if (result == null)
            {
                _cashConfirmationDal.Add(cashComfirmation);
                return new SuccessResult("Varlık Eklendi!");
            }
            else
            {
                result.PendingCash += cashComfirmation.PendingCash;
                _cashConfirmationDal.Update(result);
                return new SuccessResult("Varlık Eklendi!");
            }
        }
        // SQL Silme fonksiyonu
        public IResult Delete(CashConfirmation cashComfirmation)
        {
            _cashConfirmationDal.Delete(cashComfirmation);
            return new SuccessResult("İşlem silindi!");
        }
        // SQL Güncelleme fonksiyonu
        public IResult Update(CashConfirmation cashComfirmation)
        {
            _cashConfirmationDal.Update(cashComfirmation);
            return new SuccessResult("İşlem güncellendi!");
        }
        // SQL Tümü Listele fonksiyonu
        public IDataResult<List<CashConfirmation>> GetAll()
        {
            var result = _cashConfirmationDal.GetAll();
            return new SuccessDataResult<List<CashConfirmation>>(result);
        }
        // SQL Hesaba göre getir fonksiyonu
        public IDataResult<CashConfirmation> GetByAccount(int accountId)
        {
            var result = _cashConfirmationDal.Get(account=>account.AccountId== accountId);
            return new SuccessDataResult<CashConfirmation>(result);
        }
        // SQL İşlem Id sine göre getir fonksiyonu
        public IDataResult<CashConfirmation> GetById(int confirmId)
        {
            var result = _cashConfirmationDal.Get(confirm => confirm.Id == confirmId);
            return new SuccessDataResult<CashConfirmation>(result);
        }
        // SQL Dto Listeleme fonksiyonu
        public IDataResult<List<CashConfirmationOrderDto>> GetCashConfirmationOrderDetail()
        {
            var result = _cashConfirmationDal.GetCashConfirmationOrderDetail();
            return new SuccessDataResult<List<CashConfirmationOrderDto>>(result);
        }
    }
}
