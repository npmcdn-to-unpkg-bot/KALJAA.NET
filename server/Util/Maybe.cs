using System.Collections;
using System.Collections.Generic;

namespace Carpax.Web.WebApi.Util
{
    public class Maybe<T> : IEnumerable<T>
    {
        private readonly bool _hasValue;
        private readonly T _value;

        public Maybe(T value)
        {
            _hasValue = true;
            _value = value;
        }

        private Maybe()
        {
        }

        public static Maybe<T> Empty()
        {
            return new Maybe<T>();
        }

        public IEnumerator<T> GetEnumerator()
        {
            if (_hasValue)
                yield return _value;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            if(_hasValue)
                yield return _value;
        }
    }
}