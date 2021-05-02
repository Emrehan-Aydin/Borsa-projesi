using DataAccess.Abstract;
using DataAccess.Core;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{ 
    // Product için EntityFrameWork veri tabanı ve nesne sınıfı
    public class EfProductDal:EfEntityRepositoryBase<Product, BorsaGameContext>, IProductDal
    {
    }
}
