using System;
using System.Collections.Generic;
using System.Text;

namespace Boekje.Domain.Common.Entities
{
    // The code comes from: https://enterprisecraftsmanship.com/posts/entity-base-class/
    public abstract class Entity
    {
        virtual public long Id { get; protected set; }
        protected virtual object Actual => this;

        public override bool Equals(object obj)
        {
            var that = obj as Entity;

            if (that is null) return false;
            if (that.Actual.GetType() != this.Actual.GetType()) return false;
            if (this.Id == 0 || that.Id == 0) return false;

            return ReferenceEquals(this, that);
        }
        public static bool operator == (Entity a, Entity b)
        {
            if (a is null && b is null) return true;
            if (a is null || b is null) return false;

            return a.Equals(b);
        }

        public static bool operator != (Entity a, Entity b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return (Actual.GetType().ToString() + Id).GetHashCode();
        }
    }
}
