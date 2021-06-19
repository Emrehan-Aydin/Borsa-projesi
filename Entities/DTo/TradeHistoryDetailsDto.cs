using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTo
{
    public class TradeHistoryDetailsDto : IDto
    {
        public DateTime Date { get; set; }
        public int BuyerUID { get; set; }
        public string BuyerName { get; set; }
        public string BuyerSurname { get; set; }

        public int SellerUID { get; set; }
        public string SellerName { get; set; }
        public string SellerSurname { get; set; }

        public string ProductName { get; set; }
        public int ProductCount { get; set; }

        public decimal TotalPrice { get; set; }
        public decimal commission { get; set; }

    }
}
