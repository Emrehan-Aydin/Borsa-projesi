using DataAccess.Abstract;
using DataAccess.Core;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    // AccountInformation için EntityFrameWork veri tabanı ve nesne sınıfı
    public class EfAccountInformationDal : EfEntityRepositoryBase<AccountInformation, BorsaGameContext>, IAccountInformationDal
    {
    }
}
