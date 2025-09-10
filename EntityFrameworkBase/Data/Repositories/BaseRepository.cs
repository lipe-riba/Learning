using System;
using System.Data;
using System.Linq;
using EntityFrameworkBase.Data.Contexts;
using EntityFrameworkBase.Data.Entities;

namespace EntityFrameworkBase.Data.Repositories
{
    public abstract class BaseRepository
    {
        public BaseRepository(BaseContext context)
        {
            _context = context;
        }

        public T Get<T>(params object[] keys)
            where T : BaseEntity
        {
            return _context.Set<T>().Find(keys);
        }

        public IQueryable<T> GetAll<T>()
            where T : BaseEntity
        {
            return _context.Set<T>().AsQueryable();
        }

        public T Update<T>(T obj, params object[] keys)
            where T : BaseEntity
        {
            try
            {
                T newObj = _context.Set<T>().Find(keys);
                if (newObj == null)
                {
                    _context.Set<T>().Add(obj);
                }
                else
                {
                    _context.Entry<T>(newObj).CurrentValues.SetValues(obj);
                }
                _context.SaveChanges();
                return newObj;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete<T>(T obj)
            where T : BaseEntity
        {
            try
            {
                _context.Entry<T>(obj).State = System.Data.Entity.EntityState.Deleted;
                return (_context.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private BaseContext _context;
    }
}
