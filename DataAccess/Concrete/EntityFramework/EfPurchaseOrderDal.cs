using DataAccess.Abstract;
using DataAccess.Core;
using Entities.Concrete;
using Entities.DTo;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{ 
    // PurchaseOrder için EntityFrameWork veri tabanı ve nesne sınıfı
    public class EfPurchaseOrderDal : EfEntityRepositoryBase<PurchaseOrder, BorsaGameContext>, IPurchaseOrderDal
    {
        // PurchaseOrder Dto su oluşturulması
        public List<PurchaseOrderDto> GetPurchaseOrderDetail()
        {
            using (BorsaGameContext borsaGameContext = new BorsaGameContext())
            {
                var result = from purchase in borsaGameContext.PurchaseOrders
                             join accountinfo in borsaGameContext.AccountInformations
                             on purchase.BuyerId equals accountinfo.Id
                             join product in borsaGameContext.Products
                             on purchase.ProductId equals product.Id
                             select new PurchaseOrderDto
                             {
                                 IslemNo = purchase.Id,
                                 ProductName = product.ProductName,
                                 CountOfProduct = purchase.Count,
                                 UserId = accountinfo.Id,
                                 Buyerad = accountinfo.Name,
                                 Buyersoyad = accountinfo.Surname
                             };

                return result.ToList();
            }
        }
        // PurchaseOrder Hesaba göre Dto oluşturulması
        public List<PurchaseOrderDto> GetByAccountDetail(Account account)
        {
            using (BorsaGameContext borsaGameContext = new BorsaGameContext())
            {
                var result = from purchase in borsaGameContext.PurchaseOrders
                             join accountinfo in borsaGameContext.AccountInformations
                             on purchase.BuyerId equals accountinfo.Id
                             join product in borsaGameContext.Products
                             on purchase.ProductId equals product.Id
                             where account.Id==accountinfo.Id
                             select new PurchaseOrderDto
                             {
                                 IslemNo = purchase.Id,
                                 ProductName = product.ProductName,
                                 CountOfProduct = purchase.Count,
                                 UserId = accountinfo.Id,
                                 Buyerad = accountinfo.Name,
                                 Buyersoyad = accountinfo.Surname
                             };

                return result.ToList();
            }
        }
    }
}
