using Api.Business.RepositoryInterfaces;
using Api.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Api.Business.Repositories
{
    public class GenericRepository<T> : IGenericInterfce<T> where T : class
    {

        protected readonly ApiDbContext _context;
        private readonly DbSet<T> _set;

        public GenericRepository(ApiDbContext context)
        {
            _context = context;
            _set = _context.Set<T>();
        }

        public void Add(T entity)
        {

            _set.Add(entity);
        }

        public void Delete(T entity)
        {
            _set.Remove(entity);
        }

        public void Edit(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public System.Linq.IQueryable<T> Find(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = _set.Where(predicate);
            return query;
        }

        public System.Linq.IQueryable<T> GetAll()
        {
            IQueryable<T> query = _set;
            return query;
        }

        public void Save()
        {
            _context.SaveChanges();
        }
        
    }
}
