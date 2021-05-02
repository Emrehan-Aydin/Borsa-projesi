using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductConfirmationService
    {
        // Account product confirmation iş modülü servisleri
        IDataResult<List<ProductsConfirmation>> GetByAccount(int accountId);
        IDataResult<ProductsConfirmation> GetById(int confirmId);
        IDataResult<List<ProductsConfirmation>> GetAll();
        IResult Add(ProductsConfirmation productConfirmation);
        IResult Update(ProductsConfirmation productConfirmation);
        IResult Delete(ProductsConfirmation productConfirmation);
        IDataResult<List<ProductConfirmationOrderDto>> GetProductsConfirmationDetail();
    }
}
