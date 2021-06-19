using DataAccess.Core;
using Entities.Concrete;
using Entities.DTo;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    // ShopHistory için generic referans IEntityRepository tanımlanması
    public interface IShopHistoryDal : IEntityRepository<ShopHistory>
    {
        public List<TradeHistoryDetailsDto> GetTradeDetails(int Id);
    }
}
