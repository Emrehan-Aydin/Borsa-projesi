using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ISaleOrderService
    {
        // SaleOrder  iş modülü servisleri
        IDataResult<SaleOrder> GetById(int Id);
        IDataResult<List<SaleOrder>> GetByProductId(int productId);
        IDataResult<List<SaleOrder>> GetAll();
        IResult Add(SaleOrder saleOrder);
        IResult Update(SaleOrder saleOrder);
        IResult Delete(SaleOrder saleOrder);
        IDataResult<List<SaleOrderDto>> GetDetails();
        IDataResult<List<SaleOrderDto>> GetByAccountDetails(Account account);
    }
}
