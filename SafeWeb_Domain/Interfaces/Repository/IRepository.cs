using System.Collections.Generic;
using System.Threading.Tasks;

namespace SafeWeb_Domain.Interfaces.Repository {
    public interface IRepository<TEntity> where TEntity : class {
        void Add (TEntity obj);
        TEntity Select (object key);
        TEntity GetById (int id);
        IEnumerable<TEntity> GetAll ();
        Task<IEnumerable<TEntity>> GetAllAsync();
        void Update (TEntity item, object key);
        void Remove (TEntity item, object key);

    }
}