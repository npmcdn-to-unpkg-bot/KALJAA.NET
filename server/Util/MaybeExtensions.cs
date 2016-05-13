using System;
using System.Collections.Generic;
using System.Linq;

namespace Carpax.Web.WebApi.Util
{
    public static class MaybeExtensions
    {
        public static Maybe<TOut> AsMaybe<TOut>(this TOut item)
        {
            return new Maybe<TOut>(item);
        }

        public static Maybe<TOut> NullAsEmpty<TOut>(this TOut item)
        {
            if (item == null)
                return Maybe<TOut>.Empty();
            return item.AsMaybe();
        }

        public static Maybe<TOut> AsMaybe<TOut>(this IEnumerable<TOut> items)
        {
            if (items.Count() > 1)
                throw new InvalidOperationException($"Tried to convert IEnumerable<{typeof(TOut)}> as Maybe, however list contained more than single element.");

            if (items.Count() == 1)
                return new Maybe<TOut>(items.Single());

            return Maybe<TOut>.Empty();
        }
    }
}