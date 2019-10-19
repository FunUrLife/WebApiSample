using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WebApiDemo.Interfaces
{
    interface IRepository<T> where T : class
    {
        IEnumerable<T> Get();
        IEnumerable<T> Find(Expression<Func<T, bool>> query);
        T Get(int id);
        void Post(T item);
        void Put(T item);
        void Delete(T item);
    }
}
