using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    // Sistem mesajları generic Referans
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
