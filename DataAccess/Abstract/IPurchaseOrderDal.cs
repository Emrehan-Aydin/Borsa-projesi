using DataAccess.Core;
using Entities.Concrete;
using Entities.DTo;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    // PurchaseOrder için generic referans IEntityRepository tanımlanması
    public interface IPurchaseOrderDal : IEntityRepository<PurchaseOrder>
    { 
        // Dto oluşturma
        List<PurchaseOrderDto> GetPurchaseOrderDetail();
        // Belli hesaba göre Dto oluşturma
        List<PurchaseOrderDto> GetByAccountDetail(Account account);
    }
}
