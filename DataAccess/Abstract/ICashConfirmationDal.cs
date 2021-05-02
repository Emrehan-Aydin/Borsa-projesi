using DataAccess.Core;
using Entities.Concrete;
using Entities.DTo;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    // CashConfirmation için generic referans IEntityRepository tanımlanması
    public interface ICashConfirmationDal : IEntityRepository<CashConfirmation>
    { 
        // Dto Çağırma
        List<CashConfirmationOrderDto> GetCashConfirmationOrderDetail();
    }
}
