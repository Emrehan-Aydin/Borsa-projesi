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
    public class PurchaseOrderManager : IPurchaseOrderService
    {
        IPurchaseOrderDal _purchaseOrderDal;
        public PurchaseOrderManager(IPurchaseOrderDal purchaseOrderDal)
        {
            _purchaseOrderDal = purchaseOrderDal;
        }
        // İş modülünün servis ile bağlı olduğu fonksiyonlar
        // SQL Ekleme fonksiyonu
        public IResult Add(PurchaseOrder purchaseOrder)
        {
            _purchaseOrderDal.Add(purchaseOrder);
            return new SuccessResult("İşleme Alındı!");
        }
        // SQL Silme fonksiyonu
        public IResult Delete(PurchaseOrder purchaseOrder)
        {
            _purchaseOrderDal.Delete(purchaseOrder);
            return new SuccessResult("İşleme silindi!");
        }
        // SQL Güncelleme fonksiyonu
        public IResult Update(PurchaseOrder purchaseOrder)
        {
            _purchaseOrderDal.Update(purchaseOrder);
            return new SuccessResult("İşlem güncellendi!");
        }
        // SQL Tümünü Listele fonksiyonu
        public IDataResult<List<PurchaseOrder>> GetAll()
        {
            var result = _purchaseOrderDal.GetAll();
            return new SuccessDataResult<List<PurchaseOrder>>(result);
        }
        // SQL İşlem Numarasına göre getir fonksiyonu
        public IDataResult<PurchaseOrder> GetById(int Id)
        {
            var result = _purchaseOrderDal.Get(Po => Po.Id == Id);
            return new SuccessDataResult<PurchaseOrder>(result);
        }
        // SQL DTo tümünü getir fonksiyonu
        public IDataResult<List<PurchaseOrderDto>> GetPurchaseOrderDetail()
        {
            var result = _purchaseOrderDal.GetPurchaseOrderDetail();
            return new SuccessDataResult<List<PurchaseOrderDto>>(result);
        }
        // SQL Dto Hesaba göre getir fonksiyonu
        public IDataResult<List<PurchaseOrderDto>> GetByAccountDetail(Account account)
        {
            var result = _purchaseOrderDal.GetByAccountDetail(account);
            return new SuccessDataResult<List<PurchaseOrderDto>>(result);
        }
        // SQL Hesaba göre Getir fonksiyonu
        public IDataResult<List<PurchaseOrder>> GetByAccount(int Id)
        {
            var result = _purchaseOrderDal.GetAll(Po => Po.BuyerId == Id);
            return new SuccessDataResult<List<PurchaseOrder>>(result);
        }
    }
}
