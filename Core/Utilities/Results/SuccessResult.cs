using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult:Result
    {
        public SuccessResult(string message):base(message,true)
        {
            Message = message;
        }
        public SuccessResult():base(true)
        {
        }
    }
}
