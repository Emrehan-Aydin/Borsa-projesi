using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IPurchaseOrderService
    {
        // Pruchase Order iş modülü servisleri
        IDataResult<List<PurchaseOrderDto>> GetPurchaseOrderDetail();
        IDataResult<List<PurchaseOrderDto>> GetByAccountDetail(Account account);
        IDataResult<PurchaseOrder> GetById(int Id);
        IDataResult<List<PurchaseOrder>> GetByAccount(int Id);
        IDataResult<List<PurchaseOrder>> GetAll();
        IResult Add(PurchaseOrder purchaseOrder);
        IResult Update(PurchaseOrder purchaseOrder);
        IResult Delete(PurchaseOrder purchaseOrder);
    }
}
