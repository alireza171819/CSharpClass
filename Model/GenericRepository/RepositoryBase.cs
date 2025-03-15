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
            try
            {
                if (objModel is not null)
                {
                    _dbContext.Set<T>().Add(objModel);
                    _dbContext.SaveChanges();
                }
            }
            catch (Exception exp)
            {

                throw;
            }
            finally
            {

            }
           
        }

        public int Count()
        {
            return _dbContext.Set<T>().Count();
        }

        public T? Get(Expression<Func<T, bool>> predicate)
        {
            try
            {
                if (predicate is not null)
                {
                    return _dbContext.Set<T>().FirstOrDefault(predicate);
                }
                return null;
            }
            catch (Exception exp)
            {
                return null;
            }
            finally
            {

            }
            
        }

        public IEnumerable<T> GetAll()
        {
            return _dbContext.Set<T>().ToList();
        }

        public T? GetId(int id)
        {
            try
            {
                return _dbContext.Set<T>().Find(id);
            }
            catch (Exception exp)
            {

                throw;
            }
            finally
            {

            }
           
        }

        public IEnumerable<T> GetList(Expression<Func<T, bool>> where = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderby = null, string includes = "")
        {
            try
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
            catch (Exception exp)
            {

                throw;
            }
            finally
            {

            }
           
        }

        public void Remove(T objModel)
        {
            try
            {

            }
            catch (Exception exp)
            {

                throw;
            }
            finally
            {

            }
            _dbContext.Set<T>().Remove(objModel);
            _dbContext.SaveChanges();
        }

        public void Update(T objModel)
        {
            try
            {

            }
            catch (Exception exp)
            {

                throw;
            }
            finally
            {

            }
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
