using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class AccountFinance:IEntity
    {
        public int Id { get; set; }
        public int Cash { get; set; }
    }
}
