using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        // İş modülünün bağlı olduğu Veri Erişim yönteminin bağlılığı
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        // İş modülünün servis ile bağlı olduğu fonksiyonlar
        // SQL Ekleme fonksiyonu
        public IResult Add(Product product)
        {
            _productDal.Add(product);
            return new SuccessResult("Ürün Eklendi!");
        }
        // SQL Güncelleme fonksiyonu
        public IResult Update(Product product)
        {
            _productDal.Update(product);
            return new SuccessResult("Ürün güncellendi");
        }
        // SQL Silme fonksiyonu
        public IResult Delete(Product product)
        {
            _productDal.Delete(product);
            return new SuccessResult("Ürün silindi");
        }
        // SQL Tümünü Listeleme fonksiyonu
        public IDataResult<List<Product>> GetAll()
        {
            var result = _productDal.GetAll();
            return new SuccessDataResult<List<Product>>(result);
        }
        // SQL Ürün Id sine göre fonksiyonu
        public IDataResult<Product> GetById(int Id)
        {
            var result = _productDal.Get(p => p.Id == Id);
            return new SuccessDataResult<Product>(result);
        } 
    }
}
