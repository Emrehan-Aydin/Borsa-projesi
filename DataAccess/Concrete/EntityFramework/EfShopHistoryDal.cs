using DataAccess.Abstract;
using DataAccess.Core;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Entities.DTo;

namespace DataAccess.Concrete.EntityFramework
{
    // ShopHistory için EntityFrameWork veri tabanı ve nesne sınıfı
    public class EfShopHistoryDal : EfEntityRepositoryBase<ShopHistory, BorsaGameContext>, IShopHistoryDal
    {
        public List<TradeHistoryDetailsDto> GetTradeDetails(int Id)
        {
            using (BorsaGameContext borsaGameContext = new BorsaGameContext())
            {
                var result = from Shop in borsaGameContext.ShopHistorys
                             join buyer in borsaGameContext.AccountInformations on Shop.BuyerId equals buyer.Id
                             join seller in borsaGameContext.AccountInformations on Shop.SellerId equals seller.Id
                             join product in borsaGameContext.Products on Shop.ProductId equals product.Id
                             where Shop.BuyerId == Id || Shop.SellerId == Id
                             select new TradeHistoryDetailsDto()
                             {
                                 Date = Shop.TransactionDate,
                                  BuyerUID = buyer.Id,
                                 BuyerName = buyer.Name,
                                 BuyerSurname = buyer.Surname,
                                 SellerUID = seller.Id,
                                 SellerName = seller.Name,
                                 SellerSurname = seller.Surname,
                                 ProductName = product.ProductName,
                                 ProductCount = Shop.CountOfProduct,
                                 commission = Decimal.Round(Shop.TotalPrice / 100,2),
                                 TotalPrice = Decimal.Round(Shop.TotalPrice,2)
                             };
                return result.ToList();
            }
        }
    }
}
