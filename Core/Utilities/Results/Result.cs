using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success, string message) : this(success) //Resultun tek parametreli constructorunu çalıştır
        {
            Message = message;
        }
        //eğer constructora sadece success parametresi verirsek alttaki çalışır.
        //hem success hem mesaj parametresi verirsek üstteki çalışır ama altaki successi de çalıştırır.
        //kod tekrarı yapmamak için bu şekilde yaptık
        //burada this Result classını temsil ediyor. this(success) = Result'un tek parametreli(success) constructoru
        public Result(bool success)
        {
            Success = success;
        }
        public bool Success { get; }
        public string Message { get; } //getterlar read onlydir ve bunlar constructorda set edilebilir. Bu yüzden setter koymadık. Sadece constructorda set edilsin.
    }
}
