﻿using DataAccess.Core;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IAccountDal:IEntityRepository<Account>
    {
    }
}
