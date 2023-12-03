using DAL.Abstracts;
using DAL.Contexts;
using Entity.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class, IEntity
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public T? Get(System.Linq.Expressions.Expression<Func<T, bool>> filter)
        {
            return _dbSet.Where(filter).FirstOrDefault();
        }

        public T? Get(object id)
        {
            return _dbSet.Find(id);
        }

        public List<T> GetAll(bool noTracking = true)
        {
            return noTracking ?
                     _dbSet.AsNoTracking().ToList() :
                     _dbSet.ToList();
        }

        public List<T> GetAll(System.Linq.Expressions.Expression<Func<T, bool>> filter)
        {
            return _dbSet.Where(filter).ToList();
        }

        public IQueryable<T> GetQueryable()
        {
            return _dbSet.AsQueryable<T>();
        }
        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }
    }
}
