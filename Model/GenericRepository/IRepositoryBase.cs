using System.Linq.Expressions;

namespace Model.GenericRepository
{
    public interface IRepositoryBase<T> where T : class
    {
        void Add(T objModel);
        T? GetId(int id);
        T? Get(Expression<Func<T, bool>> predicate);
        IEnumerable<T> GetList(Expression<Func<T, bool>> where = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderby = null, string includes = "");
        IEnumerable<T> GetAll();
        int Count();
        void Update(T objModel);
        void Remove(T objModel);
        void Dispose();
    }
}
