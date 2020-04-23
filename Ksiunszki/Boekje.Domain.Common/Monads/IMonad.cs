using System;
using System.Collections.Generic;
using System.Text;

namespace Boekje.Domain.Common.Monads
{
    /// <summary>
    /// A base interface for a monad object.
    /// </summary>
    public interface IMonad<T> where T : class
    {
        public IMonad<T> Return(T value);
        public IMonad<U> Bind<U>(Func<T, IMonad<U>> func) where U : class;
    }
}
