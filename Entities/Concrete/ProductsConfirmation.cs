using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class ProductsConfirmation:IEntity
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int ProductId { get; set; }
        public int CountOfProduct { get; set; }
    }
}
