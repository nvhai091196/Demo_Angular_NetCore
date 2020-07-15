using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace demo.domain.Repositories
{
    public abstract class RepositoryBase<T> where T : class
    {
        #region Properties
        private DbEntities dataContext;
        private readonly DbSet<T> dbSet;

        #endregion

        protected RepositoryBase(DbEntities dbContext)
        {
            dataContext = dbContext;
            dbSet = dataContext.Set<T>();
        }

        #region Implementation

        public virtual DbSet<T> DBSet()
        {
            return dbSet;
        }

        public virtual void Add(T entity)
        {
            try
            {
                dbSet.Add(entity);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
            }

        }

        public virtual void Update(T entity)
        {
            dbSet.Attach(entity);
            dataContext.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(T entity)
        {
            dbSet.Remove(entity);
        }

        public virtual void Delete(Expression<Func<T, bool>> where)
        {
            IEnumerable<T> objects = dbSet.Where<T>(where).AsEnumerable();
            foreach (T obj in objects)
                dbSet.Remove(obj);
        }

        public virtual T GetById(int id)
        {
            return dbSet.Find(id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return dbSet.AsNoTracking().ToList();
        }

        public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> where)
        {
            return dbSet.Where(where).ToList();
        }

        public T Get(Expression<Func<T, bool>> where)
        {
            return dbSet.Where(where).FirstOrDefault<T>();
        }

        public virtual void CreateRange(List<T> entities)
        {
            dbSet.AddRange(entities);
        }
        #endregion
    }
}
