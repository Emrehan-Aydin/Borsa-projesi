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
    // SaleOrderDal için EntityFrameWork veri tabanı ve nesne sınıfı
    public class EfSaleOrderDal : EfEntityRepositoryBase<SaleOrder, BorsaGameContext>, ISaleOrderDal
    {
        // SaleOrder için hesaba göre Dto Oluşturulması
        public List<SaleOrderDto> GetByAccountDetails(Account account)
        {
            using (BorsaGameContext borsaGameContext = new BorsaGameContext())
            {
                var result = from sales in borsaGameContext.SaleOrders
                             join accountinfo in borsaGameContext.AccountInformations
                             on sales.SellerId equals accountinfo.Id
                             join product in borsaGameContext.Products
                             on sales.ProductId equals product.Id
                             where account.Id == accountinfo.Id
                             select new SaleOrderDto
                             {
                                 IslemNo = sales.Id,
                                 ProductName = product.ProductName,
                                 CountOfProduct = sales.StockOfProduct,
                                 UnitPrice = Decimal.Round(sales.UnitPrice,2),
                                 UserId = accountinfo.Id,
                                 SellerAd = accountinfo.Name,
                                 Sellersoyad = accountinfo.Surname
                             };

                return result.ToList();
            }
        }
        // SaleOrder için Dto oluşturulması
        public List<SaleOrderDto> GetSaleOrderDetail()
        {
            using (BorsaGameContext borsaGameContext = new BorsaGameContext())
            {
                var result = from sales in borsaGameContext.SaleOrders
                             join accountinfo in borsaGameContext.AccountInformations
                             on sales.SellerId equals accountinfo.Id
                             join product in borsaGameContext.Products
                             on sales.ProductId equals product.Id
                             select new SaleOrderDto
                             {
                                 IslemNo = sales.Id,
                                 ProductName = product.ProductName,
                                 CountOfProduct = sales.StockOfProduct,
                                 UnitPrice = Decimal.Round(sales.UnitPrice, 2),
                                 UserId = accountinfo.Id,
                                 SellerAd = accountinfo.Name,
                                 Sellersoyad = accountinfo.Surname
                             };

                return result.ToList();
            }
        }
    }
}
