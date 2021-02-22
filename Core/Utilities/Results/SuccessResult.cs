using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult : Result
    {
        public SuccessResult(string message) : base(true, message) //basee bunları göndder
        {

        }

        public SuccessResult() : base(true) //basein tek parametreli olanını çalıştır
        {

        }
    }
}
