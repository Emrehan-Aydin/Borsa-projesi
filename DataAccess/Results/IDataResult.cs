using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    // Sistem mesajları ve Veri Yolu generic Referans
    public interface IDataResult<T>:IResult
    {
        T Data { get; }
    }
}
