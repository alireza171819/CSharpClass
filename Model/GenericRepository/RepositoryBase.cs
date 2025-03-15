using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Model.Context;

namespace Model.GenericRepository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        #region Filds

        protected readonly FinalProjectDbContext _dbContext = new();
        protected readonly DbSet<T> _dbset;

        #endregion

        #region Ctor

        public RepositoryBase()
        {
            
        }

        #endregion

        #region Methods

        public void Add(T objModel)
        {
            _dbContext.Set<T>().Add(objModel);
            _dbContext.SaveChanges();
        }

        public int Count()
        {
            return _dbContext.Set<T>().Count();
        }

        public T? Get(Expression<Func<T, bool>> predicate)
        {
            return _dbContext.Set<T>().FirstOrDefault(predicate);
        }

        public IEnumerable<T> GetAll()
        {
            return _dbContext.Set<T>().ToList();
        }

        public T? GetId(int id)
        {
            return _dbContext.Set<T>().Find(id);
        }

        public IEnumerable<T> GetList(Expression<Func<T, bool>> where = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderby = null, string includes = "")
        {
            IQueryable<T> query = _dbset;

            if (where != null)
            {
                query = query.Where(where);
            }

            if (orderby != null)
            {
                query = orderby(query);
            }

            if (includes != "")
            {
                foreach (string include in includes.Split(','))
                {
                    query = query.Include(include);
                }
            }

            return query.ToList();
        }

        public void Remove(T objModel)
        {
            _dbContext.Set<T>().Remove(objModel);
            _dbContext.SaveChanges();
        }

        public void Update(T objModel)
        {
            _dbContext.Entry(objModel).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        #endregion

    }
}
