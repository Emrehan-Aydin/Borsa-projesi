using DataAccess.Abstract;
using DataAccess.Core;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Entities.DTo;
 
namespace DataAccess.Concrete.EntityFramework
{
    // CashConfirmation için EntityFrameWork veri tabanı ve nesne sınıfı
    public class EfCashConfirmationDal : EfEntityRepositoryBase<CashConfirmation, BorsaGameContext>, ICashConfirmationDal
    {
        // CashConfimation Dto oluşturulması 
        public List<CashConfirmationOrderDto> GetCashConfirmationOrderDetail()
        {
            using (BorsaGameContext borsaGameContext = new BorsaGameContext())
            {
                var result = from cash in borsaGameContext.CashConfirmations
                             join accountinfo in borsaGameContext.AccountInformations
                             on cash.AccountId equals accountinfo.Id
                             select new CashConfirmationOrderDto
                             {
                                IslemNo =cash.Id,
                                Tc=accountinfo.Tc_No,
                                Ad=accountinfo.Name,
                                Soyad=accountinfo.Surname,
                                PendingCash=cash.PendingCash
                             };
                return result.ToList();
            }
        }
    }
}
