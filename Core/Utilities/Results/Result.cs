using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
                                       // result'un tek parametreli constructırına succces'i yolla ve onu da çalıştır
        public Result(bool success, string message) : this(success)
        {
            Message = message;
           
        }

        public Result(bool success) //ovearload
        {
            Success = success;
        }


        // Getter'lar readonly'dir constructır dışında da set edilebilir.
        public bool Success { get; }

        public string Message { get; }
    }
}
