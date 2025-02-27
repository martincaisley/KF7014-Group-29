﻿/*
 * Martin Caisley:17015608
 * Drummond Heckles:17005997
 * Mark Burns:16016013
 */
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team29_Group_Project
{
    /*
     * Method of implementing repository design pattern learned from:
     * https://codewithshadman.com/repository-pattern-csharp/
     * https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions/getting-started-with-ef-5-using-mvc-4/implementing-the-repository-and-unit-of-work-patterns-in-an-asp-net-mvc-application
     */
    public interface IRepository<T>
    {
        void Add(T entity);
        T GetByID(int id);
        IEnumerable<T> GetAll();
        void Remove(T entity);
        void Update(T entity);
    }
    public class Repository<T> : IRepository<T> where T : class
    {
        private MyDBEntities context;

        public Repository(MyDBEntities context)
        {
            this.context = context;
        }

        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public T GetByID(int id)
        {
            return context.Set<T>().Find(id);
        }

        public void Remove(T entity)
        {
            context.Set<T>().Remove(entity);
        }

        public void Update(T entity)
        {
            context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }
    }
   

}
