using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTo
{
    public class MyAssetsDto:IDto
    {
        public int Barkod { get; set; }
        public string ProductName { get; set; }
        public int CountOfProduct { get; set; }

    }
}
