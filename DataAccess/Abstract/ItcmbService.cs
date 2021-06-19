using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ItcmbService
    {
        List<string> GetUnit();
        decimal getUnitValue(int UnitId);

    }
}
