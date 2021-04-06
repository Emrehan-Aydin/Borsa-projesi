using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class AccountInformation:IEntity
    {
        public int Id { get; set; }
        public string Tc_No { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TelNo { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }
    }
}
