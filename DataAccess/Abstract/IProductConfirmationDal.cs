using DataAccess.Core;
using Entities.Concrete;
using Entities.DTo;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    // ProductConfirmation için generic referans IEntityRepository tanımlanması
    public interface IProductConfirmationDal : IEntityRepository<ProductsConfirmation>
    { 
        // Dto Oluşturma
        List<ProductConfirmationOrderDto> GetProductConfirmationOrderDetail();
    }
}
