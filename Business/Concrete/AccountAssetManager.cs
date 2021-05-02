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
    public class AccountAssetManager : IAccountAssetService
    {
        // İş modülünün bağlı olduğu Veri Erişim yönteminin bağlılığı
        IAccountAssetDal _accountAssetDal;

        public AccountAssetManager(IAccountAssetDal accountAssetDal)
        {
            _accountAssetDal = accountAssetDal;
        }
        // İş modülünün servis ile bağlı olduğu fonksiyonlar
        // SQL Ekleme fonksiyonu
        public IResult Add(AccountAsset accountAsset)
        {
            // Kullanıcının daha önceden bu varlığa sahip olduğunu kontrol eder.
            var result = _accountAssetDal.Get(p => p.AccountId == accountAsset.AccountId && p.ProductId == accountAsset.ProductId);
            if (result == null)
            {
                // yoksa yeni bir varlık ekler.
                _accountAssetDal.Add(accountAsset); 
                return new SuccessResult("Varlık Eklendi!");
            }
            else
            {
                // varsa üzerine ekler
                result.ProductOfStock += accountAsset.ProductOfStock;
                _accountAssetDal.Update(result);
                return new SuccessResult("Varlık Eklendi!"); 
            }
        }
        // // SQL Silme fonksiyonu
        public IResult Delete(AccountAsset accountAsset)
        {
            _accountAssetDal.Delete(accountAsset);
            return new SuccessResult("Varlık Silindi!");
        }
        // SQL Tümünü listeleme fonksiyonu
        public IDataResult<List<AccountAsset>> GetAll()
        {
            var result =_accountAssetDal.GetAll();
            return new SuccessDataResult<List<AccountAsset>>(result, "Üyelik Oluşturuldu!");
        }
        // SQL Hesaplara göre getirme fonksiyonu
        public IDataResult<List<AccountAsset>> GetByAccount(int accountId)
        {
            var result = _accountAssetDal.GetAll(account=>account.AccountId== accountId);
            return new SuccessDataResult<List<AccountAsset>>(result);
        }
        // SQL Hesaba göre getirme fonksiyonu
        public IDataResult<List<MyAssetsDto>> GetDetails(int accountId)
        {
            // SQL Dto getirme fonksiyonu
            var result = _accountAssetDal.GetAssetDetail(accountId);
            if (result != null)
            {
                return new SuccessDataResult<List<MyAssetsDto>>(result);
            }
            else
            {
                return new ErrorDataResult<List<MyAssetsDto>>("Ürün getirilemedi!");
            }
        }
        // SQL Update fonksiyonu
        public IResult Update(AccountAsset accountAsset)
        {

            _accountAssetDal.Update(accountAsset);
            return new SuccessResult("Güncelleme Başarılı");
        }

    }
}
