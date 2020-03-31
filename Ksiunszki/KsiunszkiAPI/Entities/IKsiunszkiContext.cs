using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KsiunszkiAPI.Entities
{
    interface IKsiunszkiContext
    {
        public void BeginTransaction();
        public void CommitChanges();
        public void Rollback();
    }
}
