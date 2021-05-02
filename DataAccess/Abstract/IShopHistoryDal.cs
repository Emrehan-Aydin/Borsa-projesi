using DataAccess.Core;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    // ShopHistory için generic referans IEntityRepository tanımlanması
    public interface IShopHistoryDal:IEntityRepository<ShopHistory>
    {  
    }
}
