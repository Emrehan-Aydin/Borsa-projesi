using DataAccess.Abstract;
using DataAccess.Core;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    // ShopHistory için EntityFrameWork veri tabanı ve nesne sınıfı
    public class EfShopHistoryDal :EfEntityRepositoryBase<ShopHistory, BorsaGameContext>, IShopHistoryDal
    {
    }
}
