using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Linq;

namespace ShopBusiness
{
    public class CheckShop
    {
        // Alım ve Satım işlemleri için varlık nesnelerinin yönetim nesneleri
        SaleOrderManager saleOrderManager = new SaleOrderManager(new EfSaleOrderDal());
        PurchaseOrderManager purchaseOrderManager = new PurchaseOrderManager(new EfPurchaseOrderDal());
        AccountFinanceManager accountFinanceManager = new AccountFinanceManager(new EfAccountFinanceDal());
        AccountAssetManager accountAssetManager = new AccountAssetManager(new EfAccountAssetDal());

        public void checkSaleAndPurchase()
        {
            // Alım istekleri ve satım istekleri karşılaştırılma emri
            foreach (var purchases in purchaseOrderManager.GetAll().Data) //Alım emirleri
            {
                var buyer = accountFinanceManager.GetByAccount(purchases.BuyerId).Data;
                foreach (var sales in saleOrderManager.GetByProductId(purchases.ProductId).Data.OrderBy(p => p.UnitPrice).ToList()) // İlgili satış emirleri
                {
                    if (purchases.BuyerId == sales.SellerId)
                    {
                        continue;
                    }
                    int count = 0, checkMoney = 0; // Satın Alınan ürün ve tutar değeri
                    for (int i = 0; i < sales.StockOfProduct; i++)
                    {
                        // Satın Alınan miktar ve tutar değeri hesaplaması
                        count++;
                        checkMoney += sales.UnitPrice;

                        if (checkMoney > buyer.Cash) // Tutar kontrolü
                        {
                            checkMoney -= sales.UnitPrice;
                            count--;
                            break;
                        }
                        else
                        {
                            purchases.Count--;
                            if (purchases.Count <= 0) // Alınacak ürün miktar kontrolü
                            {
                                break;
                            }
                        }
                    }
                    if (count <= 0)
                    {
                        break;
                    }
                    else
                    {
                        buy(count, checkMoney, purchases, sales);
                        if (purchases.Count <= 0) //Alınacak ürün miktar kontrolü
                        {
                            break;
                        }
                    }
                }
            }
        }
        public void buy(int count, int checkMoney, PurchaseOrder purchase, SaleOrder sale)
        {
            // satın alınan varlık
            AccountAsset buyyerAsset = new AccountAsset
            {
                AccountId = purchase.BuyerId,
                ProductId = purchase.ProductId,
                ProductOfStock = count
            };
            accountAssetManager.Add(buyyerAsset);

            // güncellenen ilanlar
            sale.StockOfProduct -= count;
            saleOrderManager.Update(sale);
            purchaseOrderManager.Update(purchase);

            //para aktarımı
            AccountFinance buyer = accountFinanceManager.GetByAccount(purchase.BuyerId).Data;
            buyer.Cash -= checkMoney;
            accountFinanceManager.Update(buyer);
            AccountFinance seller = accountFinanceManager.GetByAccount(sale.SellerId).Data;
            seller.Cash += checkMoney;
            accountFinanceManager.Update(seller);
            // Log geçmiş veri tutulma fonksiyonu
            log(count, checkMoney, purchase, sale);
        }

        public void log(int count, int checkMoney, PurchaseOrder purchase, SaleOrder sale)
        {
            // İlgili log işlemin veritabanı kayıt işlemi
            ShopHistoryManager shopHistoryManager = new ShopHistoryManager(new EfShopHistoryDal());
            ShopHistory shopHistory = new ShopHistory
            {
                BuyerId = purchase.BuyerId,
                SellerId = sale.SellerId,
                ProductId = purchase.ProductId,
                CountOfProduct = count,
                TotalPrice = count * sale.UnitPrice
            };
            shopHistoryManager.Add(shopHistory);
        }
    }
}
