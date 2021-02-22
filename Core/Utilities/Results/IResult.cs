using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    // Temel voidler için başlangıç.
    //Void fonksiyonlarda 2 türlü dönüş istiyoruz burada. 
    //1-işlem başarılı mı değil mi
    //2-işlem sonunda ekranda gösterilecek bir mesaj.
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
