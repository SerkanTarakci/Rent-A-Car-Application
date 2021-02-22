﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T:class, IEntity, new() // <T> -> bana çalışacağım tipi söyle
    {
        //ama bu T yerine her şeyi yazmamamız lazım. Veritabanı işlemleri yapacağımız için sadece Entity-Concretedeki classlar olabilmeli.
        //generic constraint uygulayacağız.Yukarıdaki where ile kısıtladık. Sadece referans tip olacak ve IEntity türünde olacak dedik.
        //new - newlenebilir olmalı demek.
        List<T> GetAll(Expression<Func<T, bool>> filter=null); //burası direk filtreleyerek işlem yapabilmemize yarıyo. (ProductManager'de mesela)
        T Get(Expression<Func<T, bool>> filter);//zorunlu
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        
        
    }
}
