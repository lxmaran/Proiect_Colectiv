using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class BaseEntityRepository<T> : IBaseRepository<T> where  T: class, IBaseEntity
    {
        private readonly IMyDbContext _context;
        private IDbSet<T> _entities;

        public BaseEntityRepository(IMyDbContext context)
        {
            this._context = context;
        }

        private IDbSet<T> Entities
        {
            get
            {
                if (_entities == null)
                {
                    _entities = _context.Set<T>();
                }
                return _entities;
            }
        }

        public void Delete(T entity)
        {
            this.Entities.Remove(entity);
            _context.SaveChanges();
        }

        public IQueryable<T> GetAll()
        {
            return this.Entities;
        }

        public T GetById(int id)
        {
            return this.Entities.Find(id);
        }

        public void Insert(T entity)
        {
            this.Entities.Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            this._context.SaveChanges();
        }
    }
}
