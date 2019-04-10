using System.Collections.Generic;
using System.Threading.Tasks;

namespace SafeWeb_Aplication.Interfaces {
    public interface IAppService<T> where T : class {
        void Add (T obj);
        T GetById (int id);
        IEnumerable<T> GetAll ();
        Task<IEnumerable<T>> GetAllAsync();
        void Update (T obj, object key);
        void Remove (T obj, object key);
    }
}