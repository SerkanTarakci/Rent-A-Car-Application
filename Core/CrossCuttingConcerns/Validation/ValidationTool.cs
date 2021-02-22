using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcerns.Validation
{
    public static class ValidationTool
    {
        public static void Validate(IValidator validator, object entity)
        {

            var context = new ValidationContext<object>(entity);
            //bir entity için doğrulama yapacağım. Çalışacağım tip de parametremden gelen entity.

            // üstteki contexti nasıl doğrulayacağım? IValidator türünden validatoru kullanarak. (bizim car validator)
            var result = validator.Validate(context);
            //üstteki yorumda yazdığımız işlemi yapıyoruz yani parametre ile verdiğimiz car objesini
            //carvalidator ile doğruluyoruz ve sonucu result diye bir değişkene atıyoruz.

            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
