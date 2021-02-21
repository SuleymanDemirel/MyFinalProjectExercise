using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult : Result
    {
        // base'e true,mesaj gönderiyoruz
        public SuccessResult(string message) : base(true, message) 
        {

        }
        public SuccessResult() : base(true)  // base tek parametre olan, true..
        {

        }
    }
}
