namespace Model.GenericRepository
{
    public interface IGenericRepository<T> where T : class
    {
        T Find(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> FindAll();
        void Insert(T obj);
        void Update(T obj);
        void Delete(object id);
        void Save();

    }
}
