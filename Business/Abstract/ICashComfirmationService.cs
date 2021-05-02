using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICashConfirmationService
    {
        // Account cash confirmation iş modülü servisleri
        IDataResult<CashConfirmation> GetByAccount(int accountId);
        IDataResult<CashConfirmation> GetById(int confirmationId);
        IDataResult<List<CashConfirmationOrderDto>>GetCashConfirmationOrderDetail();
        IDataResult<List<CashConfirmation>> GetAll();
        IResult Add(CashConfirmation cashComfirmation);
        IResult Update(CashConfirmation cashComfirmation);
        IResult Delete(CashConfirmation cashComfirmation);
    }
}
