using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class SaleOrder:IEntity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int StockOfProduct { get; set; }
        public decimal UnitPrice { get; set; }
        public int SellerId { get; set; }

    }
}
