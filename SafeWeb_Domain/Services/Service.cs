using System.Collections.Generic;
using System.Threading.Tasks;
using SafeWeb_Domain.Interfaces.Repository;
using SafeWeb_Domain.Interfaces.Services;

namespace SafeWeb_Domain.Services {
    public class Service<TEntity> : IService<TEntity> where TEntity : class {
        private readonly IRepository<TEntity> _repository;

        public Service (IRepository<TEntity> repository) {
            _repository = repository;
        }

        public void Add (TEntity obj) {
            _repository.Add (obj);
        }

        public TEntity GetById (int id) {
            return _repository.GetById (id);
        }

        public IEnumerable<TEntity> GetAll () {
            return _repository.GetAll ();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public void Update (TEntity obj, object key) {
            _repository.Update (obj, key);
        }

        public void Remove (TEntity obj, object key) {
            _repository.Remove (obj, key);
        }
    }
}