using System.Linq.Expressions;
using static Model.Models.ReturnMethod;

namespace Model.GenericRepository
{
    public interface IRepositoryBase<T> where T : class
    {
        ReturnTypes Add(T objModel);
        T? GetId(int id);
        T? Get(Expression<Func<T, bool>> predicate);
        IEnumerable<T> GetList(Expression<Func<T, bool>> where = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderby = null, string includes = "");
        IEnumerable<T> GetAll();
        int Count();
        ReturnTypes Update(T objModel);
        ReturnTypes Remove(T objModel);
    }
}
