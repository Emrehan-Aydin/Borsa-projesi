using DataAccess.Core;
using Entities.Concrete;
using Entities.DTo;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    // AccountAsset için generic referans IEntityRepository tanımlanması
    public interface IAccountAssetDal : IEntityRepository<AccountAsset>
    {
        // Dto Oluşturma
        List<MyAssetsDto> GetAssetDetail(int accountId);
    }
}
