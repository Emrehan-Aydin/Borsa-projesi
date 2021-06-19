using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class CashConfirmation:IEntity
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public decimal PendingCash { get; set; }
    }
}
