using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using WebApiDemo.Interfaces;

namespace WebApiDemo.Repositories
{
    public abstract class BaseRepository<T> : IRepository<T> where T : class
    {
        private const string ConnectionString = "your connection string here";

        protected readonly IDbConnection connection;

        public BaseRepository()
        {

        }

        public abstract void Delete(T item);
        public abstract IEnumerable<T> Find(Expression<Func<T, bool>> query);
        public abstract IEnumerable<T> Get();
        public abstract T Get(int id);
        public abstract void Post(T item);
        public abstract void Put(T item);
    }
}