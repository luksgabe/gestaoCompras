using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Threading.Tasks;
using SafeWeb_Aplication.Interfaces;
using SafeWeb_Domain.Interfaces.Services;

namespace SafeWeb_Aplication.AppServices {
    public class AppService<T> : IAppService<T> where T : class
    {
        private readonly IService<T> _serviceBase;

        public AppService(IService<T> serviceBase)
        {
            _serviceBase = serviceBase;
        }

        public void Add(T obj)
        {
            _serviceBase.Add(obj);
        }

        public T GetById(int id)
        {
            return _serviceBase.GetById(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _serviceBase.GetAll();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _serviceBase.GetAllAsync();
        }

        public void Update(T obj, object key)
        {
            _serviceBase.Update(obj, key);
        }

        public void Remove(T obj, object key)
        {
            _serviceBase.Remove(obj, key);
        }

    }
}