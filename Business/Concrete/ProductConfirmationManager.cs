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
    public class ProductConfirmationManager : IProductConfirmationService
    {
        // İş modülünün bağlı olduğu Veri Erişim yönteminin bağlılığı
        IProductConfirmationDal _productConfirmationDal;
        public ProductConfirmationManager(IProductConfirmationDal productConfirmationDal)
        {
            _productConfirmationDal = productConfirmationDal;
        }
        // İş modülünün servis ile bağlı olduğu fonksiyonlar
        // SQL Ekleme fonksiyonu
        public IResult Add(ProductsConfirmation productConfirmation)
        {
            var result = _productConfirmationDal.Get(account => account.AccountId == productConfirmation.AccountId && productConfirmation.ProductId==account.ProductId);
            if (result == null)
            {
                _productConfirmationDal.Add(productConfirmation);
                return new SuccessResult("Varlık Eklendi!");
            }
            else
            {
                result.CountOfProduct += productConfirmation.CountOfProduct;
                _productConfirmationDal.Update(result);
                return new SuccessResult("Varlık Eklendi!");
            }
        }
        // SQL Silme fonksiyonu
        public IResult Delete(ProductsConfirmation productConfirmation)
        {
            _productConfirmationDal.Delete(productConfirmation);
            return new SuccessResult("Silme işlemi başarılı");
        }
        // SQL Güncellemme fonksiyonu
        public IResult Update(ProductsConfirmation productConfirmation)
        {
            _productConfirmationDal.Update(productConfirmation);
            return new SuccessResult("Güncelleme işlemi başarılı");
        }
        // SQL Tümünü Listele fonksiyonu
        public IDataResult<List<ProductsConfirmation>> GetAll()
        {
            var result = _productConfirmationDal.GetAll();
            return new SuccessDataResult<List<ProductsConfirmation>>(result);
        }
        // SQL Hesaba Göre getir fonksiyonu
        public IDataResult<List<ProductsConfirmation>> GetByAccount(int accountId)
        {
            var result = _productConfirmationDal.GetAll(account=>account.AccountId==accountId);
            return new SuccessDataResult<List<ProductsConfirmation>>(result);
        }
        // SQL DTo listeleme fonksiyonu
        public IDataResult<List<ProductConfirmationOrderDto>> GetProductsConfirmationDetail()
        {
            var result = _productConfirmationDal.GetProductConfirmationOrderDetail();
            return new SuccessDataResult<List<ProductConfirmationOrderDto>>(result);
        }
        // SQL İşlem Id sine göre getir fonksiyonu
        public IDataResult<ProductsConfirmation> GetById(int confirmId)
        {
            var result = _productConfirmationDal.Get(confirm => confirm.Id == confirmId);
            return new SuccessDataResult<ProductsConfirmation>(result);
        }
    }
}
