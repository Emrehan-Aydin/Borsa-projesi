using DataAccess.Core;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    // AccountInformation için generic referans IEntityRepository tanımlanması
    public interface IAccountInformationDal:IEntityRepository<AccountInformation>
    { 

    }
}
