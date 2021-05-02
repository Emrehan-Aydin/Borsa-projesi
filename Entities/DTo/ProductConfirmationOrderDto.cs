using Entities.Abstract;

namespace Entities.DTo
{
    public class ProductConfirmationOrderDto : IDto
    {
        public int IslemNo { get; set; }
        public string Tc { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string ProductName { get; set; }
        public int CountOfProduct { get; set; }

    }
}