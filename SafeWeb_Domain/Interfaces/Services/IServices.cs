using System.Collections.Generic;
using System.Threading.Tasks;

namespace SafeWeb_Domain.Interfaces.Services {
    public interface IService<TEntity> where TEntity : class {
        void Add (TEntity obj);
        TEntity GetById (int id);
        IEnumerable<TEntity> GetAll ();
        Task<IEnumerable<TEntity>> GetAllAsync();
        void Update (TEntity obj, object key);
        void Remove (TEntity obj, object key);
    }
}