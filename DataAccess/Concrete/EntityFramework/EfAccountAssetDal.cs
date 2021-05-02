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
    // AccountAsset için EntityFrameWork veri tabanı ve nesne sınıfı
    public class EfAccountAssetDal:EfEntityRepositoryBase<AccountAsset, BorsaGameContext>, IAccountAssetDal
    {
        public List<MyAssetsDto> GetAssetDetail(int accountId)
        {
            // GetAssetDetail Dto SQL sorgusu 
            using (BorsaGameContext borsaGameContext = new BorsaGameContext())
            {
                var result = from asset in borsaGameContext.AccountAssets
                             join product in borsaGameContext.Products
                             on asset.ProductId equals product.Id
                             where asset.AccountId == accountId
                             select new MyAssetsDto
                             {
                                 Barkod = asset.Id,
                                 ProductName = product.ProductName,
                                 CountOfProduct = asset.ProductOfStock
                             };

                return result.ToList();
            }

        }
    }
}
