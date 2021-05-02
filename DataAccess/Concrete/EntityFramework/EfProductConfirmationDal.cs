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
    // ProductConfirmation için EntityFrameWork veri tabanı ve nesne sınıfı
    public class EfProductConfirmationDal:EfEntityRepositoryBase<ProductsConfirmation, BorsaGameContext>, IProductConfirmationDal
    {
        // ProductConfirmation için DTO oluşturulması
        public List<ProductConfirmationOrderDto> GetProductConfirmationOrderDetail()
        {
            using (BorsaGameContext borsaGameContext = new BorsaGameContext())
            {
                var result = from products in borsaGameContext.ProductsConfirmations
                             join productinfo in borsaGameContext.Products
                             on products.ProductId equals productinfo.Id
                             join accountinfo in borsaGameContext.AccountInformations
                             on products.AccountId equals accountinfo.Id
                             select new ProductConfirmationOrderDto
                             {
                                IslemNo=products.Id,
                                Tc=accountinfo.Tc_No,
                                Ad=accountinfo.Name,
                                Soyad=accountinfo.Surname,
                                ProductName=productinfo.ProductName,
                                CountOfProduct=products.CountOfProduct
                             };
                return result.ToList();
            }
        }
    }
}
