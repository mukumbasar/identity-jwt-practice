using DAL.Abstracts;
using DAL.Contexts;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UnitOfWork
{
    public class Uow : IUow
    {
        private readonly AppDbContext _context;

        public Uow(AppDbContext context)
        {
            _context = context;
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        IRepository<T> IUow.GetRepository<T>()
        {
            return new GenericRepository<T>(_context);
        }
    }
}
