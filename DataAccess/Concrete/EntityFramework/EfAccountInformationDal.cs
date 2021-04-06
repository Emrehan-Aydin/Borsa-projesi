using DataAccess.Abstract;
using DataAccess.Core;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfAccountInformationDal : EfEntityRepositoryBase<AccountInformation, BorsaGameContext>, IAccountInformationDal
    {


    }
}
