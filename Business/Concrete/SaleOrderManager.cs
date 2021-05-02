using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Business.Concrete
{
    public class SaleOrderManager : ISaleOrderService
    {
        // İş modülünün bağlı olduğu Veri Erişim yönteminin bağlılığı
        ISaleOrderDal _saleOrderDal;
        public SaleOrderManager(ISaleOrderDal saleOrderDal)
        {
            _saleOrderDal = saleOrderDal;
        }
        // İş modülünün servis ile bağlı olduğu fonksiyonlar
        // SQL Ekleme fonksiyonu
        public IResult Add(SaleOrder saleOrder)
        {
            _saleOrderDal.Add(saleOrder);
            return new SuccessResult("İşleme Alındı!");
        }
        // SQL Silme fonksiyonu
        public IResult Delete(SaleOrder saleOrder)
        {
            _saleOrderDal.Delete(saleOrder);
            return new SuccessResult("İşleme silindi!");
        }
        // SQL Tümünü Listele fonksiyonu
        public IDataResult<List<SaleOrder>> GetAll()
        {
            var result = _saleOrderDal.GetAll();
            return new SuccessDataResult<List<SaleOrder>>(result);
        }
        // SQL İşlem numarasına göre getir fonksiyonu
        public IDataResult<SaleOrder> GetById(int Id)
        {
            var result = _saleOrderDal.Get(So=>So.Id==Id);
            return new SuccessDataResult<SaleOrder>(result);
        }
        // SQL Dto  tümünü getir fonksiyonu
        public IDataResult<List<SaleOrderDto>> GetDetails()
        {
            var result = _saleOrderDal.GetSaleOrderDetail();
            return new SuccessDataResult<List<SaleOrderDto>>(result);
        }
        // SQL Dto hesaba göre getir fonksiyonu
        public IDataResult<List<SaleOrderDto>> GetByAccountDetails(Account account)
        {
            var result = _saleOrderDal.GetByAccountDetails(account);
            return new SuccessDataResult<List<SaleOrderDto>>(result);
        }
        // SQL güncelleme fonksiyonu
        public IResult Update(SaleOrder saleOrder)
        {
            _saleOrderDal.Update(saleOrder);
            return new SuccessResult("İşleme güncellendi!");
        }
        // SQL ürün Numarasına göre getir fonksiyonu
        public IDataResult<List<SaleOrder>> GetByProductId(int productId)
        {
            var result = _saleOrderDal.GetAll(p=>p.ProductId==productId);
            return new SuccessDataResult<List<SaleOrder>>(result);
        }
    }
}
