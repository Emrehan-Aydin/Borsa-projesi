using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTo
{
    public class PurchaseOrderDto:IDto
    {
        public int IslemNo { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int CountOfProduct { get; set; }
        public int UserId { get; set; }
        public string Buyerad { get; set; }
        public string Buyersoyad { get; set; }
    }
}
