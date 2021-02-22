﻿using Castle.DynamicProxy;
using System;

namespace Core.Utilities.Interceptors
{
    public abstract class MethodInterception : MethodInterceptionBaseAttribute
    {
        protected virtual void OnBefore(IInvocation invocation) { }
        protected virtual void OnAfter(IInvocation invocation) { }
        protected virtual void OnException(IInvocation invocation, System.Exception e) { }
        protected virtual void OnSuccess(IInvocation invocation) { }
        public override void Intercept(IInvocation invocation)
        {
            var isSuccess = true;
            OnBefore(invocation); //invocation dediğimiz mesela Add metodumuz. On before diyince başta çalıştırıyor.
            try
            {
                invocation.Proceed();
            }
            catch (Exception e)
            {
                isSuccess = false;
                OnException(invocation, e); //hata olursa on exceptionda...
                throw;
            }
            finally
            {
                if (isSuccess)
                {
                    OnSuccess(invocation); //işlem başarılı olduğunda
                }
            }
            OnAfter(invocation); //işlem sonunda
        }
    }
}
