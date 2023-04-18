

using Bigio.Persistence.RepositoryContext;

namespace Bigio.Presistence.Interface;

public interface IRepositoryBase<T>
{
    IEnumerator<T> FindAll<T>(string sql);
    IEnumerator<T> FindByCondition<T>(SqlCommandModel model);

    IAsyncEnumerator<T> FindAllAsync<T>(SqlCommandModel model);

    Task<IEnumerable<T>> GetAllAsync<T>(SqlCommandModel model);
    void Create(SqlCommandModel model);
    void Update(SqlCommandModel model);
    void Delete(SqlCommandModel model);
}