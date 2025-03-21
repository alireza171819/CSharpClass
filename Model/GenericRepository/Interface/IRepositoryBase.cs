using System.Linq.Expressions;
using Model.Dtos;

namespace Model.GenericRepository.Interface
{
    public interface IRepositoryBase<T> where T : class
    {
        ReturnRepository Add(T objModel);
        T? GetId(int id);
        T? Get(Expression<Func<T, bool>> predicate);
        IEnumerable<T> GetList(Expression<Func<T, bool>> where = null);
        IEnumerable<T> GetList(Expression<Func<T, bool>> where = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderby = null, string includes = "");
        IEnumerable<T> GetAll();
        int Count();
        ReturnRepository Update(T objModel);
        ReturnRepository Remove(T objModel);
    }
}
