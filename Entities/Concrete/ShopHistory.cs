using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class ShopHistory:IEntity
    {
        public int Id { get; set; }
        public int BuyerId { get; set; }
        public int SellerId { get; set; }
        public int ProductId { get; set; }
        public int CountOfProduct { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}
