using DataAccess.Core;
using Entities.Concrete;
using Entities.DTo;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    // SaleOrder için generic referans IEntityRepository tanımlanması
    public interface ISaleOrderDal : IEntityRepository<SaleOrder>
    {
        // Dto Oluşturma
        List<SaleOrderDto> GetSaleOrderDetail();
        // Hesaba göre Dto Oluşturma
        List<SaleOrderDto>  GetByAccountDetails(Account account);
    }
}
