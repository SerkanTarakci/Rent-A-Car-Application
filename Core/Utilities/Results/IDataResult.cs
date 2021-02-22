using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IDataResult<T> : IResult
    {
        //bunda da success ve mesaj verileri olacak onlara ek olarak dönüş datası olcak yani 3 şey döndürüyoruz gibi.
        T Data { get; }
    }
}
