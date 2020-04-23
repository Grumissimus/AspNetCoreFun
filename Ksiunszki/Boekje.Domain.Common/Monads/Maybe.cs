using System;
using System.Collections.Generic;
using System.Text;

namespace Boekje.Domain.Common.Monads
{
    public class Maybe<T> : IMonad<T> where T : class
    {
        private readonly T value;
        public Maybe(T value)
        {
            this.value = value;
        }

        private Maybe()
        {
        }

        public IMonad<U> Bind<U>(Func<T, IMonad<U>> func) where U : class
        {
            return value != null ? func(value) : Maybe<U>.Nothing();
        }

        public IMonad<T> Return(T value)
        {
            return new Maybe<T>(value);
        }

        public static Maybe<T> Nothing() => new Maybe<T>();
    }
}
