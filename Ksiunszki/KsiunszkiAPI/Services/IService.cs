using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public interface IService<T>
    {
        public T Read(int id);
        public void Create(T entity);
        public void Update(int id, T entity);
        public void Delete(int id);
    }
}
