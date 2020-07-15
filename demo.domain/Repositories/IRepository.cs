using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

public interface IRepository<T> where T : class
    {
        DbSet<T> DBSet();

        // Marks an entity as new
        void Add(T entity);
        // AddRange(IList<T> entities);
        // Marks an entity as modified
        //void DeleteRs(T entity);
        // Marks an entity as modified
        void Update(T entity);
        // Marks an entity to be removed
        void Delete(T entity);
        void Delete(Expression<Func<T, bool>> where);
        // Get an entity by int id
        T GetById(int id);
        // Get an entity using delegate
        T Get(Expression<Func<T, bool>> where);
        // Gets all entities of type T
        IEnumerable<T> GetAll();
        // Gets entities using delegate
        IEnumerable<T> GetMany(Expression<Func<T, bool>> where);

        void CreateRange(List<T> entities);
    }