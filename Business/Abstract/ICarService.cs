using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> Get(int id); //idye göre arıyoruz tek değer döneceği için Car türü verdik direkt liste vermedik.
        IDataResult<List<Car>> GetCarsByBrandId(int brandId);
        IDataResult<List<Car>> GetCarsByColorId(int colorId);

        IDataResult<List<CarDetailDto>> GetCarDetails(Expression<Func<Car, bool>> filter = null);

        IResult Add(Car car);
        //soru şu.. ICarServicenin Add'i aslında ICarDal'ın Addini çağırıyor ...amaç bu yani oradaki add ile buradaki add aynı şey değil.
        IResult Update(Car car);
        IResult Delete(Car car);

    }
}
