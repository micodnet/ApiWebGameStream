namespace Api_Model.Jeux_Repositories
{
    public interface IRepository<T, Tkey>
        where T : class
    {
        T GetOne(Tkey id);
        IEnumerable<T> GetAll();
        T Add(T entity);
        T Delete(Tkey id);
        T Put(T entity);
        T Patch(T entity);
    }
}