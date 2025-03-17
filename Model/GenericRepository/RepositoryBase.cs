using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.Abstractions;
using Model.Context;
using Model.Models;
using static Model.Models.ReturnMethod;

namespace Model.GenericRepository
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        #region Filds

        protected readonly DbSet<T> _dbset;

        #endregion

        #region Ctor

        public RepositoryBase()
        {
            
        }

        #endregion

        #region Methods

        public ReturnTypes Add(T objModel)
        {
            using (var context = new FinalProjectDbContext())
            {
                try
                {
                    if (objModel is not null)
                    {
                        context.Set<T>().Add(objModel);
                        context.SaveChanges();
                        return ReturnTypes.Success;
                    }
                    return ReturnTypes.NullReference;
                }
                catch (Exception exp)
                {
                    //Log Exception
                    return ReturnTypes.Error;
                }
                finally
                {
                    if (context is not null)
                    {
                        context.Dispose();
                    }
                }
            }
        }

        public int Count()
        {
            using (FinalProjectDbContext context = new())
            {
                return context.Set<T>().Count();
            }
        }

        public T? Get(Expression<Func<T, bool>> predicate)
        {
            using (FinalProjectDbContext context = new())
            {
                try
                {
                    if (predicate is not null)
                    {
                        return context.Set<T>().FirstOrDefault(predicate);
                    }
                    return null;
                }
                catch (Exception exp)
                {
                    //Log Exception
                    return null;
                }
                if (context is not null)
                {
                    context.Dispose();
                }
            }
        }

        public IEnumerable<T> GetAll()
        {
            using (FinalProjectDbContext context = new())
            {
                return context.Set<T>().ToList();
            }
        }

        public T? GetId(int id)
        {
            using (FinalProjectDbContext context = new())
            {
                try
                {
                    return context.Set<T>().Find(id);
                }
                catch (NullReferenceException exp)
                {
                    //Log Exception
                    return null;
                }
                catch (Exception exp)
                {
                    //Log Exception
                    return null;
                }
                finally
                {
                    if (context is not null)
                    {
                        context.Dispose();
                    }
                }
            }
        }

        public IEnumerable<T> GetList(Expression<Func<T, bool>> where = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderby = null, string includes = "")
        {
            try
            {
                IQueryable<T> query = _dbset;

                if (where is not null)
                {
                    query = query.Where(where);
                }

                if (orderby is not null)
                {
                    query = orderby(query);
                }

                if (includes is not "")
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
                //Log Exception
                return null;
            }
        }

        public ReturnTypes Remove(T objModel)
        {
            using (FinalProjectDbContext context = new())
            {
                try
                {
                    context.Set<T>().Remove(objModel);
                    context.SaveChanges();
                    return ReturnTypes.Success;
                }
                catch (Exception exp)
                {
                    //Log Exception
                    return ReturnTypes.Error;
                }
                finally
                {
                    if (context is not null)
                    {
                        context.Dispose();
                    }
                }
            }
        }

        public ReturnTypes Update(T objModel)
        {
            using (FinalProjectDbContext context = new())
            {
                try
                {
                    context.Entry(objModel).State = EntityState.Modified;
                    context.SaveChanges();
                    return ReturnTypes.Success;
                }
                catch (Exception exp)
                {
                    //Log Exception
                    return ReturnTypes.Error;
                }
                finally
                {
                    if (context is not null)
                    {
                        context.Dispose();
                    }
                }
            }

        }

        #endregion

    }
}
