using Entities.Abstract;

namespace Entities.DTo
{
    public class SaleOrderDto : IDto
    {
        public int IslemNo { get; set; }
        public string ProductName { get; set; }
        public int UnitPrice { get; set; }
        public int CountOfProduct { get; set; }
        public int UserId { get; set; }
        public string SellerAd { get; set; }
        public string Sellersoyad { get; set; }
    }
}
