using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ShopHistoryManager : IShopHistoryService
    {
        // İş modülünün bağlı olduğu Veri Erişim yönteminin bağlılığı
        IShopHistoryDal _shopHistoryDal;
        public ShopHistoryManager(IShopHistoryDal shopHistoryDal)
        {
            _shopHistoryDal = shopHistoryDal;
        }
        // İş modülünün servis ile bağlı olduğu fonksiyonlar
        // SQL Ekleme fonksiyonu
        public IResult Add(ShopHistory shopHistory)
        {
            _shopHistoryDal.Add(shopHistory);
            return new SuccessResult();
        }
        // SQL Tümünü Listele fonksiyonu
        public IDataResult<List<ShopHistory>> GetAll()
        {
            var result = _shopHistoryDal.GetAll();
            return new SuccessDataResult<List<ShopHistory>>(result);
        }

        public IDataResult<List<TradeHistoryDetailsDto>> GetDetails(int Id)
        {
            var result = _shopHistoryDal.GetTradeDetails(Id);
            return new SuccessDataResult<List<TradeHistoryDetailsDto>>(result);
        }
    }
}
