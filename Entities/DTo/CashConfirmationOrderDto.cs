using Entities.Abstract;
namespace Entities.DTo
{
    public class CashConfirmationOrderDto : IDto
    {
        public int IslemNo { get; set; }
        public string Tc { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public decimal PendingCash { get; set; }
    }
}