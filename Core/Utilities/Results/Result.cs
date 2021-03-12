using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success, string message):this(success)    //If the user enter with two parameter, the program will use this constructor and then the constructor will use also other constructor. =>"this(success)" 
        {                                                            // To not repeat itself!
            Message = message;
        }
        public Result(bool success)
        {
            Success = success;
        }
        public bool Success { get; }

        public string Message { get; }
    }
}
