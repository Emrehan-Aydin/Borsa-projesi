using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IShopHistoryService
    {
        // Shop History iş modülü servisleri
        IResult Add(ShopHistory shopHistory);
        IDataResult<List<ShopHistory>> GetAll();

        IDataResult<List<TradeHistoryDetailsDto>> GetDetails(int Id);
    }
}
