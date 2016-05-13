using System;

namespace Carpax.Web.WebApi.Util
{
    public class Factory<T>
    {
        private readonly Func<T> _factoryFunction;

        public Factory(Func<T> factoryFunction)
        {
            _factoryFunction = factoryFunction;
        }

        public T Create()
        {
            return _factoryFunction.Invoke();
        }
    }
}