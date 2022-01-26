using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public Result(string message,bool success):this(success)
        {
            Message = message;
        }
        public Result(bool success)
        {
            IsSuccess = success;
        }
    }
}
