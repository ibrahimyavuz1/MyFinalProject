using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Beginning for standart void operations
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
